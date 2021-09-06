﻿using Meraki.Api.Exceptions;

namespace Meraki.Api.Test.Config
{
	/// <summary>
	/// Test configuration
	/// </summary>
	public class Configuration
	{
		/// <summary>
		/// Meraki client options
		/// </summary>
		public MerakiClientOptions MerakiClientOptions { get; set; } = null!;

		/// <summary>
		/// Test Organization Id
		/// </summary>
		public string TestOrganizationId { get; set; } = string.Empty;

		/// <summary>
		/// Optional Test Organization Id supporting Per Device Licensing
		/// </summary>
		public string? TestOrganizationIdSupportingPerDeviceLicensing { get; set; }

		/// <summary>
		/// Test Device Serial
		/// </summary>
		public string TestDeviceSerial { get; set; } = string.Empty;

		/// <summary>
		/// Test Camera Serial
		/// </summary>
		public string TestCameraSerial { get; set; } = string.Empty;

		/// <summary>
		/// Test Camera Network Name
		/// </summary>
		public string TestCameraNetworkId { get; set; } = string.Empty;

		/// <summary>
		/// Test Network ID
		/// </summary>
		public string TestNetworkId { get; set; } = string.Empty;

		/// <summary>
		/// Test MAC (Client ID)
		/// </summary>
		public string TestMac { get; set; } = string.Empty;

		public void Validate()
		{
			// MerakiClientOptions should be present
			if (MerakiClientOptions is null)
			{
				throw new ConfigurationException($"Missing {nameof(MerakiClientOptions)}");
			}
			MerakiClientOptions.Validate();

			if (string.IsNullOrWhiteSpace(TestOrganizationId))
			{
				throw new ConfigurationException($"Missing {nameof(TestOrganizationId)}");
			}

			if (string.IsNullOrWhiteSpace(TestDeviceSerial))
			{
				throw new ConfigurationException($"Missing {nameof(TestDeviceSerial)}");
			}

			if (string.IsNullOrWhiteSpace(TestCameraSerial))
			{
				throw new ConfigurationException($"Missing {nameof(TestCameraSerial)}");
			}

			if (string.IsNullOrWhiteSpace(TestCameraNetworkId))
			{
				throw new ConfigurationException($"Missing {nameof(TestCameraNetworkId)}");
			}

			if (string.IsNullOrWhiteSpace(TestNetworkId))
			{
				throw new ConfigurationException($"Missing {nameof(TestNetworkId)}");
			}

			if (string.IsNullOrWhiteSpace(TestMac))
			{
				throw new ConfigurationException($"Missing {nameof(TestMac)}");
			}
		}
	}
}
