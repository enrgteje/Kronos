using UnrealBuildTool;

public class KronosTarget : TargetRules
{
	public KronosTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Kronos");
	}
}
