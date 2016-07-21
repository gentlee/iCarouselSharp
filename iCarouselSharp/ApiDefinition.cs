using System;
using System.Drawing;
using Foundation;
using CoreGraphics;
using UIKit;
using CoreAnimation;
using ObjCRuntime;

namespace iCarouselSharp
{
	// @interface iCarousel : UIView
	[BaseType (typeof (UIView))]
	[Protocol]
	interface iCarousel {

		// @property (nonatomic, unsafe_unretained) id<iCarouselDataSource> dataSource;
		[Export ("dataSource", ArgumentSemantic.UnsafeUnretained)]
		iCarouselDataSource DataSource { get; set; }

		// @property (nonatomic, unsafe_unretained) id<iCarouselDelegate> delegate;
		[Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, unsafe_unretained) id<iCarouselDelegate> delegate;
		[Wrap ("WeakDelegate")]
		iCarouselDelegate Delegate { get; set; }

		// @property (assign, nonatomic) iCarouselType type;
		[Export ("type", ArgumentSemantic.UnsafeUnretained)]
		iCarouselType Type { get; set; }

		// @property (assign, nonatomic) CGFloat perspective;
		[Export ("perspective", ArgumentSemantic.UnsafeUnretained)]
		nfloat Perspective { get; set; }

		// @property (assign, nonatomic) CGFloat decelerationRate;
		[Export ("decelerationRate", ArgumentSemantic.UnsafeUnretained)]
		nfloat DecelerationRate { get; set; }

		// @property (assign, nonatomic) CGFloat scrollSpeed;
		[Export ("scrollSpeed", ArgumentSemantic.UnsafeUnretained)]
		nfloat ScrollSpeed { get; set; }

		// @property (assign, nonatomic) CGFloat bounceDistance;
		[Export ("bounceDistance", ArgumentSemantic.UnsafeUnretained)]
		nfloat BounceDistance { get; set; }

		// @property (assign, nonatomic, getter = isScrollEnabled) BOOL scrollEnabled;
		[Export ("scrollEnabled", ArgumentSemantic.UnsafeUnretained)]
		bool ScrollEnabled { [Bind ("isScrollEnabled")] get; set; }

		// @property (assign, nonatomic, getter = isPagingEnabled) BOOL pagingEnabled;
		[Export ("pagingEnabled", ArgumentSemantic.UnsafeUnretained)]
		bool PagingEnabled { [Bind ("isPagingEnabled")] get; set; }

		// @property (assign, nonatomic, getter = isVertical) BOOL vertical;
		[Export ("vertical", ArgumentSemantic.UnsafeUnretained)]
		bool Vertical { [Bind ("isVertical")] get; set; }

		// @property (readonly, nonatomic, getter = isWrapEnabled) BOOL wrapEnabled;
		[Export ("wrapEnabled")]
		bool WrapEnabled { [Bind ("isWrapEnabled")] get; }

		// @property (assign, nonatomic) BOOL bounces;
		[Export ("bounces", ArgumentSemantic.UnsafeUnretained)]
		bool Bounces { get; set; }

		// @property (assign, nonatomic) CGFloat scrollOffset;
		[Export ("scrollOffset", ArgumentSemantic.UnsafeUnretained)]
		nfloat ScrollOffset { get; set; }

		// @property (readonly, nonatomic) CGFloat offsetMultiplier;
		[Export ("offsetMultiplier")]
		nfloat OffsetMultiplier { get; }

		// @property (assign, nonatomic) CGSize contentOffset;
		[Export ("contentOffset", ArgumentSemantic.UnsafeUnretained)]
		CGSize ContentOffset { get; set; }

		// @property (assign, nonatomic) CGSize viewpointOffset;
		[Export ("viewpointOffset", ArgumentSemantic.UnsafeUnretained)]
		CGSize ViewpointOffset { get; set; }

		// @property (readonly, nonatomic) NSInteger numberOfItems;
		[Export ("numberOfItems")]
		nint NumberOfItems { get; }

		// @property (readonly, nonatomic) NSInteger numberOfPlaceholders;
		[Export ("numberOfPlaceholders")]
		nint NumberOfPlaceholders { get; }

		// @property (assign, nonatomic) NSInteger currentItemIndex;
		[Export ("currentItemIndex", ArgumentSemantic.UnsafeUnretained)]
		nint CurrentItemIndex { get; set; }

		// @property (readonly, nonatomic, strong) UIView * currentItemView;
		[Export ("currentItemView", ArgumentSemantic.Retain)]
		UIView CurrentItemView { get; }

		// @property (readonly, nonatomic, strong) NSArray * indexesForVisibleItems;
		[Export ("indexesForVisibleItems", ArgumentSemantic.Retain)]
		NSObject [] IndexesForVisibleItems { get; }

