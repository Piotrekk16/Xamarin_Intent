using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Util;

namespace App13
{
    [Activity(Label = "App13", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Log.Debug(GetType().FullName, "OnCreate - I");

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            var clickButton = FindViewById<Button>(Resource.Id.ClickButton);

            clickButton.Click += delegate
            {
                var intent = new Intent(this, typeof(SecondActivity));
                intent.PutExtra("data", "weewew");
                StartActivity(intent);
            };
        }

        protected override void OnStart()
        {
            base.OnStart();
            Log.Debug(GetType().FullName, "onStart - I");
        }

        protected override void OnStop()
        {
            base.OnStop();
            Log.Debug(GetType().FullName, "onStop - I");
        }

        protected override void OnDestroy()
        {
            Log.Debug(GetType().FullName, "OnDestroy - I");
            base.OnDestroy();
        }

        protected override void OnPause()
        {
            Log.Debug(GetType().FullName, "OnPause - I");
            base.OnPause();
        }

        protected override void OnRestart()
        {
            Log.Debug(GetType().FullName, "OnRestart - I");
            base.OnRestart();
        }

        protected override void OnResume()
        {
            Log.Debug(GetType().FullName, "OnResume - I");
            base.OnResume();
        }
    }
}

