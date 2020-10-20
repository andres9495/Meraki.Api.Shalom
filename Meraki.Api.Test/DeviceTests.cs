﻿using FluentAssertions;
using Meraki.Api.Data;
using Xunit;
using Xunit.Abstractions;

namespace Meraki.Api.Test
{
	public class DeviceTests : MerakiClientTest
	{
		public DeviceTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
		{
		}

		[Fact]
		public async void GetNetworkDeviceUplink_Succeeds()
		{
			var devices = await MerakiClient
				.Devices
				.GetAllByNetworkAsync(Configuration.TestNetworkId)
				.ConfigureAwait(false);

			devices
				.Should()
				.NotBeNull()
				.And
				.NotBeEmpty();

			var deviceSerial = devices[0].Serial;

			var uplinkProperties = await MerakiClient
				.Devices
				.GetNetworkDeviceUplink(Configuration.TestCameraNetworkId, deviceSerial)
				.ConfigureAwait(false);

			uplinkProperties.Should().NotBeNull();
		}

		[Fact]
		public async void GetDeviceAsync_Succeeds()
		{
			var devices = await MerakiClient
				.Devices
				.GetAllByNetworkAsync(Configuration.TestCameraNetworkId)
				.ConfigureAwait(false);

			devices
				.Should()
				.NotBeNull()
				.And
				.NotBeEmpty();

			var deviceSerial = devices[0].Serial;

			var device = await MerakiClient
				.Devices
				.GetAsync(Configuration.TestCameraNetworkId, deviceSerial)
				.ConfigureAwait(false);
			device.Should().NotBeNull();

			device.Serial.Should().Equals(deviceSerial);
			device.Firmware.Should().NotBeNull();
		}

		[Fact]
		public async void PutDeviceAsync_WithMoveMapMarker_Succeeds()
		{
			var devices = await MerakiClient
				.Devices
				.GetAllByNetworkAsync(Configuration.TestCameraNetworkId)
				.ConfigureAwait(false);

			devices
				.Should()
				.NotBeNull()
				.And
				.NotBeEmpty();

			var deviceSerial = devices[0].Serial;

			var device = await MerakiClient
				.Devices
				.GetAsync(Configuration.TestCameraNetworkId, deviceSerial)
				.ConfigureAwait(false);

			device.Should().NotBeNull();
			device.Serial.Should().Equals(deviceSerial);
			device.Firmware.Should().NotBeNull();

			if (device.Address != string.Empty)
			{
				await MerakiClient
					.Devices
					.UpdateAsync(
						Configuration.TestCameraNetworkId,
						device.Serial,
						new DeviceUpdateRequest
						{
							Address = string.Empty
						}
					)
					.ConfigureAwait(false);
			}
			// Device now has blank address
			var updatedDevice = await MerakiClient
				.Devices
				.UpdateAsync(
					Configuration.TestCameraNetworkId,
					device.Serial,
					new DeviceUpdateRequest
					{
						Address = "Picadilly Circus, London",
						MoveMapMarker = true
					}
				)
				.ConfigureAwait(false);
		}

		[Fact]
		public async void BlinkDeviceAsync_Succeeds()
		{
			var devices = await MerakiClient
				.Devices
				.GetAllByNetworkAsync(Configuration.TestCameraNetworkId)
				.ConfigureAwait(false);

			devices
				.Should()
				.NotBeNull()
				.And
				.NotBeEmpty();

			var deviceSerial = devices[0].Serial;

			var outcome = await MerakiClient
				.Devices
				.BlinkLedsAsync(
					Configuration.TestCameraNetworkId,
					deviceSerial,
					new Data.DeviceLedsBlinkRequest
					{
						Duration = 1,
						//Duty = 50,
						//Period
					})
				.ConfigureAwait(false);

			outcome
				.Should()
				.NotBeNull();
		}
	}
}
