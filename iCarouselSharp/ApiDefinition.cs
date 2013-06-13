using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreAnimation;

namespace iCarouselSharp
{
	[BaseType (typeof (UIView))]
	interface iCarousel {
		#region Properties

		//@property (nonatomic, weak_delegate) IBOutlet id<iCarouselDataSource> dataSource;
		[Export ("dataSource")]
		iCarouselDataSource DataSource { get; set; }
		
		//@property (nonatomic, weak_delegate) IBOutlet id<iCarouselDelegate> delegate;
		[Export ("delegate")]
		iCarouselDelegate Delegate { get; set; }
		
		//@property (nonatomic, assign) iCarouselType type;
		[Export ("type", ArgumentSemantic.Assign)]
		iCarouselType Type { get; set; }
		
		//@property (nonatomic, assign) CGFloat perspective;
		[Export ("perspective", ArgumentSemantic.Assign)]
		float Perspective { get; set; }
		
		//@property (nonatomic, assign) CGFloat decelerationRate;
		[Export ("decelerationRate", ArgumentSemantic.Assign)]
		float DecelerationRate { get; set; }
		
		//@property (nonatomic, assign) CGFloat scrollSpeed;
		[Export ("scrollSpeed", ArgumentSemantic.Assign)]
		float ScrollSpeed { get; set; }
		
		//@property (nonatomic, assign) CGFloat bounceDistance;
		[Export ("bounceDistance", ArgumentSemantic.Assign)]
		float BounceDistance { get; set; }
		
		//@property (nonatomic, assign, getter = isScrollEnabled) BOOL scrollEnabled;
		[Export ("scrollEnabled", ArgumentSemantic.Assign)]
		bool ScrollEnabled { [Bind ("isScrollEnabled")] get; set; }
		
		//@property (nonatomic, assign, getter = isVertical) BOOL vertical;
		[Export ("vertical", ArgumentSemantic.Assign)]
		bool Vertical { [Bind ("isVertical")] get; set; }
		
		//@property (nonatomic, readonly, getter = isWrapEnabled) BOOL wrapEnabled;
		[Export ("wrapEnabled")]
		bool WrapEnabled { [Bind ("isWrapEnabled")] get; }
		
		//@property (nonatomic, assign) BOOL bounces;
		[Export ("bounces", ArgumentSemantic.Assign)]
		bool Bounces { get; set; }
		
		//@property (nonatomic, assign) CGFloat scrollOffset;
		[Export ("scrollOffset", ArgumentSemantic.Assign)]
		float ScrollOffset { get; set; }
		
		//@property (nonatomic, readonly) CGFloat offsetMultiplier;
		[Export ("offsetMultiplier")]
		float OffsetMultiplier { get; }
		
		//@property (nonatomic, assign) CGSize contentOffset;
		[Export ("contentOffset", ArgumentSemantic.Assign)]
		System.Drawing.SizeF ContentOffset { get; set; }
		
		//@property (nonatomic, assign) CGSize viewpointOffset;
		[Export ("viewpointOffset", ArgumentSemantic.Assign)]
		System.Drawing.SizeF ViewpointOffset { get; set; }
		
		//@property (nonatomic, readonly) NSInteger numberOfItems;
		[Export ("numberOfItems")]
		int NumberOfItems { get; }
		
		//@property (nonatomic, readonly) NSInteger numberOfPlaceholders;
		[Export ("numberOfPlaceholders")]
		int NumberOfPlaceholders { get; }
		
		//@property (nonatomic, assign) NSInteger currentItemIndex;
		[Export ("currentItemIndex")]
		int CurrentItemIndex { get; set; }
		
		//@property (nonatomic, strong, readonly) UIView *currentItemView;
		[Export ("currentItemView")]
		UIView CurrentItemView { get; }
		
		//@property (nonatomic, strong, readonly) NSArray *indexesForVisibleItems;
		[Export ("indexesForVisibleItems")]
		NSArray IndexesForVisibleItems { get; }
		
		//@property (nonatomic, readonly) NSInteger numberOfVisibleItems;
		[Export ("numberOfVisibleItems")]
		int NumberOfVisibleItems { get; }
		
		//@property (nonatomic, strong, readonly) NSArray *visibleItemViews;
		[Export ("visibleItemViews")]
		NSArray VisibleItemViews { get; }
		
