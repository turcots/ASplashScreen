
using Android.App;
using Android.Content;
using System.Threading.Tasks;
using Android.OS;
using Android.Support.V7.App;
using Android.Util;

namespace ASplashScreen
{
    [Activity(Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true, ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]
    public class MainActivity : AppCompatActivity
    {
        static readonly string TAG = "X:" + typeof(MainActivity).Name;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //Log.Debug(TAG, "SplashActivity.OnCreate");
        }

        protected override void OnResume()
        {
            base.OnResume();

            Task startupWork = new Task(() =>
            {
                //Log.Debug(TAG, "Performing some startup work that takes a bit of time.");
                //Task.Delay(5000); // Simulate a bit of startup work.

                //Log.Debug(TAG, "Working in the background - important stuff.");
            });

          //  startupWork.Wait(5000);

            startupWork.ContinueWith(t =>
            {
                //Log.Debug(TAG, "Work is finished - start Activity1.");
                StartActivity(new Intent(Application.Context, typeof(Activity1)));
            }, TaskScheduler.FromCurrentSynchronizationContext());

            startupWork.Start();
        }
    }
}

