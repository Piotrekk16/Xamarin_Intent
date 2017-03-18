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
using Android.Util;

namespace App13
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Log.Debug(GetType().FullName, "onCreate - II");
            // Create your application here
            SetContentView(Resource.Layout.Second);

            string text2 = Intent.GetStringExtra("data");
            var textView = FindViewById<TextView>(Resource.Id.textView1);
            textView.Text = text2;
        }

        protected override void OnStart()
        {
            base.OnStart();
            Log.Debug(GetType().FullName, "onStart - II");
        }

        protected override void OnStop()
        {
            base.OnStop();
            Log.Debug(GetType().FullName, "onStop - II");
        }

        protected override void OnDestroy()
        {
            Log.Debug(GetType().FullName, "OnDestroy - II");
            base.OnDestroy();
        }

        protected override void OnPause()
        {
            Log.Debug(GetType().FullName, "OnPause - II");
            base.OnPause();
        }

        protected override void OnRestart()
        {
            Log.Debug(GetType().FullName, "OnRestart - II");
            base.OnRestart();
        }

        protected override void OnResume()
        {
            Log.Debug(GetType().FullName, "OnResume - II");
            base.OnResume();
        }
    }
}