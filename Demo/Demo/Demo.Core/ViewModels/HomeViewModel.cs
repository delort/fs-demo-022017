using MvvmCross.Core.ViewModels;

namespace Demo.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {

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

        IMvxCommand _delegateFunctionsCommand;
        public IMvxCommand DelegateFunctionsCommand =>
            _delegateFunctionsCommand ?? (_delegateFunctionsCommand = new MvxCommand(GoToDelegateFunctions));

        #endregion

        #region Navigation

        void GoToVector() => ShowViewModel<VectorViewModel>();

        void GoToRaster() => ShowViewModel<RasterViewModel>();

        void GoToFluentLayout() => ShowViewModel<FluentLayoutViewModel>();

        void GoToDelegateFunctions() => ShowViewModel<DelegateFunctionsViewModel>();

        #endregion

    }
}
