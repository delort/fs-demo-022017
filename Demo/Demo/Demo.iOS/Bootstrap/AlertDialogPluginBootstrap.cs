using Demo.Plugin.AlertDialog;
using MvvmCross.Platform.Plugins;

namespace Demo.iOS.Bootstrap
{
	[Preserve(AllMembers = true)]
    public class AlertDialogPluginBootstrap
        : MvxLoaderPluginBootstrapAction<Demo.Plugin.AlertDialog.PluginLoader, Demo.Plugin.AlertDialog.iOS.Plugin>
    {
    }
}