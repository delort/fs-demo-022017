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
    public class DelegateExternalReferenceActivity : BaseActivity<DelegateExternalReferenceViewModel>
    {
        protected override int ActivityLayoutId => Resource.Layout.layout_activity_generic_delegate;
        protected override int TitleResourceId => Resource.String.toolbar_externalref_function;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var button = FindViewById<Button>(Resource.Id.button_close);
            button.Text = Resources.GetString(Resource.String.button_message);

            button.Click += delegate
            {
                System.Diagnostics.Debug.WriteLine($"Clicked {nameof(DelegateExternalReferenceActivity)}");
            };
        }
    }
}