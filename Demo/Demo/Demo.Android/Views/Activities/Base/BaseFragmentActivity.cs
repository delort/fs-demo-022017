using Android.OS;
using Android.Support.V7.Widget;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace Demo.Android.Views
{
    public abstract class BaseFragmentActivity<TViewModel> : MvxCachingFragmentCompatActivity<TViewModel>
        where TViewModel : class, IMvxViewModel
    {
        protected abstract int ActivityLayoutId { get; }

        Toolbar _toolbar;
        protected Toolbar Toolbar =>
            FindViewById<Toolbar>(Resource.Id.toolbar);

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(ActivityLayoutId);

            SetSupportActionBar(_toolbar);
        }
    }
}
