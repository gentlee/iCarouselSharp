using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libiCarousel-i386.a", LinkTarget.Simulator, ForceLoad = true,
                     Frameworks="QuartzCore " + 
                     "UIKit " + 
                     "CoreGraphics " +
                     "Foundation")]