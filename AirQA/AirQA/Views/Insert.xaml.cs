using AirQA.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AirQA.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Insert : ContentPage
	{


		public Insert ()
		{
			InitializeComponent ();
		}

		public class Post
		{
			public int ID { get; set; }
			public string LastUpdate { get; set; }
			public string District { get; set; }
			public string Value { get; set; }

		}

		private async Task Button_Clicked(object sender, EventArgs e)
		{
			var RestUrl = "http://202.160.1.102:8084/api/AQ/1";
			var uri = new Uri(string.Format(RestUrl, string.Empty));
			var post = new Post { District = "Brunei-Muara", LastUpdate = DateTime.Now.ToString(), Value = valueEntry.Text };
			var json = JsonConvert.SerializeObject(post);
			var content = new StringContent(json, Encoding.UTF8, "application/json");

			var RestUrl2 = "http://202.160.1.102:8084/api/AQ/2";
			var uri2 = new Uri(string.Format(RestUrl2, string.Empty));
			var post2 = new Post { District = "Belait", LastUpdate = DateTime.Now.ToString(), Value = valueEntry4.Text };
			var json2 = JsonConvert.SerializeObject(post2);
			var content2 = new StringContent(json2, Encoding.UTF8, "application/json");

			var RestUrl3 = "http://202.160.1.102:8084/api/AQ/3";
			var uri3 = new Uri(string.Format(RestUrl3, string.Empty));
			var post3 = new Post { District = "Temburong", LastUpdate = DateTime.Now.ToString(), Value = valueEntry3.Text };
			var json3 = JsonConvert.SerializeObject(post3);
			var content3 = new StringContent(json3, Encoding.UTF8, "application/json");

			var RestUrl4 = "http://202.160.1.102:8084/api/AQ/4";
			var uri4 = new Uri(string.Format(RestUrl4, string.Empty));
			var post4 = new Post { District = "Tutong", LastUpdate = DateTime.Now.ToString(), Value = valueEntry2.Text };
			var json4 = JsonConvert.SerializeObject(post4);
			var content4 = new StringContent(json4, Encoding.UTF8, "application/json");

			HttpClient client = new HttpClient();

			HttpResponseMessage response = await client.PutAsync(uri, content);
			HttpResponseMessage response2 = await client.PutAsync(uri2, content2);
			HttpResponseMessage response3 = await client.PutAsync(uri3, content3);
			HttpResponseMessage response4 = await client.PutAsync(uri4, content4);

			if (response.IsSuccessStatusCode || response2.IsSuccessStatusCode || response3.IsSuccessStatusCode|| response4.IsSuccessStatusCode)
			{
				await DisplayAlert("Notify", "Value update successful", "Ok");
			}
			else
			{
				await DisplayAlert("Notify", "Error, Please try again.", "Ok");
			}

		   

		}
	}
}