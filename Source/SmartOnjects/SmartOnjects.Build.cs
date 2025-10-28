// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class SmartOnjects : ModuleRules
{
	public SmartOnjects(ReadOnlyTargetRules Target) : base(Target)
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
			"SmartOnjects",
			"SmartOnjects/Variant_Platforming",
			"SmartOnjects/Variant_Platforming/Animation",
			"SmartOnjects/Variant_Combat",
			"SmartOnjects/Variant_Combat/AI",
			"SmartOnjects/Variant_Combat/Animation",
			"SmartOnjects/Variant_Combat/Gameplay",
			"SmartOnjects/Variant_Combat/Interfaces",
			"SmartOnjects/Variant_Combat/UI",
			"SmartOnjects/Variant_SideScrolling",
			"SmartOnjects/Variant_SideScrolling/AI",
			"SmartOnjects/Variant_SideScrolling/Gameplay",
			"SmartOnjects/Variant_SideScrolling/Interfaces",
			"SmartOnjects/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
