using System;
using Xamarin.Forms;

namespace Landscape
{
	public class MyContentPage : ContentPage
	{
		public MyContentPage()
		{
			this.BackgroundColor = Color.Blue;
			this.Title = "Landscape";
			this.Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label {
						HorizontalTextAlignment = TextAlignment.Center,
						Text = "Welcome to Xamarin Forms!"
					}
				}
			};
		}

		protected override void OnSizeAllocated(double _width, double _height)
		{
			// If the screen size has (actually) changed then modify the content page size
			// Only necessary for iOS
			if (Device.OS == TargetPlatform.iOS && Device.Idiom == TargetIdiom.Phone
			   && (this.Content.Width != _width || this.Content.Height != _height))
			{
				// If the device is a Phone, then proper sizing is needed
				if (Device.Idiom == TargetIdiom.Phone)
				{
					// If Landscape orientation
					if (_width > _height)
					{
						Padding = new Thickness(0, 0, 0, 0);
					}
					else {
						Padding = new Thickness(0, 20, 0, 0);
					}
				}
			}
			base.OnSizeAllocated(_width, _height);
		}

	}
}