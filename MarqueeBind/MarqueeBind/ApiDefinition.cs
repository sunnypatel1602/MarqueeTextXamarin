using System;
using System.Drawing;

using ObjCRuntime;
using Foundation;
using UIKit;
using CoreGraphics;

namespace MarqueeBind
{// @interface MarqueeLabel : UILabel
	[BaseType (typeof (UILabel))]
	interface MarqueeLabel {

		// -(instancetype)initWithFrame:(CGRect)frame;
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect frame);

		// -(instancetype)initWithFrame:(CGRect)frame rate:(CGFloat)pixelsPerSec andFadeLength:(CGFloat)fadeLength;
		[Export ("initWithFrame:rate:andFadeLength:")]
		IntPtr Constructor (CGRect frame, nfloat pixelsPerSec, nfloat fadeLength);

		// -(instancetype)initWithFrame:(CGRect)frame duration:(NSTimeInterval)scrollDuration andFadeLength:(CGFloat)fadeLength;
		[Export ("initWithFrame:duration:andFadeLength:")]
		IntPtr Constructor (CGRect frame, double scrollDuration, nfloat fadeLength);

		// @property (assign, nonatomic) UIViewAnimationOptions animationCurve;
		[Export ("animationCurve", ArgumentSemantic.UnsafeUnretained)]
		UIViewAnimationOptions AnimationCurve { get; set; }

		// @property (assign, nonatomic) BOOL labelize;
		[Export ("labelize", ArgumentSemantic.UnsafeUnretained)]
		bool Labelize { get; set; }

		// @property (assign, nonatomic) BOOL holdScrolling;
		[Export ("holdScrolling", ArgumentSemantic.UnsafeUnretained)]
		bool HoldScrolling { get; set; }

		// @property (assign, nonatomic) BOOL tapToScroll;
		[Export ("tapToScroll", ArgumentSemantic.UnsafeUnretained)]
		bool TapToScroll { get; set; }

		// @property (assign, nonatomic) MarqueeType marqueeType;
		[Export ("marqueeType", ArgumentSemantic.UnsafeUnretained)]
		MarqueeType MarqueeType { get; set; }

		// @property (assign, nonatomic) CGFloat scrollDuration;
		[Export ("scrollDuration", ArgumentSemantic.UnsafeUnretained)]
		nfloat ScrollDuration { get; set; }

		// @property (assign, nonatomic) CGFloat rate;
		[Export ("rate", ArgumentSemantic.UnsafeUnretained)]
		nfloat Rate { get; set; }

		// @property (assign, nonatomic) CGFloat leadingBuffer;
		[Export ("leadingBuffer", ArgumentSemantic.UnsafeUnretained)]
		nfloat LeadingBuffer { get; set; }

		// @property (assign, nonatomic) CGFloat trailingBuffer;
		[Export ("trailingBuffer", ArgumentSemantic.UnsafeUnretained)]
		nfloat TrailingBuffer { get; set; }



		// @property (assign, nonatomic) CGFloat fadeLength;
		[Export ("fadeLength", ArgumentSemantic.UnsafeUnretained)]
		nfloat FadeLength { get; set; }

		// @property (assign, nonatomic) CGFloat animationDelay;
		[Export ("animationDelay", ArgumentSemantic.UnsafeUnretained)]
		nfloat AnimationDelay { get; set; }

		// @property (readonly, assign, nonatomic) BOOL isPaused;
		[Export ("isPaused", ArgumentSemantic.UnsafeUnretained)]
		bool IsPaused { get; }

		// @property (readonly, assign, nonatomic) BOOL awayFromHome;
		[Export ("awayFromHome", ArgumentSemantic.UnsafeUnretained)]
		bool AwayFromHome { get; }

		// -(void)minimizeLabelFrameWithMaximumSize:(CGSize)maxSize adjustHeight:(BOOL)adjustHeight;
		[Export ("minimizeLabelFrameWithMaximumSize:adjustHeight:")]
		void MinimizeLabelFrameWithMaximumSize (CGSize maxSize, bool adjustHeight);

		// -(void)restartLabel;
		[Export ("restartLabel")]
		void RestartLabel ();

		// -(void)resetLabel;
		[Export ("resetLabel")]
		void ResetLabel ();

		// -(void)pauseLabel;
		[Export ("pauseLabel")]
		void PauseLabel ();

		// -(void)unpauseLabel;
		[Export ("unpauseLabel")]
		void UnpauseLabel ();

		// -(void)triggerScrollStart;
		[Export ("triggerScrollStart")]
		void TriggerScrollStart ();

