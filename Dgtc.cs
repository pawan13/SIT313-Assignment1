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
using Android.Support.V7.App;
using Android.Support.Design.Widget;

namespace Project_1__0ne_
{
    [Activity(Label = "Dgtc")]
    public class Dgtc : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Dgtc);


         var show = FindViewById<Button>(Resource.Id.btnshow);
            var digital = FindViewById<DigitalClock>(Resource.Id.digitalclock);
            show.Click += (s, e) =>
            {
                if(digital.Visibility == ViewStates.Visible)
                {
                    digital.Visibility = ViewStates.Invisible;
                    show.Text = "Show";
                }
                else
                {
                    digital.Visibility = ViewStates.Visible;
                    show.Text = "Hide";
                }
            };
        }
    }
}