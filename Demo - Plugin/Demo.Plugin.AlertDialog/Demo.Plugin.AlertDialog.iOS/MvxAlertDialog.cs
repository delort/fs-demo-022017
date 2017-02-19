using UIKit;

namespace Demo.Plugin.AlertDialog.iOS
{
    [Preserve(AllMembers = true)]
    public class MvxAlertDialog : IMvxAlertDialog
    {
        public void ShowDialog(string message, string title, string buttonLabel, System.Action bottonClick = null)
        {
            var dialog = new UIAlertView(title, message, null, buttonLabel, null);
            dialog.Clicked += (sender, args) => bottonClick?.Invoke();
            dialog.Show();
        }
    }
}
