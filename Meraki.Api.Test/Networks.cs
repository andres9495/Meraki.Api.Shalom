﻿using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Meraki.Api.Test
{
	public class Networks : MerakiClientTest
	{
		[Fact]
		public async void GetAllSsidsAsync_Succeeds()
		{
			var result = await MerakiClient
				.Networks
				.GetAllSsidsAsync(Configuration.TestNetworkId)
				.ConfigureAwait(false);
			Assert.NotNull(result);
			Assert.NotEmpty(result);
		}

		[Fact]
		public async void GetAllDevicesAsync_Succeeds()
		{
			var result = await MerakiClient
				.Networks
				.GetDevicesAsync(Configuration.TestNetworkId)
				.ConfigureAwait(false);
			Assert.NotNull(result);
			Assert.NotEmpty(result);
		}

		[Fact]
		public async void SimpleCreateDelete_Succeeds()
		{
			var networkName = new string('X', Network.MaxNameLength);

			await EnsureNetworkRemovedAsync(networkName)
				.ConfigureAwait(false);

			// Create network
			var newNetwork = await MerakiClient
				.Organizations
				.CreateNetworkAsync(
					Configuration.TestOrganizationId,
					networkName,
					"wireless switch appliance",
					"network_level",
					"Europe/London")
				.ConfigureAwait(false);

			// And delete it again
			await MerakiClient
				.Networks
				.DeleteNetworkAsync(newNetwork.Id)
				.ConfigureAwait(false);
		}

		[Fact]
		public async void NameTooLong_Fails()
		{
			var networkName = new string('X', Network.MaxNameLength + 1);

			await Assert.ThrowsAsync<ApiException>(async () =>
				 {
					 // Create network
					 var newNetwork = await MerakiClient
						  .Organizations
						  .CreateNetworkAsync(
							  Configuration.TestOrganizationId,
							  networkName,
							  "wireless switch appliance",
							  "network_level",
							  "Europe/London")
						  .ConfigureAwait(false);
				 }).ConfigureAwait(false);
		}

		private async Task EnsureNetworkRemovedAsync(string networkName)
		{
			// Perform any clean-up
			var oldNetwork = (await MerakiClient
				.Organizations.GetAllNetworksAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false)).SingleOrDefault(n => n.Name == networkName);
			if (oldNetwork != default)
			{
				// Get all network devices and remove them
				var oldNetworkDevices = await MerakiClient
					.Networks
					.GetDevicesAsync(oldNetwork.Id)
					.ConfigureAwait(false);
				foreach (var oldNetworkDevice in oldNetworkDevices)
				{
					await MerakiClient
						.Networks
						.RemoveDeviceAsync(oldNetwork.Id, oldNetworkDevice.Serial)
						.ConfigureAwait(false);
				}

				await MerakiClient
					.Networks
					.DeleteNetworkAsync(oldNetwork.Id)
					.ConfigureAwait(false);
			}
		}

		[Fact]
		public async void CreateClaimRemoveDelete_Succeeds()
		{
			const string networkName = "Meraki.Api Unit Test";

			//var bulkClaim = await MerakiClient
			//	.Organizations
			//	.BulkClaimAsync(Configuration.TestOrganizationId, new OrganizationBulkClaim { Serials = new List<string> { Configuration.TestDeviceSerial } })
			//	.ConfigureAwait(false);

			// Get the device
			var devices = await MerakiClient
				.Organizations
				.GetAllInventoryAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			var device = devices.SingleOrDefault(d => d.Serial == Configuration.TestDeviceSerial);
			if (device?.NetworkId != null)
			{
				// Unclaim the device
				await MerakiClient
					 .Networks
					 .RemoveDeviceAsync(device.NetworkId, Configuration.TestDeviceSerial)
					 .ConfigureAwait(false);
			}

			// Perform any clean-up
			await EnsureNetworkRemovedAsync(networkName)
				.ConfigureAwait(false);

			// Create network
			var newNetwork = await MerakiClient
				.Organizations
				.CreateNetworkAsync(
					Configuration.TestOrganizationId,
					networkName,
					"wireless switch appliance",
					"network_level",
					"Europe/London")
				.ConfigureAwait(false);

			Assert.NotNull(newNetwork);

			// Re-fetch the network
			var refetchedNetwork = await MerakiClient
				.Networks
				.GetAsync(newNetwork.Id)
				.ConfigureAwait(false);

			Assert.Equal(newNetwork.Name, refetchedNetwork.Name);

			// Bind and unbind a configuration template
			var configurationTemplates = await MerakiClient
				.Organizations
				.GetAllConfigurationTemplatesAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			Assert.NotNull(configurationTemplates);
			Assert.NotEmpty(configurationTemplates);
			var configurationTemplate = configurationTemplates[0];
			await MerakiClient
				.Networks
				.BindTemplateAsync(newNetwork.Id, configurationTemplate.Id, true)
				.ConfigureAwait(false);

			//// Enable VLANS on the new network and check it worked
			//var networkVlansEnabledStatus = await MerakiClient
			//	.Networks
			//	.SetVlansEnabledStateAsync(newNetwork.Id, true)
			//	.ConfigureAwait(false);
			//Assert.NotNull(networkVlansEnabledStatus);
			//Assert.Equal(newNetwork.Id, networkVlansEnabledStatus.NetworkId);
			//Assert.True(networkVlansEnabledStatus.Enabled);

			// Get all VLANs - should be the default one
			var initialVlans = await MerakiClient
				.Networks
				.GetAllVlansAsync(newNetwork.Id)
				.ConfigureAwait(false);
			Assert.NotNull(initialVlans);
			//Assert.Single(initialVlans);

			var vlan10 = initialVlans.SingleOrDefault(v => v.Id == "10");
			Assert.NotNull(vlan10);

			// Update a VLAN
			var updatedVlan = await MerakiClient
				.Networks
				.UpdateVlanAsync(newNetwork.Id, vlan10.Id, new VlanSpec
				{
					Subnet = "10.250.82.128/28",
					ApplianceIp = "10.250.82.129",
					FixedIpAssignments = new Dictionary<string, FixedIpAssignment>
					{
						{ "22:33:44:55:66:77", new FixedIpAssignment { Ip = "1.2.3.4", Name = "Woo" } }
					}
				})
				.ConfigureAwait(false);
			Assert.NotNull(updatedVlan);

			//// Add a VLAN
			//const string vlanId = "1234";
			//const string vlanName = "My VLAN";
			//const string vlanSubnet = "10.222.1.0/24";
			//const string vlanIpAddress = "10.222.1.1";
			//await MerakiClient
			//	.Networks
			//	.AddVlanAsync(newNetwork.Id, vlanId, vlanName, vlanSubnet, vlanIpAddress)
			//	.ConfigureAwait(false);

			//// Get all VLANs - should have the added VLAN
			//var initializedVlans = await MerakiClient
			//	.Networks
			//	.GetAllVlansAsync(newNetwork.Id)
			//	.ConfigureAwait(false);
			//Assert.NotNull(initializedVlans);
			//Assert.Equal(2, initializedVlans.Count);
			//var initializedVlan = initializedVlans[1]; // the second
			//Assert.Equal(vlanId, initializedVlan.Id);
			//Assert.Equal(vlanName, initializedVlan.Name);
			//Assert.Equal(vlanSubnet, initializedVlan.Subnet);
			//Assert.Equal(vlanIpAddress, initializedVlan.ApplianceIp);

			//--- Claim/Remove device
			await MerakiClient
				.Networks
				.ClaimDeviceAsync(newNetwork.Id, Configuration.TestDeviceSerial, true)
				.ConfigureAwait(false);

			// Make sure it's there.
			var fetchedDevice = await MerakiClient
				.Networks
				.GetDeviceAsync(newNetwork.Id, Configuration.TestDeviceSerial)
				.ConfigureAwait(false);
			Assert.NotNull(fetchedDevice);

			// Get the management interface settings
			var wanSpecs = await MerakiClient
				.Networks
				.GetDeviceManagementInterfaceSettingsAsync(newNetwork.Id, Configuration.TestDeviceSerial)
				.ConfigureAwait(false);
			Assert.NotNull(wanSpecs);

			const string googleDns = "8.8.8.8";
			var newWanSpecs = new WanSpecs
			{
				WanSpec1 = new WanSpec
				{
					StaticDns = new List<string> { googleDns },
					StaticGatewayIp = "192.168.1.1",
					StaticIp = "192.168.1.254",
					StaticSubnetMask = "255.255.255.0",
					UsingStaticIp = true,
					Vlan = 1,
					WanEnabled = WanEnabledStatus.Enabled
				},
				WanSpec2 = new WanSpec
				{
					WanEnabled = WanEnabledStatus.Disabled
				}
			};
			var wanSpec = await MerakiClient
				.Networks
				.UpdateDeviceManagementInterfaceSettingsAsync(newNetwork.Id, Configuration.TestDeviceSerial, newWanSpecs)
				.ConfigureAwait(false);
			Assert.NotNull(wanSpec);

			// Get the management interface settings
			var wanSpecsRefetch = await MerakiClient
				.Networks
				.GetDeviceManagementInterfaceSettingsAsync(newNetwork.Id, Configuration.TestDeviceSerial)
				.ConfigureAwait(false);
			Assert.NotNull(wanSpecsRefetch);
			Assert.NotNull(wanSpecsRefetch.WanSpec1);
			Assert.NotNull(wanSpecsRefetch.WanSpec1!.StaticDns);
			Assert.Single(wanSpecsRefetch.WanSpec1.StaticDns);
			Assert.NotNull(wanSpecsRefetch.WanSpec1.StaticDns);
			Assert.Equal(googleDns, wanSpecsRefetch.WanSpec1.StaticDns![0]);

			// Get all organization devices and make sure ours is present
			var allOrganizationDevices = await MerakiClient
				.Organizations
				.GetAllDevicesAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			Assert.NotNull(allOrganizationDevices);
			Assert.Contains(allOrganizationDevices, d => d.Serial == Configuration.TestDeviceSerial);

			// ----------
			// Create complete - now undo everything
			// ----------

			await MerakiClient
				.Networks
				.RemoveDeviceAsync(newNetwork.Id, Configuration.TestDeviceSerial)
				.ConfigureAwait(false);

			await MerakiClient
				.Networks
				.UnbindTemplateAsync(newNetwork.Id)
				.ConfigureAwait(false);

			//--- Delete the network

			// Delete the network
			await MerakiClient
				.Networks
				.DeleteNetworkAsync(newNetwork.Id)
				.ConfigureAwait(false);

			// Re-fetch the non-existent network
			await Assert.ThrowsAsync<ApiException>(async () =>
			{
				var _ = await MerakiClient
					.Networks
					.GetAsync(newNetwork.Id)
					.ConfigureAwait(false);
			}).ConfigureAwait(false);
		}
	}
}