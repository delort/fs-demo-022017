using MvvmCross.Platform;
using MvvmCross.Platform.Droid.Platform;

namespace Demo.AdvancedPCL
{
    public class AlertDialog
    {
        public void ShowDialog(string message, string title, string buttonLabel, System.Action bottonClick = null)
        {
            var context = Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity;

            var dialog = new Android.App.AlertDialog.Builder(context)
                .SetMessage(message)
                .SetTitle(title)
                .SetPositiveButton(buttonLabel, (sender, args) => bottonClick?.Invoke())
                .Show();
        }
    }
}
