using System;
using ObjCRuntime;

[assembly: LinkWith ("libMarqueeLabelBinding.a", LinkTarget.ArmV7 | LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]
