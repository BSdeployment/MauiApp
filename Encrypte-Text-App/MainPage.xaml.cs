using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiYouTubeDownload
{
    public partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
          
        }

        private void btn_go_enc_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EncPage());
        }

        private void btn_go_dec_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DecPage());
        }

        private void btn_about_me_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("About Me", "By Bs DotNet- DotNet Developer, You can see - " +
                "" +
                "In GitHub/YouTube/WebSite And More", "Ok");
        }
    }
}
