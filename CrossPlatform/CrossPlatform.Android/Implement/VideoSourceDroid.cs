using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Media;
using CrossPlatform.Droid;
using Android.Content.Res;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(VideoSourceDroid))]
namespace CrossPlatform.Droid
{
    class VideoSourceDroid : CrossPlatform.IVideoSource
    {

        public static string PackageNameDroid
        { get;
            set;
        }

        public static Context context
        { get; set; }

        public string GetUri()
        {

           // AssetFileDescriptor afd = getAssets().openFd(fileName);
           // player.setDataSource(afd.getFileDescriptor(), afd.getStartOffset(), afd.getLength());
          //  var uri = Android.Net.Uri.Parse(string.Format("android.resource://{0}/{1}", PackageNameDroid, Resource.Raw.video));

            var asset = Application.Context.Assets;

            AssetManager assets = asset;
            string content;
            using (StreamReader sr = new StreamReader(assets.Open("video.mp4")))
            {
                content = sr.ReadToEnd();
            }

            return content;
        }

        public string GetVideo() => string.Empty;

        public System.IO.Stream GetVideo(int a)
        {
            var asset = Application.Context.Assets;
            AssetManager assets = asset;
            return new StreamReader(assets.Open("video.mp4")).BaseStream;
        }
    }
}