		// @property (readonly, nonatomic) NSInteger numberOfVisibleItems;
		[Export ("numberOfVisibleItems")]
		int NumberOfVisibleItems { get; }

		// @property (readonly, nonatomic, strong) NSArray * visibleItemViews;
		[Export ("visibleItemViews", ArgumentSemantic.Retain)]
		NSObject [] VisibleItemViews { get; }

		// @property (readonly, nonatomic) CGFloat itemWidth;
		[Export ("itemWidth")]
		float ItemWidth { get; }

		// @property (readonly, nonatomic, strong) UIView * contentView;
		[Export ("contentView", ArgumentSemantic.Retain)]
		UIView ContentView { get; }

		// @property (readonly, nonatomic) CGFloat toggle;
		[Export ("toggle")]
		float Toggle { get; }

		// @property (assign, nonatomic) CGFloat autoscroll;
		[Export ("autoscroll", ArgumentSemantic.UnsafeUnretained)]
		float Autoscroll { get; set; }

		// @property (assign, nonatomic) BOOL stopAtItemBoundary;
		[Export ("stopAtItemBoundary", ArgumentSemantic.UnsafeUnretained)]
		bool StopAtItemBoundary { get; set; }

		// @property (assign, nonatomic) BOOL scrollToItemBoundary;
		[Export ("scrollToItemBoundary", ArgumentSemantic.UnsafeUnretained)]
		bool ScrollToItemBoundary { get; set; }

		// @property (assign, nonatomic) BOOL ignorePerpendicularSwipes;
		[Export ("ignorePerpendicularSwipes", ArgumentSemantic.UnsafeUnretained)]
		bool IgnorePerpendicularSwipes { get; set; }

		// @property (assign, nonatomic) BOOL centerItemWhenSelected;
		[Export ("centerItemWhenSelected", ArgumentSemantic.UnsafeUnretained)]
		bool CenterItemWhenSelected { get; set; }

		// @property (readonly, nonatomic, getter = isDragging) BOOL dragging;
		[Export ("dragging")]
		bool Dragging { [Bind ("isDragging")] get; }

		// @property (readonly, nonatomic, getter = isDecelerating) BOOL decelerating;
		[Export ("decelerating")]
		bool Decelerating { [Bind ("isDecelerating")] get; }

		// @property (readonly, nonatomic, getter = isScrolling) BOOL scrolling;
		[Export ("scrolling")]
		bool Scrolling { [Bind ("isScrolling")] get; }

		// -(void)scrollByOffset:(CGFloat)offset duration:(NSTimeInterval)duration;
		[Export ("scrollByOffset:duration:")]
		void ScrollByOffset (nfloat offset, double duration);

		// -(void)scrollToOffset:(CGFloat)offset duration:(NSTimeInterval)duration;
		[Export ("scrollToOffset:duration:")]
		void ScrollToOffset (nfloat offset, double duration);

		// -(void)scrollByNumberOfItems:(NSInteger)itemCount duration:(NSTimeInterval)duration;
		[Export ("scrollByNumberOfItems:duration:")]
		void ScrollByNumberOfItems (nint itemCount, double duration);

		// -(void)scrollToItemAtIndex:(NSInteger)index duration:(NSTimeInterval)duration;
		[Export ("scrollToItemAtIndex:duration:")]
		void ScrollToItemAtIndex (nint index, double duration);

		// -(void)scrollToItemAtIndex:(NSInteger)index animated:(BOOL)animated;
		[Export ("scrollToItemAtIndex:animated:")]
		void ScrollToItemAtIndex (nint index, bool animated);

		// -(UIView *)itemViewAtIndex:(NSInteger)index;
		[Export ("itemViewAtIndex:")]
		UIView ItemViewAtIndex (nint index);

		// -(NSInteger)indexOfItemView:(UIView *)view;
		[Export ("indexOfItemView:")]
		nint IndexOfItemView (UIView view);

		// -(NSInteger)indexOfItemViewOrSubview:(UIView *)view;
		[Export ("indexOfItemViewOrSubview:")]
		nint IndexOfItemViewOrSubview (UIView view);

		// -(CGFloat)offsetForItemAtIndex:(NSInteger)index;
		[Export ("offsetForItemAtIndex:")]
		nfloat OffsetForItemAtIndex (nint index);

		// -(UIView *)itemViewAtPoint:(CGPoint)point;
		[Export ("itemViewAtPoint:")]
		UIView ItemViewAtPoint (CGPoint point);

		// -(void)removeItemAtIndex:(NSInteger)index animated:(BOOL)animated;
		[Export ("removeItemAtIndex:animated:")]
		void RemoveItemAtIndex (nint index, bool animated);

		// -(void)insertItemAtIndex:(NSInteger)index animated:(BOOL)animated;
		[Export ("insertItemAtIndex:animated:")]
		void InsertItemAtIndex (nint index, bool animated);

