using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using AirQA;
using Xamarin.Forms.Xaml;

namespace AirQA.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Settings : ContentPage
	{
		public Settings ()
		{
			InitializeComponent ();

			emailsup.GestureRecognizers.Add(new TapGestureRecognizer
			{
				Command = new Command(() => {
					Device.OpenUri(new Uri("mailto:airqualityappbn@gmail.com"));
				})
			});
		}

	}
}