		//@property (nonatomic, readonly) CGFloat itemWidth;
		[Export ("itemWidth")]
		float ItemWidth { get; }
		
		//@property (nonatomic, strong, readonly) UIView *contentView;
		[Export ("contentView")]
		UIView ContentView { get; }
		
		//@property (nonatomic, readonly) CGFloat toggle;
		[Export ("toggle")]
		float Toggle { get; }
		
		//@property (nonatomic, assign) BOOL stopAtItemBoundary;
		[Export ("stopAtItemBoundary", ArgumentSemantic.Assign)]
		bool StopAtItemBoundary { get; set; }
		
		//@property (nonatomic, assign) BOOL scrollToItemBoundary;
		[Export ("scrollToItemBoundary", ArgumentSemantic.Assign)]
		bool ScrollToItemBoundary { get; set; }
		
		//@property (nonatomic, assign) BOOL ignorePerpendicularSwipes;
		[Export ("ignorePerpendicularSwipes", ArgumentSemantic.Assign)]
		bool IgnorePerpendicularSwipes { get; set; }
		
		//@property (nonatomic, assign) BOOL centerItemWhenSelected;
		[Export ("centerItemWhenSelected", ArgumentSemantic.Assign)]
		bool CenterItemWhenSelected { get; set; }
		
		//@property (nonatomic, readonly, getter = isDragging) BOOL dragging;
		[Export ("dragging")]
		bool Dragging { [Bind ("isDragging")] get; }
		
		//@property (nonatomic, readonly, getter = isDecelerating) BOOL decelerating;
		[Export ("decelerating")]
		bool Decelerating { [Bind ("isDecelerating")] get; }
		
		//@property (nonatomic, readonly, getter = isScrolling) BOOL scrolling;
		[Export ("scrolling")]
		bool Scrolling { [Bind ("isScrolling")] get; }

		#endregion



		//- (void)scrollByOffset:(CGFloat)offset duration:(NSTimeInterval)duration;
		[Export ("scrollByOffset:duration:")]
		void ScrollByOffset (float offset, double duration);
		
		//- (void)scrollToOffset:(CGFloat)offset duration:(NSTimeInterval)duration;
		[Export ("scrollToOffset:duration:")]
		void ScrollToOffset (float offset, double duration);
		
		//- (void)scrollByNumberOfItems:(NSInteger)itemCount duration:(NSTimeInterval)duration;
		[Export ("scrollByNumberOfItems:duration:")]
		void ScrollByNumberOfItems (int itemCount, double duration);
		
		//- (void)scrollToItemAtIndex:(NSInteger)index duration:(NSTimeInterval)duration;
		[Export ("scrollToItemAtIndex:duration:")]
		void ScrollToItemAtIndex (int index, double duration);
		
		//- (void)scrollToItemAtIndex:(NSInteger)index animated:(BOOL)animated;
		[Export ("scrollToItemAtIndex:animated:")]
		void ScrollToItemAtIndex (int index, bool animated);
		
		//- (UIView *)itemViewAtIndex:(NSInteger)index;
		[Export ("itemViewAtIndex:")]
		UIView ItemViewAtIndex (int index);
		
		//- (NSInteger)indexOfItemView:(UIView *)view;
		[Export ("indexOfItemView:")]
		int IndexOfItemView (UIView view);
		
		//- (NSInteger)indexOfItemViewOrSubview:(UIView *)view;
		[Export ("indexOfItemViewOrSubview:")]
		int IndexOfItemViewOrSubview (UIView view);
		
		//- (CGFloat)offsetForItemAtIndex:(NSInteger)index;
		[Export ("offsetForItemAtIndex:")]
		float OffsetForItemAtIndex (int index);
		
		//- (void)removeItemAtIndex:(NSInteger)index animated:(BOOL)animated;
		[Export ("removeItemAtIndex:animated:")]
		void RemoveItemAtIndex (int index, bool animated);
		
		//- (void)insertItemAtIndex:(NSInteger)index animated:(BOOL)animated;
		[Export ("insertItemAtIndex:animated:")]
		void InsertItemAtIndex (int index, bool animated);
		
		//- (void)reloadItemAtIndex:(NSInteger)index animated:(BOOL)animated;
		[Export ("reloadItemAtIndex:animated:")]
		void ReloadItemAtIndex (int index, bool animated);
		
		//- (void)reloadData;
		[Export ("reloadData")]
		void ReloadData ();
		
	}

