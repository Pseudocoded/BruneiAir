using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AirQA.Models;

namespace AirQA.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactUs : ContentPage
	{
		public ContactUs()
		{
			InitializeComponent();

		}

		private void fb_Tapped(object sender, EventArgs e)
		{
			//Device.OpenUri(new Uri("fb://JASTRe/Brunei/Darussalam/80905247210")); 
			//https://www.facebook.com/JASTRe-Brunei-Darussalam-80905247210/
			Device.OpenUri(new Uri("https://www.facebook.com/JASTRe-Brunei-Darussalam-80905247210/"));

		}

		private void email_Tapped(object sender, EventArgs e)
		{
			Device.OpenUri(new System.Uri("mailto:jastre.brunei@env.gov.bn"));
		}

		private void phone_Tapped(object sender, EventArgs e)
		{
			Device.OpenUri(new System.Uri("tel:<+673-2241262>"));
		}

		private void map_Tapped(object sender, EventArgs e)
		{
			Device.OpenUri(new System.Uri("http://maps.google.com/?daddr=4.888751,114.930890"));
		}

		private void ig_Tapped(object sender, EventArgs e)
		{
			Device.OpenUri(new System.Uri("https://www.instagram.com/jastre.bn/"));
		}

		private void ViewCell_Tapped(object sender, EventArgs e)
		{

		}

		//		void lblclickfunc1()
		//		{
		//			locationclick.GestureRecognizers.Add(new TapGestureRecognizer()
		//			{
		//				Command = new Command(() =>
		//				{
		//					Device.OpenUri(new System.Uri("http://maps.google.com/?daddr=4.888751,114.930890"));
		//				}
		//		)
		//			});
		//			phoneclick.GestureRecognizers.Add(new TapGestureRecognizer()
		//			{
		//				Command = new Command(() =>
		//				{
		//					Device.OpenUri(new System.Uri("tel:<+673-2241262>"));
		//				}
		//)
		//			});
		//			emailclick.GestureRecognizers.Add(new TapGestureRecognizer()
		//			{
		//				Command = new Command(() =>
		//				{
		//					Device.OpenUri(new System.Uri("mailto:jastre.brunei@env.gov.bn"));
		//				}
		//)
		//			});
		//			facebookclick.GestureRecognizers.Add(new TapGestureRecognizer()
		//			{
		//				Command = new Command(() =>
		//				{
		//					Device.OpenUri(new Uri("fb://JASTRe-Brunei-Darussalam-80905247210/80905247210"));
		//				}
		//)
		//			});
		//			instagramclick.GestureRecognizers.Add(new TapGestureRecognizer()
		//			{
		//				Command = new Command(() =>
		//				{
		//					Device.OpenUri(new System.Uri("https://www.instagram.com/jastre.bn/"));
		//				}
		//)
		//			});
		//		}
	}
}