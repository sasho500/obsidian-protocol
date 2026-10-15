// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ObsidianProtocol : ModuleRules
{
	public ObsidianProtocol(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ObsidianProtocol",
			"ObsidianProtocol/Variant_Horror",
			"ObsidianProtocol/Variant_Horror/UI",
			"ObsidianProtocol/Variant_Shooter",
			"ObsidianProtocol/Variant_Shooter/AI",
			"ObsidianProtocol/Variant_Shooter/UI",
			"ObsidianProtocol/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
