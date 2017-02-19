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
        public IMvxCommand VectorCommand =>
            _vectorCommand ?? (_vectorCommand = new MvxCommand(GoToVector));

        IMvxCommand _rasterCommand;
        public IMvxCommand RasterCommand =>
            _rasterCommand ?? (_rasterCommand = new MvxCommand(GoToRaster));

        IMvxCommand _fluentLayoutCommand;
        public IMvxCommand FluentLayoutCommand =>
            _fluentLayoutCommand ?? (_fluentLayoutCommand = new MvxCommand(GoToFluentLayout));

        IMvxCommand _storyboardCommand;
        public IMvxCommand StoryboardCommand =>
            _storyboardCommand ?? (_storyboardCommand = new MvxCommand(GoToStoryboard));

        IMvxCommand _delegateFunctionsCommand;
        public IMvxCommand DelegateFunctionsCommand =>
            _delegateFunctionsCommand ?? (_delegateFunctionsCommand = new MvxCommand(GoToDelegateFunctions));

        IMvxCommand _pluginAlertCommand;
        public IMvxCommand PluginAlertCommand =>
            _pluginAlertCommand ?? (_pluginAlertCommand = new MvxCommand(ShowAlertDialog));

        #endregion

        #region Navigation

        void GoToVector() => ShowViewModel<VectorViewModel>();

        void GoToRaster() => ShowViewModel<RasterViewModel>();

        void GoToFluentLayout() => ShowViewModel<FluentLayoutViewModel>();

        void GoToStoryboard() => ShowViewModel<StoryboardViewModel>();

        void GoToDelegateFunctions() => ShowViewModel<DelegateFunctionsViewModel>();

        #endregion

        #region Command Execution

        void ShowAlertDialog()
        {
            _mvxAlertDialog.ShowDialog(Constants.ALERT_MESSAGE, Constants.ALERT_TITLE, Constants.ALERT_BUTTON);
        }

        #endregion

    }
}
