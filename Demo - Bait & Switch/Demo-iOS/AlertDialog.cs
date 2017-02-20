using UIKit;

namespace Demo.AdvancedPCL
{
    public class AlertDialog
    {
        public void ShowDialog(string message, string title, string buttonLabel, System.Action bottonClick = null)
        {
            var dialog = new UIAlertView(title, message, null, buttonLabel, null);
            dialog.Clicked += (sender, args) => bottonClick?.Invoke();
            dialog.Show();
        }
    }
}
