// GTTN All Rights Reserved

using UnrealBuildTool;
using System.Collections.Generic;

public class TDOTUEditorTarget : TargetRules
{
	public TDOTUEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "TDOTU" } );
	}
}
