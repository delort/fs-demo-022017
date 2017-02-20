using Demo.AdvancedPCL;
using Demo.Plugin.AlertDialog;
using MvvmCross.Core.ViewModels;

namespace Demo.Core.ViewModels
{
	public class HomeViewModel : BaseViewModel
	{

		readonly IMvxAlertDialog _mvxAlertDialog;

		public HomeViewModel(IMvxAlertDialog mvxAlertDialog)
		{
			_mvxAlertDialog = mvxAlertDialog;
		}

		#region Commands

		IMvxCommand _vectorCommand;
		public IMvxCommand VectorCommand => CreateCommand(ref _vectorCommand, GoToVector);

		IMvxCommand _rasterCommand;
		public IMvxCommand RasterCommand => CreateCommand(ref _rasterCommand, GoToRaster);

		IMvxCommand _fluentLayoutCommand;
		public IMvxCommand FluentLayoutCommand => CreateCommand(ref _fluentLayoutCommand, GoToFluentLayout);

		IMvxCommand _delegateFunctionsCommand;
		public IMvxCommand DelegateFunctionsCommand => CreateCommand(ref _delegateFunctionsCommand, GoToDelegateFunctions);

		IMvxCommand _pluginAlertCommand;
		public IMvxCommand PluginAlertCommand => CreateCommand(ref _pluginAlertCommand, ShowPluginAlertDialog);

		IMvxCommand _baitSwitchAlertCommand;
		public IMvxCommand BaitSwitchAlertCommand => CreateCommand(ref _baitSwitchAlertCommand, ShowBaitSwitchAlertDialog);

		#endregion

		#region Navigation

		void GoToVector() => ShowViewModel<VectorViewModel>();

		void GoToRaster() => ShowViewModel<RasterViewModel>();

		void GoToFluentLayout() => ShowViewModel<FluentLayoutViewModel>();

		void GoToDelegateFunctions() => ShowViewModel<DelegateFunctionsViewModel>();

		#endregion

		#region Command Execution

		void ShowPluginAlertDialog()
		{
			_mvxAlertDialog.ShowDialog(Constants.ALERT_MESSAGE, Constants.ALERT_TITLE, Constants.ALERT_BUTTON);
		}

		void ShowBaitSwitchAlertDialog()
		{
			var dialog = new AlertDialog();
			dialog.ShowDialog(Constants.ALERT_BAITSWITCH_MESSAGE, Constants.ALERT_BAITSWITCH_TITLE, Constants.ALERT_BUTTON);
		}

		#endregion

	}
}
