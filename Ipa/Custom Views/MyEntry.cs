using System;

using Xamarin.Forms;

namespace Ipa
{
	public class MyEntry : Entry
	{
		public static readonly BindableProperty BorderColorProperty = 
			BindableProperty.Create<MyEntry, Color> (p => p.BorderColor, Color.White);

		public Color BorderColor {
			get { return (Color)GetValue (BorderColorProperty); }
			set { SetValue (BorderColorProperty, value); }
		}
	}
}


