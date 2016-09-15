using System;

using Xamarin.Forms;

namespace Landscape
{
	public class App : Application
	{
		public App()
		{
			var content = new MyContentPage();

			var page = new NavigationPage(content);
			page.BarTextColor = Color.Aqua;

			MainPage = page;
			MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, Color.Lime);
			MainPage.SetValue(NavigationPage.BarTextColorProperty, Color.Red);
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

