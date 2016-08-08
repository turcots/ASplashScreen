
using Android.App;
using Android.OS;
using Android.Util;
using Android.Support.V7.App;
using Android.Widget;
using Android.Content;

namespace ASplashScreen
{
    [Activity(Label = "@string/ApplicationName", 
        ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape,
        ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize | Android.Content.PM.ConfigChanges.Orientation)]
    public class Activity1 : AppCompatActivity
    {
        //static readonly string TAG = "X:" + typeof(Activity1).Name;
        public Button BtnParametre
        {
            get { return FindViewById<Button>(Resource.Id.btnParametre); }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            SupportActionBar.Hide();

            BtnParametre.Click += BtnParametre_Click;

            // Create your application here
            //Log.Debug(TAG, "Activity1 is loaded.");

        }

        private void BtnParametre_Click(object sender, System.EventArgs e)
        {
            Intent intent;
            intent = new Intent(this, typeof(Parametres));
            StartActivity(intent);
            OverridePendingTransition(Resource.Animation.@Slide_to_left, Resource.Animation.@Slide_out_right);
        }
    }
}