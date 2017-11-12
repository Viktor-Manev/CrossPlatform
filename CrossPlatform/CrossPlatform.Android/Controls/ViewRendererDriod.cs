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
using Rox;

[assembly: Xamarin.Forms.ExportRenderer(typeof(CrossPlatform.VideoVideCustom), typeof(CrossPlatform.Droid.Controls.ViewRendererDriod))]
namespace CrossPlatform.Droid.Controls
{

   public class MyView : SurfaceView
    {
        public MyView(Context context) : base(context)
        {
        }
    }


    public  class ViewRendererDriod : ViewRenderer<VideoVideCustom, Android.Views.SurfaceView>, ISurfaceHolderCallback2
    {
        MediaPlayer mp;
        MediaController mc;

        public void SurfaceChanged(ISurfaceHolder holder, [GeneratedEnum] Format format, int width, int height)
        {
            //throw new NotImplementedException();
        }

        public void SurfaceCreated(ISurfaceHolder holder)
        {
            
            mp.SetDisplay(holder);
            Play();

        }

        private void Play()
        {

              AssetFileDescriptor fd = Android.App.Application.Context.Assets.OpenFd("video.mp4");
              mp.SetDataSource(fd.FileDescriptor, fd.StartOffset, fd.Length);
            mp.Prepare();
            mp.Prepared += ((s,e) => 
            {
            
                mp.Start();
                mc.Show();
            });
        }

        public void SurfaceDestroyed(ISurfaceHolder holder)
        {
        //    throw new NotImplementedException();
        }

        public void SurfaceRedrawNeeded(ISurfaceHolder holder)
        {
          //  throw new NotImplementedException();
        }



        MyView videoView;
        protected override void OnElementChanged(ElementChangedEventArgs<VideoVideCustom> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                videoView = new MyView(Android.App.Application.Context);
                videoView.Holder.AddCallback(this);
                mp = new MediaPlayer();
                mc = new MediaController(Context);
                mc.SetAnchorView(videoView);
                

                SetNativeControl(mc.RootView);
            }

            if (e.NewElement != null)
            {
                
                //mp.SetDisplay(vide)
            }

        }

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

        //  mediaPlayer.SetDisplay(v.Holder);




    }
}