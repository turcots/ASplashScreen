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
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Parametres);

            SupportActionBar.Hide();

            BtnBackToMenu.Click += BtnBackToMenu_Click;
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