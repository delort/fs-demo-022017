using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace Demo.Android.Views
{
    public abstract class BaseActivity<TViewModel> : MvxCachingFragmentCompatActivity<TViewModel>
        where TViewModel : class, IMvxViewModel
    {
        protected abstract int ActivityLayoutId { get; }

        Toolbar _toolbar;
        protected Toolbar Toolbar =>
            FindViewById<Toolbar>(Resource.Id.toolbar);

        protected override void OnCreate(Bundle bundle)
        {
            // TODO :: Vector drawables failing < API 21. Bugzilla: https://bugzilla.xamarin.com/show_bug.cgi?id=41489. Try http://stackoverflow.com/a/38847668/4865498
            AppCompatDelegate.CompatVectorFromResourcesEnabled = true;

            base.OnCreate(bundle);

            SetContentView(ActivityLayoutId);

            SetSupportActionBar(_toolbar);
        }
    }
}