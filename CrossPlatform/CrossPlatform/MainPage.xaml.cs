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


            Task.Run(async () =>  
            {
                  string filename =   await  NetUriLoad.Get("", fileSystem);

                Device.BeginInvokeOnMainThread(()=> {

                    videoview.Source = ImageSource.FromFile(filename);
                      videoview.Start();
                }
                    );
            });
          

            //IVideoSource src = DependencyService.Get<IVideoSource>();

            //videoview.Source = ImageSource.FromFile(src.GetUri());

            

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

    public static class NetUriLoad
    {

        static string filename = "videoDown.mp4";
        public static async Task<string> Get(string uri, IFileSystemCommands fileMan)
        {
            string results = "N/A";
            if (fileMan.FileExists(filename))
            {
                fileMan.GetFilePath(filename);
            }

            try
            {
                System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();

                var p = await httpClient.GetStreamAsync("http://www.sample-videos.com/video/mp4/720/big_buck_bunny_720p_1mb.mp4");


                fileMan.SaveStream(filename, p);

                return fileMan.GetFilePath(filename);
            }
            catch { return "qw"; }
        }
    }

}
