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
    public class DelegateSubscriptionActivity : BaseActivity<DelegateSubscriptionViewModel>
    {
        protected override int ActivityLayoutId => Resource.Layout.layout_activity_generic_delegate;
        protected override int TitleResourceId => Resource.String.toolbar_subscription_function;

        Button _closeButton;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            _closeButton = FindViewById<Button>(Resource.Id.button_close);
        }

        protected override void OnResume()
        {
            base.OnResume();
            _closeButton.Click += CloseButton_Click;
        }

        protected override void OnPause()
        {
            base.OnPause();
            _closeButton.Click -= CloseButton_Click;
        }

        void CloseButton_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"Closing {nameof(DelegateSubscriptionActivity)}");
            this.Finish();
        }
    }
}
