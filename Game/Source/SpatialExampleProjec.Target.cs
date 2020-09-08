// Copyright (c) Improbable Worlds Ltd, All Rights Reserved

using UnrealBuildTool;
using System.Collections.Generic;

public class SpatialExampleProjecTarget : TargetRules
{
	public SpatialExampleProjecTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("SpatialExampleProjec");
	}
}
