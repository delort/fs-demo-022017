using Android.App;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Platform;
using Demo.Core.ViewModels;

namespace Demo.Android.Views
{
    [Activity(
        Theme = "@style/Demo.Android",
        WindowSoftInputMode = SoftInput.AdjustPan | SoftInput.StateHidden)]
    public class MainActivity : BaseActivity<MainContainerViewModel>
    {
        protected override int ActivityLayoutId => Resource.Layout.layout_activity;
    }
}
