﻿using clipr;

namespace Harbor.Tagd.Args
{
	[ApplicationInfo(Description = "Tag Cleanup daemon for VMware Harbor Registries", Name = "tagd")]
	public class ApplicationSettings : CommonArgs
	{
		private const string VALIDATE_OR_PROCESS = "ValidateOrProcess";

		[NamedArgument("endpoint", Description = "The harbor registry to connect to", Required = true)]
		[MutuallyExclusiveGroup(VALIDATE_OR_PROCESS, Required = true)]
		public string Endpoint { get; set; }

		[NamedArgument('u', "user", Description = "The user to connect to harbor as", Required = true)]
		public string Username { get; set; }

		[NamedArgument('p', "password", Description = "The password for the user connecting to harbor", Required = true)]
		[PromptIfValueMissing(MaskInput = true)]
		public string Password { get; set; }

		[NamedArgument("destructive", Description = "Actually delete tags instead of generating a report", Action = ParseAction.StoreFalse)]
		public bool Nondestructive { get; set; } = true;

		[NamedArgument("notify-slack", Description = "Post results to this slack-compatible webhook")]
		public string SlackWebhook { get; set; }
	}
}
