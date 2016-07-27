# MarqueeTextXamarin

Clone for Xamarin.iOS : https://github.com/facebook/Shimmer

## Example

	FBShimmeringView shimmeringView = new FBShimmeringView() 
	{ 
		Frame = new CoreGraphics.CGRect(0, 100, UIScreen.MainScreen.Bounds.Width, 200),
		BackgroundColor = UIColor.Blue
	};
	View.Add(shimmeringView);

	UILabel lbl = new UILabel() {
		Frame = new CoreGraphics.CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, 200),
		Text = "Shimmering Text",
		Font = UIFont.BoldSystemFontOfSize(40),
		TextColor = UIColor.White,
		TextAlignment = UITextAlignment.Center
	};
	shimmeringView.ContentView = lbl;
	shimmeringView.Shimmering = true;


## License

Copyright (c) 2016 Sunny Patel

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
