using System;
using System.Collections.Generic;
using System.ComponentModel;
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

[assembly:Xamarin.Forms.ExportRenderer(typeof(CrossPlatform.MyCustomCell), typeof(CrossPlatform.Droid.Controls.NativeCellDroid))]
namespace CrossPlatform.Droid.Controls
{
    class NativeCellDroid : ViewCellRenderer
    {
        protected override Android.Views.View GetCellCore(Cell item, Android.Views.View convertView, ViewGroup parent, Context context)
        {
           
            //var p = item as CrossPlatform.abstraction.MyCustomCell;

            var view = convertView;

            if (view == null)
            {
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.ListItemLayout, parent, false);
            }

            return view;
        }
        

    }

}