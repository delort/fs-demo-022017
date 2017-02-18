using Android.App;
using Android.Views;
using Demo.Core.ViewModels;

namespace Demo.Android.Views
{
    [Activity(
       Theme = "@style/Demo.Android",
       WindowSoftInputMode = SoftInput.AdjustPan | SoftInput.StateHidden)]
    public class DelegateExportActivity : BaseActivity<DelegateExportViewModel>
    {
        protected override int ActivityLayoutId => Resource.Layout.layout_activity_generic_delegate;
        protected override int TitleResourceId => Resource.String.toolbar_export_function;

        [Java.Interop.Export("button_OnClick")]
        public void Button_OnClick(View v)
        {
            System.Diagnostics.Debug.WriteLine($"Closing {nameof(DelegateExportActivity)}");
            this.Finish();
        }
    }
}