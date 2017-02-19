using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;

namespace Demo.Plugin.AlertDialog.Droid
{
    [Preserve(AllMembers = true)]
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterSingleton<IMvxAlertDialog>(new MvxAlertDialog());
        }
    }
}