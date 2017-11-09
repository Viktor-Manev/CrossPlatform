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
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Content.Res;
using System.IO;
using Android.Media;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;

[assembly: Xamarin.Forms.ExportRenderer(typeof(CrossPlatform.VideoVideCustom), typeof(CrossPlatform.Droid.VideoSourceDroid))]
namespace CrossPlatform.Droid.Controls
{

    public class MyView : Android.Views.View
    {
        public MyView() : base(Android.App.Application.Context)
        {

        }
    }
  
  public  class ViewRendererDriod : ViewRenderer<VideoVideCustom, MyView>
    {
     

      
            //if (Control == null)
            //{
            //    Android.Views.View v = new Android.Views.View(Android.App.Application.Context);
            //    v.SetBackgroundColor(Android.Graphics.Color.Red);
            //    SetNativeControl(v);
            //}
            
            // MediaPlayer mediaPlayer = new MediaPlayer();
            //LayoutInflater mInflater = (LayoutInflater)Android.Content.Context.LayoutInflaterService;
            //mInflater.Inflate()

            //    var v = new SurfaceView(Android.App.Application.Context);
            // var asset = Android.App.Application.Context.Assets;

            //  AssetManager assets = asset;
            //  string content;

            //  AssetFileDescriptor fd = asset.OpenFd("video");



            // mediaPlayer.SetDataSource(fd.FileDescriptor, fd.StartOffset, fd.Length);
            //  mediaPlayer.SetDisplay(v.Holder);


        

    }
}