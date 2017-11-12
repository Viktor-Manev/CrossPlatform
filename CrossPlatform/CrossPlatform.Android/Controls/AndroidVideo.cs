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
using Xamarin.Forms.Platform.Android;
using Android.Media;
using Android.Content.Res;


[assembly: Xamarin.Forms.ExportRenderer(typeof(CrossPlatform.VideoViewNative), typeof(CrossPlatform.Droid.Controls.AndroidVideo))]
namespace CrossPlatform.Droid.Controls
{
    class AndroidVideo : ViewRenderer<CrossPlatform.VideoViewNative, VideoView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<VideoViewNative> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                var view = new VideoView(Context);
                view.SetOnPreparedListener(new Listener(view));
                view.Prepared += View_Prepared;

                // view.SetOnPreparedListener(null);
                view.AddOnLayoutChangeListener(new Listener(view));
                view.SetOnCompletionListener(new Listener(view));

                SetNativeControl(view);
            }

        }

        private void View_Prepared(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        class Listener : Java.Lang.Object, MediaPlayer.IOnPreparedListener, IOnLayoutChangeListener, MediaPlayer.IOnCompletionListener
        {
            MediaPlayer mp;
            VideoView view;
            int playing = 0;

            public Listener(VideoView view)
            {
                this.view = view;
            }

            public void OnCompletion(MediaPlayer mp)
            {
               
            }

            public void OnLayoutChange(View v, int left, int top, int right, int bottom, int oldLeft, int oldTop, int oldRight, int oldBottom)
            {
                playing++;
            }

            public void OnPrepared(MediaPlayer mp)
            {
                this.mp = mp;
                AssetFileDescriptor fd = Android.App.Application.Context.Assets.OpenFd("video.mp4");
                mp.SetDataSource(fd.FileDescriptor, fd.StartOffset, fd.Length);
                mp.Prepare();
                mp.Prepared += Mp_Prepared;
                
            }

            private void Mp_Prepared(object sender, EventArgs e)
            {
                mp.Start();
            }
        }

        
    }
}