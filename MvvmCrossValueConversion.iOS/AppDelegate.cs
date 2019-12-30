﻿using Foundation;
using MvvmCross.Platforms.Ios.Core;
using UIKit;

namespace MvvmCrossValueConversion.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate<MvxIosSetup<Core.App>, Core.App>
    {
    }
}