		// -(void)labelWillBeginScroll;
		[Export ("labelWillBeginScroll")]
		void LabelWillBeginScroll ();

		// -(void)labelReturnedToHome:(BOOL)finished;
		[Export ("labelReturnedToHome:")]
		void LabelReturnedToHome (bool finished);

		// +(void)restartLabelsOfController:(UIViewController *)controller;
		[Static, Export ("restartLabelsOfController:")]
		void RestartLabelsOfController (UIViewController controller);

		// +(void)controllerViewDidAppear:(UIViewController *)controller;
		[Static, Export ("controllerViewDidAppear:")]
		void ControllerViewDidAppear (UIViewController controller);

		// +(void)controllerViewWillAppear:(UIViewController *)controller;
		[Static, Export ("controllerViewWillAppear:")]
		void ControllerViewWillAppear (UIViewController controller);



		// +(void)controllerLabelsShouldLabelize:(UIViewController *)controller;
		[Static, Export ("controllerLabelsShouldLabelize:")]
		void ControllerLabelsShouldLabelize (UIViewController controller);

		// +(void)controllerLabelsShouldAnimate:(UIViewController *)controller;
		[Static, Export ("controllerLabelsShouldAnimate:")]
		void ControllerLabelsShouldAnimate (UIViewController controller);
	}

	// @interface MarqueeLabelDemoAppDelegate : NSObject <UIApplicationDelegate>
	[BaseType (typeof (NSObject))]
	interface MarqueeLabelDemoAppDelegate
	{

		// @property (nonatomic, strong) UIWindow * window;
		[Export ("window", ArgumentSemantic.Retain)]
		UIWindow Window { get; set; }

		// @property (nonatomic, strong) MarqueeLabelDemoViewController * viewController;
		[Export ("viewController", ArgumentSemantic.Retain)]
		MarqueeLabelDemoViewController ViewController { get; set; }
	}

	// @interface MarqueeLabelDemoViewController : UIViewController
	[BaseType (typeof (UIViewController))]
	interface MarqueeLabelDemoViewController {

		// @property (nonatomic, weak) MarqueeLabel * demoLabel1;
		[Export ("demoLabel1", ArgumentSemantic.Weak)]
		MarqueeLabel DemoLabel1 { get; set; }

		// @property (nonatomic, weak) MarqueeLabel * demoLabel2;
		[Export ("demoLabel2", ArgumentSemantic.Weak)]
		MarqueeLabel DemoLabel2 { get; set; }

		// @property (nonatomic, weak) MarqueeLabel * demoLabel3;
		[Export ("demoLabel3", ArgumentSemantic.Weak)]
		MarqueeLabel DemoLabel3 { get; set; }

		// @property (nonatomic, weak) MarqueeLabel * demoLabel4;
		[Export ("demoLabel4", ArgumentSemantic.Weak)]
		MarqueeLabel DemoLabel4 { get; set; }

		// @property (nonatomic, weak) MarqueeLabel * demoLabel5;
		[Export ("demoLabel5", ArgumentSemantic.Weak)]
		MarqueeLabel DemoLabel5 { get; set; }

		// @property (nonatomic, weak) UISwitch * labelizeSwitch;
		[Export ("labelizeSwitch", ArgumentSemantic.Weak)]
		UISwitch LabelizeSwitch { get; set; }

		// @property (nonatomic, weak) UISwitch * holdLabelsSwitch;
		[Export ("holdLabelsSwitch", ArgumentSemantic.Weak)]
		UISwitch HoldLabelsSwitch { get; set; }

		// -(void)changeLabelTexts:(id)sender;
		[Export ("changeLabelTexts:")]
		void ChangeLabelTexts (NSObject sender);

		// -(void)labelizeSwitched:(id)sender;
		[Export ("labelizeSwitched:")]
		void LabelizeSwitched (NSObject sender);

		// -(void)holdLabelsSwitched:(id)sender;
		[Export ("holdLabelsSwitched:")]
		void HoldLabelsSwitched (NSObject sender);

		// -(void)togglePause:(id)sender;
		[Export ("togglePause:")]
		void TogglePause (NSObject sender);

		// -(void)unwindModalPopoverSegue:(UIStoryboardSegue *)segue;
		[Export ("unwindModalPopoverSegue:")]
		void UnwindModalPopoverSegue (UIStoryboardSegue segue);
	}

	// @interface ModalViewController : UIViewController
	[BaseType (typeof (UIViewController))]
	interface ModalViewController {

	}
}

