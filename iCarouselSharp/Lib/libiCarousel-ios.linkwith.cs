using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libiCarousel-ios.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s, ForceLoad = true,
                     Frameworks="QuartzCore " + 
                     "UIKit " + 
                     "CoreGraphics " +
                     "Foundation")]