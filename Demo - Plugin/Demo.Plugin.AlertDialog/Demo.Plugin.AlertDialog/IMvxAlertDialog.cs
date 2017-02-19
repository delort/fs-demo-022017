namespace Demo.Plugin.AlertDialog
{
    public interface IMvxAlertDialog
    {
        void ShowDialog(string message, string title, string buttonLabel, System.Action bottonClick = null);
    }
}