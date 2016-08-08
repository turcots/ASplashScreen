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

namespace ASplashScreen
{
    [Activity(Label = "Parametres",
        ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape,
        ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize | Android.Content.PM.ConfigChanges.Orientation)]
    class Parametres : AppCompatActivity
    {
        public Button BtnBackToMenu
        {
            get { return FindViewById<Button>(Resource.Id.btnBackToMenu); }
        }

        public Button BtnPopup
        {
            get { return FindViewById<Button>(Resource.Id.btnPopup); }
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Parametres);

            SupportActionBar.Hide();

            BtnBackToMenu.Click += BtnBackToMenu_Click;
            BtnPopup.Click += BtnPopup_Click;
        }

        private void BtnPopup_Click(object sender, EventArgs e)
        {
            var alert = new Android.Support.V7.App.AlertDialog.Builder(this);
            alert.SetView(LayoutInflater.Inflate(Resource.Layout.popup, null));
            alert.Create().Show();
        }
        private void BtnBackToMenu_Click(object sender, EventArgs e)
        {
            Intent intent;
            intent = new Intent(this, typeof(Activity1));
            StartActivity(intent);
            OverridePendingTransition(Resource.Animation.@Slide_to_right, Resource.Animation.@Slide_out_left);

        }
    }
}