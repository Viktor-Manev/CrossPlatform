using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace CrossPlatform
{

  
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // videoview.SetStartAction(OnAppearing);
            imageID.Source = ImageSource.FromResource("CrossPlatform.Melon_Logo.gif");
            imageID.Scale = 0.3;
            //videoview.Source = ImageSource.FromFile("CrossPlatform.LoginVideo.mp4");

           // string src = DependencyService.Get<IVideoSource>().GetUri();
          

        }


        protected async override void OnAppearing()
        {
            base.OnAppearing();
        }

        async Task StartVide()
        {
            System.Diagnostics.Debug.WriteLine("Initiated");
        

          
            return ;
        }

    }

    
}