	[Model]
	[BaseType (typeof (NSObject))]
	interface iCarouselDataSource {
		
		//- (NSUInteger)numberOfItemsInCarousel:(iCarousel *)carousel;
		[Abstract, Export ("numberOfItemsInCarousel:")]
		uint NumberOfItemsInCarousel (iCarousel carousel);
		
		//- (UIView *)carousel:(iCarousel *)carousel viewForItemAtIndex:(NSUInteger)index reusingView:(UIView *)view;
		[Abstract, Export ("carousel:viewForItemAtIndex:reusingView:")]
		UIView ViewForItemAtIndex (iCarousel carousel, uint index, UIView reusingView);
		
		//@optional- (NSUInteger)numberOfPlaceholdersInCarousel:(iCarousel *)carousel;
		[Abstract, Export ("numberOfPlaceholdersInCarousel:")]
		uint NumberOfPlaceholdersInCarousel (iCarousel carousel);
		
		//- (UIView *)carousel:(iCarousel *)carousel placeholderViewAtIndex:(NSUInteger)index reusingView:(UIView *)view;
		[Abstract, Export ("carousel:placeholderViewAtIndex:reusingView:")]
		UIView PlaceholderViewAtIndex (iCarousel carousel, uint index, UIView view);
		
	}

	[Model]
	[BaseType (typeof (NSObject))]
	interface iCarouselDelegate {
		
		//- (void)carouselWillBeginScrollingAnimation:(iCarousel *)carousel;
		[Export ("carouselWillBeginScrollingAnimation:")]
		void WillBeginScrollingAnimation (iCarousel carousel);
		
		//- (void)carouselDidEndScrollingAnimation:(iCarousel *)carousel;
		[Export ("carouselDidEndScrollingAnimation:")]
		void DidEndScrollingAnimation (iCarousel carousel);
		
		//- (void)carouselDidScroll:(iCarousel *)carousel;
		[Export ("carouselDidScroll:")]
		void DidScroll (iCarousel carousel);
		
		//- (void)carouselCurrentItemIndexDidChange:(iCarousel *)carousel;
		[Export ("carouselCurrentItemIndexDidChange:")]
		void CurrentItemIndexDidChange (iCarousel carousel);
		
		//- (void)carouselWillBeginDragging:(iCarousel *)carousel;
		[Export ("carouselWillBeginDragging:")]
		void WillBeginDragging (iCarousel carousel);
		
		//- (void)carouselDidEndDragging:(iCarousel *)carousel willDecelerate:(BOOL)decelerate;
		[Export ("carouselDidEndDragging:willDecelerate:")]
		void DidEndDragging (iCarousel carousel, bool decelerate);
		
		//- (void)carouselWillBeginDecelerating:(iCarousel *)carousel;
		[Export ("carouselWillBeginDecelerating:")]
		void WillBeginDecelerating (iCarousel carousel);
		
		//- (void)carouselDidEndDecelerating:(iCarousel *)carousel;
		[Export ("carouselDidEndDecelerating:")]
		void DidEndDecelerating (iCarousel carousel);
		
		//- (BOOL)carousel:(iCarousel *)carousel shouldSelectItemAtIndex:(NSInteger)index;
		[Export ("carousel:shouldSelectItemAtIndex:")]
		bool ShouldSelectItemAtIndex (iCarousel carousel, int index);
		
		//- (void)carousel:(iCarousel *)carousel didSelectItemAtIndex:(NSInteger)index;
		[Export ("carousel:didSelectItemAtIndex:")]
		void DidSelectItemAtIndex (iCarousel carousel, int index);
		
		//- (CGFloat)carouselItemWidth:(iCarousel *)carousel;
		[Export ("carouselItemWidth:")]
		float ItemWidth (iCarousel carousel);
		
		//- (CATransform3D)carousel:(iCarousel *)carousel itemTransformForOffset:(CGFloat)offset baseTransform:(CATransform3D)transform;
		[Export ("carousel:itemTransformForOffset:baseTransform:")]
		CATransform3D ItemTransformForOffset (iCarousel carousel, float offset, CATransform3D transform);
		
		//- (CGFloat)carousel:(iCarousel *)carousel valueForOption:(iCarouselOption)option withDefault:(CGFloat)value;
		[Export ("carousel:valueForOption:withDefault:")]
		float ValueForOption (iCarousel carousel, iCarouselOption option, float defaultValue);
		
	}
}

