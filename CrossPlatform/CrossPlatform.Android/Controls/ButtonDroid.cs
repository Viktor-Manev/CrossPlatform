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

[assembly: Xamarin.Forms.ExportRenderer(typeof(CrossPlatform.ButtonRed), typeof(CrossPlatform.Droid.Controls.ButtonDroid))]
namespace CrossPlatform.Droid.Controls
{

    class ButtonDroid : Xamarin.Forms.Platform.Android.ButtonRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.Red);
            }
        }


    }
}