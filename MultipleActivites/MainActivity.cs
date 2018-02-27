using System;
using Android.App;
using Android.Widget;
using Android.OS;

namespace MultipleActivites
{
    [Activity(Label = "MultipleActivites", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Button btnNext;
        private TextView txtName;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            txtName = FindViewById<TextView>(Resource.Id.txtName);
            btnNext = FindViewById<Button>(Resource.Id.btnNext);
            btnNext.Click += OnNextButtonClick;
        }

        private void OnNextButtonClick(object sender, EventArgs e)
        {
            StartActivity(typeof(SecondActivity));
        }
    }
}

