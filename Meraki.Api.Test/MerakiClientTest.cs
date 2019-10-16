﻿using Meraki.Api.Test.Config;
using Meraki.Api.Test.Exceptions;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Meraki.Api.Test
{
	public class MerakiClientTest
	{
		protected DateTimeOffset UtcNow { get; } = DateTimeOffset.UtcNow;

		protected DateTimeOffset Utc10DaysAgo => UtcNow - TimeSpan.FromDays(10);

		private MerakiClient? _merakiClient;

		private Configuration? _configuration;

		public Configuration Configuration
		{
			get
			{
				// Have we already created this?
				if (_configuration != null)
				{
					// Yes - return that one
					return _configuration;
				}
				// No - we need to create one

				// Load config from file
				var fileInfo = new FileInfo("../../../appsettings.json");

				// Does the config file exist?
				if (!fileInfo.Exists)
				{
					// No - hint to the user what to do
					throw new ConfigurationException("Missing appsettings.json.  Please copy the appsettings.example.json in the project root folder and set the various values appropriately.");
				}
				// Yes

				// Load in the config
				return _configuration = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(fileInfo.FullName));
			}
		}

		protected MerakiClient MerakiClient
			=> _merakiClient ?? (_merakiClient = new MerakiClient(Configuration.MerakiClientOptions));
	}
}