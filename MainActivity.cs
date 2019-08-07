using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Project_1__0ne_
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            var Dc = FindViewById<Button>(Resource.Id.btndc);
            Dc.Click += (s, e) =>
            {
                var Dgtc = new Intent(this, typeof(Dgtc));
                StartActivity(Dgtc);
            };
            var Ac = FindViewById<Button>(Resource.Id.btnACK);
            Ac.Click += (s, e) =>
            {
                var Actc = new Intent(this, typeof(Analog));
                StartActivity(Actc);
            };
            var Timer = FindViewById<Button>(Resource.Id.btntr);
            Timer.Click += (s, e) =>
            {
                var Timerintent = new Intent(this, typeof(Timer));
                StartActivity(Timerintent);
            };
            var Timertask = FindViewById<Button>(Resource.Id.btntt);
            Timertask.Click += (s, e) =>
            {
                var TimerTaskintent = new Intent(this, typeof(TimerTask));
                StartActivity(TimerTaskintent);
            };
 
            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
	}
}

