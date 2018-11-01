using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AirQA.Models;
using AirQA.Views;
using AirQA;
using System.Runtime.Serialization;

namespace AirQA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Link : ContentPage
    {
        public Link()
        {
            InitializeComponent();
 

            List<Links> list = new List<Links>
        {
            new Links("https://www.gov.bn","eDarussalam",TappedCallback ),
            new Links("http://www.bruneiweather.com.bn/","Brunei Weather",TappedCallback )

        };
            linkList.ItemsSource = list;
        }
        

        private void TappedCallback(View sender, object param)
        {
            var Partner = param as Links;

            Device.OpenUri(new Uri(Partner.UrlPage));
            
        }

        private void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }

    }
}