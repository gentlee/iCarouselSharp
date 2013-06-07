using System;
using System.Collections.Generic;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Reflection;
using iCarouselSharp;

namespace iCarouselSharpExample
{
//	Properties default values
//
//		Perspective : -0.002
//		DecelerationRate : 0.95
//		ScrollSpeed : 0.5
//		BounceDistance : 1
//		ScrollOffset : 0
//		OffsetMultiplier : 2
//		NumberOfItems : 100
//		NumberOfPlaceholders : 0
//		CurrentItemIndex : 0
//		NumberOfVisibleItems : 0
//		ItemWidth : 200
//		Toggle : 0
//

	public class MainViewController : UIViewController
	{
		iCarousel _coverFlow;



		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			View.BackgroundColor = UIColor.White;

			_coverFlow = new iCarousel();
			_coverFlow.Delegate = new CarouselDelegate();
			_coverFlow.DataSource = new CarouselDataSource();
			_coverFlow.Type = iCarouselType.CoverFlow;
			_coverFlow.ScrollSpeed = 0.5f;
			_coverFlow.IgnorePerpendicularSwipes = true;

			Add(_coverFlow);

			_coverFlow.ReloadData();
		}

		public override void ViewDidLayoutSubviews ()
		{
			base.ViewDidLayoutSubviews ();

			_coverFlow.Frame = View.Bounds;
		}

		[Obsolete ("Deprecated in iOS6. Replace it with both GetSupportedInterfaceOrientations and PreferredInterfaceOrientationForPresentation")]
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			return true;
		}
	}
}

