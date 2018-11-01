using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AirQA.Models
{
   public class Menu
    {
        public string MenuTitle { get; set; }
        public string ImageUrl { get; set; }
        public string MenuDetail { get; set; }
        public Page Page { get; set; }
    }
}
