using Newtonsoft.Json;
using Plugin.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static AirQA.Views.Insert;

namespace AirQA.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : TabbedPage
	{
		public List<Models.PsiData> psi;
		public Models.PsiData BruneiMuara;
		public Models.PsiData TutongData;
		public Models.PsiData TemburongData;
		public Models.PsiData BelaitData;

		public HomePage ()
		{
			InitializeComponent ();
			CallJson();
		   
		}

		private async Task CallJson()
		{
			await GetJsonData();

		}

		private async Task GetJsonData()
		{

			//
			var uri = new Uri("http://202.160.1.102:8084/api/AQ");
			HttpClient myClient = new HttpClient();

			string content = string.Empty;

			var response = await myClient.GetAsync(uri);
			if (response.IsSuccessStatusCode)
			{
				content = await response.Content.ReadAsStringAsync();
				psi = new List<Models.PsiData>();

				psi = JsonConvert.DeserializeObject<List<Models.PsiData>>(content);

				BruneiMuara = psi[0];
				TutongData = psi[3];
				TemburongData = psi[2];
				BelaitData = psi[1];

				BruneiMuara_psi.Text = BruneiMuara.Value.ToString();
				TutongData_psi.Text = TutongData.Value.ToString();
				TemburongData_psi.Text = TemburongData.Value.ToString();
				BelaitData_psi.Text = BelaitData.Value.ToString();

				Brunei_Muara_Last_Update.Text = "Updated on " + BruneiMuara.LastUpdate;
				Tutong_Last_Update.Text = "Updated on " + TutongData.LastUpdate;
				Belait_Last_Update.Text = "Updated on " + BelaitData.LastUpdate;
				Temburong_Last_Update.Text = "Updated on " + TemburongData.LastUpdate;

				//brunei level
				if (Convert.ToInt32(BruneiMuara_psi.Text) >= 0 && Convert.ToInt32(BruneiMuara_psi.Text) <= 50)
				{
					BruneiLevel.Text = "Good";
					BruneiWarn.Text = "Air is satisfactory, poses little to no risk.";
				}
				else if (Convert.ToInt32(BruneiMuara_psi.Text) >= 51 && Convert.ToInt32(BruneiMuara_psi.Text) <= 100)
				{
					BruneiLevel.Text = "Moderate";
					BruneiWarn.Text = "Air quality is acceptable, however, pollution in this range may pose a moderate health concern for certain individuals.";
				}
				else
				{
					BruneiLevel.Text = "Harmful";
					BruneiWarn.Text = "Everyone may begin to experience health effects. Members of sensitive groups may experience more serious health effects.";
				}

				//tutonglevel
				if (Convert.ToInt32(TutongData_psi.Text) >= 0 && Convert.ToInt32(TutongData_psi.Text) <= 50)
				{
					TutongLevel.Text = "Good";
					TutongWarn.Text = "Air is satisfactory, poses little to no risk";
				}
				else if (Convert.ToInt32(TutongData_psi.Text) >= 51 && Convert.ToInt32(TutongData_psi.Text) <= 100)
				{
					TutongLevel.Text = "Moderate";
					TutongWarn.Text = "Air quality is acceptable, however, pollution in this range may pose a moderate health concern for certain individuals.";
				}
				else
				{
					TutongLevel.Text = "Harmful";
					TutongWarn.Text = "Everyone may begin to experience health effects. Members of sensitive groups may experience more serious health effects.";
				}

				//temburonglevel
				if (Convert.ToInt32(TemburongData_psi.Text) >= 0 && Convert.ToInt32(TemburongData_psi.Text) <= 50)
				{
					TemburongLevel.Text = "Good";
					TemburongWarn.Text = "Air is satisfactory, poses little to no risk.";
				}
				else if (Convert.ToInt32(TemburongData_psi.Text) >= 51 && Convert.ToInt32(TemburongData_psi.Text) <= 100)
				{
					TemburongLevel.Text = "Moderate";
					TemburongWarn.Text = "Air quality is acceptable, however, pollution in this range may pose a moderate health concern for certain individuals.";
				}
				else
				{
					TemburongLevel.Text = "Harmful";
					TemburongWarn.Text = "Everyone may begin to experience health effects. Members of sensitive groups may experience more serious health effects.";
				}

				//beliatlevel
				if (Convert.ToInt32(BelaitData_psi.Text) >= 0 && Convert.ToInt32(BelaitData_psi.Text) <= 50)
				{
					BelaitLevel.Text = "Good";
					BelaitWarn.Text = "Air is satisfactory, poses little to no risk.";
				}
				else if (Convert.ToInt32(BelaitData_psi.Text) >= 51 && Convert.ToInt32(BelaitData_psi.Text) <= 100)
				{
					BelaitLevel.Text = "Moderate";
					BelaitWarn.Text = "Air quality is acceptable, however, pollution in this range may pose a moderate health concern for certain individuals.";
				}
				else
				{
					BelaitLevel.Text = "Harmful";
					BelaitWarn.Text = "Everyone may begin to experience health effects. Members of sensitive groups may experience more serious health effects.";
				}
				
			//

			}
		}

		async private void Ref_Clicked(object sender, EventArgs e)
		{
			activity.IsEnabled = true;
			activity.IsRunning = true;
			activity.IsVisible = true;

			activity2.IsEnabled = true;
			activity2.IsRunning = true;
			activity2.IsVisible = true;

			activity3.IsEnabled = true;
			activity3.IsRunning = true;
			activity3.IsVisible = true;

			activity4.IsEnabled = true;
			activity4.IsRunning = true;
			activity4.IsVisible = true;

			await Task.Delay(3000);

			await GetJsonData();

			activity.IsEnabled = false;
			activity.IsRunning = false;
			activity.IsVisible = false;

			activity2.IsEnabled = false;
			activity2.IsRunning = false;
			activity2.IsVisible = false;

			activity3.IsEnabled = false;
			activity3.IsRunning = false;
			activity3.IsVisible = false;

			activity4.IsEnabled = false;
			activity4.IsRunning = false;
			activity4.IsVisible = false;    

			 await CallJson();

			await DisplayAlert("", "Refreshed", "Ok");
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
			CrossShare.Current.ShareLink("Brunei Air Quality\nPSI Values\n\n" +"Brunei - Muara : "+ BruneiMuara.Value.ToString()+"\n"
											+ "Tutong : " + TutongData.Value.ToString()+ "\n" 
											+ "Temburong : " + TemburongData.Value.ToString() +  "\n" 
											+ "Belait : " + BelaitData.Value.ToString() +"\n\n" + "Please contact JASTRe for more information, +673-2241262", "Share");

		}

	}
}
