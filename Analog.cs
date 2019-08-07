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

namespace Project_1__0ne_
{
    [Activity(Label = "Analog")]
    public class Analog : Activity
    {
        [Obsolete]
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Analog);
            var btnshow = FindViewById<Button>(Resource.Id.btnShow1);
            var Analog = FindViewById<AnalogClock>(Resource.Id.analogClock1);
          

            btnshow.Click += (s, e) =>
            {
               
                if (Analog.Visibility == ViewStates.Visible)
                {
                    Analog.Visibility = ViewStates.Invisible;
                    btnshow.Text = "show";
                }
                else
                {
                    Analog.Visibility = ViewStates.Visible;
                    btnshow.Text = "Hide";
                }
                 
            };
            
        }
    }
}