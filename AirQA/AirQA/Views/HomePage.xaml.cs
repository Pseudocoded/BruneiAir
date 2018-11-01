using Plugin.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AirQA.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : TabbedPage
	{
		public HomePage ()
		{
			InitializeComponent ();

		   
		}

		public void BnRight_Clicked(object sender, EventArgs e)
		{
			tabPage.CurrentPage = tutong;
		}

		public void TutRight_Clicked(object sender, EventArgs e)
		{
			tabPage.CurrentPage = temburong;
		}

		public void TemRight_Clicked(object sender, EventArgs e)
		{
			tabPage.CurrentPage = belait;
		}

		public void TutLeft_Clicked(object sender, EventArgs e)
		{
			tabPage.CurrentPage = brunei;
		}

		public void TemLeft_Clicked(object sender, EventArgs e)
		{
			tabPage.CurrentPage = tutong;
		}

		public void BelLeft_Clicked(object sender, EventArgs e)
		{
			tabPage.CurrentPage = temburong;
		}
		private void Share_Clicked(object sender, EventArgs e)
		{
			//CrossShare.Current.Share("Information to send", "Share");
			CrossShare.Current.ShareLink("Information to share", "Share");

		}

	}
}