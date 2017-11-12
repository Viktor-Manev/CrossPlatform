using CrossPlatform.Files;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

            IFileSystemCommands fileSystem = DependencyService.Get<Files.IFileSystemCommands>();
            //videoview.Source = ImageSource.FromFile("CrossPlatform.LoginVideo.mp4");


            // var s = NetUriLoad.Get("", fileSystem);


            videoview.Source = ImageSource.FromFile(fileSystem.GetFilePath("videeoto.mp4"));

            // string src = DependencyService.Get<IVideoSource>().GetUri();

        }


        protected async override void OnAppearing()
        {
            base.OnAppearing();

            videoview.Start();
            
        }

        async Task StartVide()
        {
            System.Diagnostics.Debug.WriteLine("Initiated");

          
            return ;
        }

    }

    public static class NetUriLoad
    {


        public static async Task<string> Get(string uri, IFileSystemCommands fileMan)
        {
            string results = "N/A";

            try
            {
                System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();

                var p = await httpClient.GetStreamAsync("http://www.sample-videos.com/video/mp4/720/big_buck_bunny_720p_1mb.mp4");


                fileMan.SaveStream("videeoto.mp4", p);

                return p.ToString();
            }
            catch { return "qw"; }
        }
    }

}
