using System;
using ObjCRuntime;

[assembly: LinkWith ("libiCarousel-ios.a", LinkTarget.ArmV7 | LinkTarget.Arm64, ForceLoad = true,
	Frameworks="QuartzCore " + 
	"UIKit " + 
	"CoreGraphics " +
	"Foundation")]