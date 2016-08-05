
using Android.App;
using Android.OS;
using Android.Util;
using Android.Support.V7.App;
using Android.Widget;

namespace ASplashScreen
{
    [Activity(Label = "@string/ApplicationName", 
        ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape,
        ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize | Android.Content.PM.ConfigChanges.Orientation)]
    public class Activity1 : AppCompatActivity
    {
        static readonly string TAG = "X:" + typeof(Activity1).Name;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            SupportActionBar.Hide();

            // Create your application here
            //Log.Debug(TAG, "Activity1 is loaded.");

        }
    }
}