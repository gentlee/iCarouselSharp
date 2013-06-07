using System;
using System.Collections.Generic;
using iCarouselSharp;

namespace iCarouselSharpExample
{
//	Option default values:
//	 
//		Wrap : 0
//		FadeMin : -Infinity
//		FadeMax : Infinity
//		FadeRange : 1
//		Tilt : 0.9
//		Spacing : 0.25
//		ShowBackfaces : 1
//		VisibleItems : 0
//		OffsetMultiplier : 2
//

	public class CarouselDelegate : iCarouselDelegate
	{
		public override float ValueForOption(iCarousel carousel, iCarouselOption option, float defaultValue)
		{
			switch (option)
			{
				case iCarouselOption.Spacing: return 0.5f;
			}
			
			return defaultValue;
		}
	}
}

