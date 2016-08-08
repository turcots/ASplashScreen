
using Android.App;
using Android.Content;
using System.Threading.Tasks;
using Android.OS;
using Android.Support.V7.App;

namespace ASplashScreen
{
    [Activity(Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true, ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SupportActionBar.Hide();
            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.Main);

        }



            //public void slideUpDown(final View view)
            //{
            //    if (!isPanelShown)
            //    {
            //        // Show the panel
            //        Animation bottomUp = AnimationUtils.loadAnimation(this,
            //                R.anim.bottom_up);

            //        hiddenPanel.startAnimation(bottomUp);
            //        hiddenPanel.setVisibility(View.VISIBLE);
            //        isPanelShown = true;
            //    }
            //    else
            //    {
            //        // Hide the Panel
            //        Animation bottomDown = AnimationUtils.loadAnimation(this,
            //                R.anim.bottom_down);

            //        hiddenPanel.startAnimation(bottomDown);
            //        hiddenPanel.setVisibility(View.INVISIBLE);
            //        isPanelShown = false;
            //    }
            //}

            //protected void BtnParametre_Click(object sender, System.EventArgs e)
            //{
            //    Intent intent;
            //    intent = new Intent(this, typeof(Parametres));
            //    StartActivity(intent);
            //  //  OverridePendingTransition(Resource.Animation.)
            //}

        protected override void OnResume()
        {
            base.OnResume();

            Task startupWork = new Task(() =>
            {
                //Log.Debug(TAG, "Performing some startup work that takes a bit of time.");
             //   Task.Delay(5000); // Simulate a bit of startup work.

                //Log.Debug(TAG, "Working in the background - important stuff.");
            });

            //startupWork.Wait(5000);

            startupWork.ContinueWith(t =>
            {
                //Log.Debug(TAG, "Work is finished - start Activity1.");
                StartActivity(new Intent(Application.Context, typeof(Activity1)));
            }, TaskScheduler.FromCurrentSynchronizationContext());

            startupWork.Start();
        }
    }
}

