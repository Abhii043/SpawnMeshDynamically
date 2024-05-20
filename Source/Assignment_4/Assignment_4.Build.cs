// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Assignment_4 : ModuleRules
{
	public Assignment_4(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" ,"EnhancedInput" , "UMG"});

        PublicIncludePaths.AddRange(
          new string[] {
				// ... add public include paths required here ...
				"C:/Program Files/Epic Games/UE_5.2/Engine/Plugins/EnhancedInput/Source/EnhancedInput/Public/"
          }
          );

        PrivateDependencyModuleNames.AddRange(new string[] {  });

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
		
		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
