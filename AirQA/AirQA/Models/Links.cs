using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using System.Text;

namespace AirQA.Models
{
    public class Links
    {
        public string UrlPage { get; set; }
        public string Title { get; set; }
        
        public Action<View, object> CallBack { get; set; }

        public Links(string urlPage, string title)
        {
            this.UrlPage = urlPage;
            this.Title = title;
        }

        public Links(string urlPage, string title, Action<View, object> callback) : this(urlPage, title)
        {
            this.CallBack = callback;
        }
    }
}
