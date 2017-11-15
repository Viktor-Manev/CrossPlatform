using Akavache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reactive.Linq;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace CrossPlatform
{
    public partial class App : Application
    {
        public App()
        {

            InitializeComponent();

            BlobCache.ApplicationName = "AkavacheExperiment";

            MainPage = new CrossPlatform.view.AppNavigation();
            BlobCache.UserAccount.InsertObject("username", "vmanev");

            BlobCache.UserAccount.GetOrFetchObject("username", fetchFunc: fetchObj, absoluteExpiration: DateTime.UtcNow.AddMinutes(10));
        }

        IObservable<DataClass> fetchObj()
        {
            return Observable.Return<DataClass>(new DataClass());
        }

        async Task<DataClass> GetData()
        {
            return new DataClass() { Name = "Viktor" };
        }

        protected async override void OnStart()
        {
            var stringValues = BlobCache.UserAccount.GetObject<string>("vice");

            BlobCache.UserAccount.GetObject<DataClass>("vice").Subscribe(x => Method1(x), ex => System.Diagnostics.Debug.WriteLine("No Key!"));
      
            // Handle when your app starts
        }

        public void Method1(DataClass obj)
        {
              
        }

        public class DataClass 
        {
            public string Name { get; set; }
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
