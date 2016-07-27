using System;
using ObjCRuntime;

namespace MarqueeBind
{
	[Native]
	public enum MarqueeType : ulong /* nuint */ {
		MLLeftRight = 0,
		MLRightLeft,
		MLContinuous,
		MLContinuousReverse
	}
}

