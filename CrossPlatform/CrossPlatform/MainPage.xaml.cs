using System;
using System.Collections.Generic;
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
            videoview.FullScreen = true;
           // videoview.SetStartAction(OnAppearing);

        }



        protected async override void OnAppearing()
        {
            base.OnAppearing();
            
        }

    }

    
}
