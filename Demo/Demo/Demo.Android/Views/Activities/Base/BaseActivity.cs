using Android.OS;
using Android.Support.V7.Widget;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace Demo.Android.Views
{
    public abstract class BaseActivity<TViewModel> : MvxAppCompatActivity<TViewModel>
        where TViewModel : class, IMvxViewModel
    {
        protected abstract int ActivityLayoutId { get; }
        protected abstract int TitleResourceId { get; }

        protected Toolbar Toolbar => FindViewById<Toolbar>(Resource.Id.toolbar);

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(ActivityLayoutId);

            SetSupportActionBar(Toolbar);

            Title = Resources.GetString(TitleResourceId);
        }
    }
}
