// Copyright (c) Improbable Worlds Ltd, All Rights Reserved

using UnrealBuildTool;
using System.Collections.Generic;

public class SpatialExampleProjecServerTarget : TargetRules
{
	public SpatialExampleProjecServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
		ExtraModuleNames.Add("SpatialExampleProjec");
	}
}
