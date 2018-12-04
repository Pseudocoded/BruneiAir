using AirQA.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AirQA
{
    public partial class App : Application
    {
       public static bool IsUserLoggedIn { get; set; }
      

        public App()
        {
            //InitializeComponent();
            //MainPage = new MenuMasterPage();
            if (!IsUserLoggedIn)
            {
                MainPage = new MenuMasterPage();
            }
            else
            {
                MainPage = new NavigationPage(new Insert());
            }
            
        }

        protected override void OnStart()
        {
            // Handle when your app starts

            if (!IsUserLoggedIn)
            {
                MainPage = new MenuMasterPage();
            }
            else
            {
                MainPage = new NavigationPage(new Insert());
            }
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
