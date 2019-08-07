using System;
using System.Timers;
using Android.App;
using Android.OS;
using Android.Widget;


namespace Project_1__0ne_
{
    [Activity(Label = "TimerTask")]
    public class TimerTask : Activity
    {
        private Button btnCancel;
        private TextView txtcountdown;
        private int count = 1;
        System.Timers.Timer timer;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.TimerTask);
            btnCancel = FindViewById<Button>(Resource.Id.btnCancel);
            txtcountdown = FindViewById<TextView>(Resource.Id.txtone);
            btnCancel.Click += BtnCancel_Click;
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            
            txtcountdown.Text = "stop";
            timer.Stop();
        }

        protected override void OnResume()
        {
            base.OnResume();
             timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }
        private void Timer_Elapsed(object sender,ElapsedEventArgs e )
        {
            if(count < 10)
            {
                count++;//increase count variable
                RunOnUiThread(() =>
               {
                   txtcountdown.Text = "" + count;
               });

            }
            else if (count == 10)
            {
                txtcountdown.Text = "hello";
            }
            else
            {
                count = 1;//Reset the count variable
                Toast.MakeText(this, "hello",ToastLength.Long).Show();
                txtcountdown.Text = "" + count;

            }
        }
    }
}