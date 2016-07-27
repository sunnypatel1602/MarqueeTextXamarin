# MarqueeTextXamarin

Objective-C Version : https://github.com/cbpowell/MarqueeLabel/

## Example

	MarqueeLabel myLbl = new MarqueeLabel() 
	  { 
			Frame = new CoreGraphics.CGRect((UIScreen.MainScreen.Bounds.Width/2)-100,100, 200, 30),
			MarqueeType = MarqueeType.MLContinuous,
			ScrollDuration = 15f,
			AnimationCurve = UIViewAnimationOptions.CurveEaseInOut,
			FadeLength = 10f,
			LeadingBuffer = 30f,
			TrailingBuffer = 20f,
			Rate = 30f,
			TextAlignment = UITextAlignment.Center,
			Text = "Continuous Scrolling Marquee Text ...."
		};

	myLbl.TapToScroll = true;
	myLbl.UserInteractionEnabled = true;
	View.Add (myLbl);


## License

Copyright (c) 2016 Sunny Patel

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
