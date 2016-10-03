using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace Landscape.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new App());

			//UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.LightContent, false);
			UIApplication.SharedApplication.SetStatusBarHidden(true, UIStatusBarAnimation.None);
			UIApplication.SharedApplication.SetStatusBarHidden(false, UIStatusBarAnimation.None);

			return base.FinishedLaunching(app, options);
		}
	}
}

