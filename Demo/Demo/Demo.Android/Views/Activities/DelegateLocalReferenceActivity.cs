using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Demo.Core.ViewModels;

namespace Demo.Android.Views
{
    [Activity(
       Theme = "@style/Demo.Android",
       WindowSoftInputMode = SoftInput.AdjustPan | SoftInput.StateHidden)]
    public class DelegateLocalReferenceActivity : BaseActivity<DelegateLocalReferenceViewModel>
    {
        protected override int ActivityLayoutId => Resource.Layout.layout_activity_generic_delegate;
        protected override int TitleResourceId => Resource.String.toolbar_localref_function;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var button = FindViewById<Button>(Resource.Id.button_close);
            button.Click += delegate
            {
                System.Diagnostics.Debug.WriteLine($"Closing {nameof(DelegateLocalReferenceActivity)}");
                this.Finish();
            };
        }
    }
}