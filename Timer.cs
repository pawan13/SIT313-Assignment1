using System;
using System.Timers;
using Android.App;
using Android.OS;
using Android.Widget;

namespace Project_1__0ne_
{
    [Activity(Label = "Timer")]
    public class Timer : Activity
    {
        System.Timers.Timer timer;
        TextView txtCounter;
        CheckBox singleshot;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Timer);
           txtCounter = FindViewById<TextView>(Resource.Id.counter);
            var start = FindViewById<Button>(Resource.Id.btnstart);
            var cancel = FindViewById<Button>(Resource.Id.btncancel);
            singleshot = FindViewById<CheckBox>(Resource.Id.checkBox1);

            start.Click += delegate
            {
                timer = new System.Timers.Timer();
                if (singleshot.Checked == true)
                {
                    timer.Interval = 1000;
                    timer.Enabled = true;
                    timer.Elapsed += Timer_Eplased;
                    timer.Start();
                    Cancel();
                }
                else
                {
                    timer.Interval = 1000;
                    timer.Enabled = true;
                    timer.Elapsed += Timer_Eplased;
                    timer.Start();

                }

            };

            cancel.Click += delegate
            {
                Cancel();
            };
        }

      

        private void Cancel()
        {
           timer.Dispose();
            timer = null;
        }
        private void Timer_Eplased(object sender, ElapsedEventArgs e)
        {
            DateTime dt = DateTime.Now;
            RunOnUiThread(() =>
            {
                txtCounter.Text = dt.ToString();
            });
        }
    }
}