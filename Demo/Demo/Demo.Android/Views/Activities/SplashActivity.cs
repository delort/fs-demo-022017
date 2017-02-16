using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V7.App;
using MvvmCross.Droid.Support.V7.AppCompat;

// Declarations for Android hardware and software features used by your application go here, for example
//[assembly: UsesFeature("android.hardware.camera", Required = false)]

// Declarations for Android permissions used by your application go here, for example
//[assembly: Permission(Name = Android.Manifest.Permission.Internet)]

namespace Demo.Android.Views
{
    [Activity(
        MainLauncher = true,
        Theme = "@style/SplashTheme",
        Icon = "@mipmap/icon",
        NoHistory = true,
        ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreenActivity : MvxSplashScreenAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            // TODO :: Vector drawables failing < API 21. Bugzilla: https://bugzilla.xamarin.com/show_bug.cgi?id=41489. Try http://stackoverflow.com/a/38847668/4865498
            AppCompatDelegate.CompatVectorFromResourcesEnabled = true;

            base.OnCreate(bundle);
        }
    }
}