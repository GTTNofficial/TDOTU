// GTTN All Rights Reserved

using UnrealBuildTool;
using System.Collections.Generic;

public class TDOTUTarget : TargetRules
{
	public TDOTUTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "TDOTU" } );
	}
}