		// -(void)reloadItemAtIndex:(NSInteger)index animated:(BOOL)animated;
		[Export ("reloadItemAtIndex:animated:")]
		void ReloadItemAtIndex (nint index, bool animated);

		// -(void)reloadData;
		[Export ("reloadData")]
		void ReloadData ();
	}

	// @protocol iCarouselDataSource <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface iCarouselDataSource {
		// @required -(NSInteger)numberOfItemsInCarousel:(iCarousel *)carousel;
		[Export ("numberOfItemsInCarousel:")]
		[Abstract]
		nint NumberOfItemsInCarousel (iCarousel carousel);

		// @required -(UIView *)carousel:(iCarousel *)carousel viewForItemAtIndex:(NSInteger)index reusingView:(UIView *)view;
		[Export ("carousel:viewForItemAtIndex:reusingView:")]
		[Abstract]
		UIView ViewForItemAtIndex (iCarousel carousel, nint index, UIView view);

		// @optional -(NSInteger)numberOfPlaceholdersInCarousel:(iCarousel *)carousel;
		[Export ("numberOfPlaceholdersInCarousel:")]
		nint NumberOfPlaceholdersInCarousel (iCarousel carousel);

		// @optional -(UIView *)carousel:(iCarousel *)carousel placeholderViewAtIndex:(NSInteger)index reusingView:(UIView *)view;
		[Export ("carousel:placeholderViewAtIndex:reusingView:")]
		UIView PlaceholderViewAtIndex (iCarousel carousel, nint index, UIView view);
	}

	// @protocol iCarouselDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface iCarouselDelegate {

		// @optional -(void)carouselWillBeginScrollingAnimation:(iCarousel *)carousel;
		[Export ("carouselWillBeginScrollingAnimation:")]
		void CarouselWillBeginScrollingAnimation (iCarousel carousel);

		// @optional -(void)carouselDidEndScrollingAnimation:(iCarousel *)carousel;
		[Export ("carouselDidEndScrollingAnimation:")]
		void CarouselDidEndScrollingAnimation (iCarousel carousel);

		// @optional -(void)carouselDidScroll:(iCarousel *)carousel;
		[Export ("carouselDidScroll:")]
		void CarouselDidScroll (iCarousel carousel);

		// @optional -(void)carouselCurrentItemIndexDidChange:(iCarousel *)carousel;
		[Export ("carouselCurrentItemIndexDidChange:")]
		void CarouselCurrentItemIndexDidChange (iCarousel carousel);

		// @optional -(void)carouselWillBeginDragging:(iCarousel *)carousel;
		[Export ("carouselWillBeginDragging:")]
		void CarouselWillBeginDragging (iCarousel carousel);

		// @optional -(void)carouselDidEndDragging:(iCarousel *)carousel willDecelerate:(BOOL)decelerate;
		[Export ("carouselDidEndDragging:willDecelerate:")]
		void WillDecelerate (iCarousel carousel, bool decelerate);

		// @optional -(void)carouselWillBeginDecelerating:(iCarousel *)carousel;
		[Export ("carouselWillBeginDecelerating:")]
		void CarouselWillBeginDecelerating (iCarousel carousel);

		// @optional -(void)carouselDidEndDecelerating:(iCarousel *)carousel;
		[Export ("carouselDidEndDecelerating:")]
		void CarouselDidEndDecelerating (iCarousel carousel);

		// @optional -(BOOL)carousel:(iCarousel *)carousel shouldSelectItemAtIndex:(NSInteger)index;
		[Export ("carousel:shouldSelectItemAtIndex:")]
		bool ShouldSelectItemAtIndex (iCarousel carousel, nint index);

		// @optional -(void)carousel:(iCarousel *)carousel didSelectItemAtIndex:(NSInteger)index;
		[Export ("carousel:didSelectItemAtIndex:")]
		void DidSelectItemAtIndex (iCarousel carousel, nint index);

		// @optional -(CGFloat)carouselItemWidth:(iCarousel *)carousel;
		[Export ("carouselItemWidth:")]
		nfloat CarouselItemWidth (iCarousel carousel);

		// @optional -(CATransform3D)carousel:(iCarousel *)carousel itemTransformForOffset:(CGFloat)offset baseTransform:(CATransform3D)transform;
		[Export ("carousel:itemTransformForOffset:baseTransform:")]
		CATransform3D ItemTransformForOffset (iCarousel carousel, nfloat offset, CATransform3D transform);

		// @optional -(CGFloat)carousel:(iCarousel *)carousel valueForOption:(iCarouselOption)option withDefault:(CGFloat)value;
		[Export ("carousel:valueForOption:withDefault:")]
		nfloat ValueForOption (iCarousel carousel, iCarouselOption option, nfloat value);
	}

}

