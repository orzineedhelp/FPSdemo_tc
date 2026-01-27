// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class FPSdemo_tc : ModuleRules
{
	public FPSdemo_tc(ReadOnlyTargetRules Target) : base(Target)
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
			"Slate",
			"OnlineSubsystemSteam",
            "OnlineSubsystem"
        });

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"FPSdemo_tc",
			"FPSdemo_tc/Variant_Horror",
			"FPSdemo_tc/Variant_Horror/UI",
			"FPSdemo_tc/Variant_Shooter",
			"FPSdemo_tc/Variant_Shooter/AI",
			"FPSdemo_tc/Variant_Shooter/UI",
			"FPSdemo_tc/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
