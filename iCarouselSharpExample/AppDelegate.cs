using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace iCarouselSharpExample
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{		
		public override UIWindow Window { get; set; }

		private MainViewController _mainViewCOntroller;

		public override void FinishedLaunching(UIApplication application)
		{
			Window = new UIWindow(UIScreen.MainScreen.Bounds);
			_mainViewCOntroller = new MainViewController();
			Window.RootViewController = _mainViewCOntroller;
			Window.MakeKeyAndVisible();
		}
	}
}

