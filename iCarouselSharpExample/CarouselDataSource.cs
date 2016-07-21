using System;
using System.Collections.Generic;
using CoreGraphics;
using UIKit;
using iCarouselSharp;

namespace iCarouselSharpExample
{
	public class CarouselDataSource : iCarouselDataSource
	{
		public override UIView PlaceholderViewAtIndex (iCarousel carousel, nint index, UIView view)
		{
			return null;
		}
		
		public override nint NumberOfPlaceholdersInCarousel (iCarousel carousel)
		{
			return 0;
		}
		
		private List<int> _items;
		
		public CarouselDataSource()
		{
			_items = new List<int>();
			
			for (int i = 0; i < 100; i++)
				_items.Add(i);
		}
		
		public override UIView ViewForItemAtIndex (iCarousel carousel, nint index, UIView reusingView)
		{
			UILabel label = null;
			
			//create new view if no view is available for recycling
			if (reusingView == null)
			{
				var imageView = new UIImageView(new CGRect(0, 0, 200.0f, 200.0f));
				imageView.Image = UIImage.FromFile("page.png");
				imageView.ContentMode = UIViewContentMode.Center;
				
				var frame = new CGRect(0, imageView.Frame.Bottom, imageView.Frame.Width, 75);
				label = new UILabel(frame);
				label.BackgroundColor = UIColor.Clear;
				label.TextAlignment = UITextAlignment.Center;
				label.Font = label.Font.WithSize(50);
				label.Tag = 1;
				imageView.AddSubview(label);
				
				reusingView = imageView;
			}
			else
			{
				//get a reference to the label in the recycled view
				label = (UILabel) reusingView.ViewWithTag(1);
			}
			
			//set item label
			//remember to always set any properties of your carousel item
			//views outside of the `if (view == nil) {...}` check otherwise
			//you'll get weird issues with carousel item content appearing
			//in the wrong place in the carousel
			label.Text = _items[(int) index].ToString();
			label.Font = UIFont.FromName("HelveticaNeue", 12);
			
			return reusingView;
		}
		
		public override nint NumberOfItemsInCarousel (iCarousel carousel)
		{
			return (nint) _items.Count;
		}
	}
}

