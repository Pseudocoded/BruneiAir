using System;
using AirQA.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Menu = AirQA.Models.Menu;

namespace AirQA.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuMasterPage : MasterDetailPage
	{
		public MenuMasterPage ()
		{
			InitializeComponent();
			MyMenu();
		}

		public void MyMenu()
		{
			
			Detail = new NavigationPage(new HomePage());

			List<Menu> menu = new List<Menu>
			{
				new Menu{ Page= new HomePage(),MenuTitle="Home", ImageUrl="home.png"},
				new Menu{ Page= new Legend(),MenuTitle="Legend", ImageUrl="legend.png"},
				new Menu{ Page= new Link(),MenuTitle="Links", ImageUrl="link.png"},
				new Menu{ Page= new Settings(),MenuTitle="Setting", ImageUrl="setting.png"},
				new Menu{ Page= new ContactUs(),MenuTitle="Contact Us", ImageUrl="ctcus.png"},
				
			};

			ListMenu.ItemsSource = menu;
		}

		private void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var menu = e.SelectedItem as Menu;
			if (menu != null)
			{
				IsPresented = false;
				Detail = new NavigationPage(menu.Page);
			}
			((ListView)sender).SelectedItem = null;
		}


	}
}