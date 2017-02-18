using MvvmCross.Core.ViewModels;

namespace Demo.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {

        #region Commands

        IMvxCommand _vectorCommand;
        public IMvxCommand VectorCommand =>
            _vectorCommand ?? (_vectorCommand = new MvxCommand(GoToVector));

        IMvxCommand _rasterCommand;
        public IMvxCommand RasterCommand =>
            _rasterCommand ?? (_rasterCommand = new MvxCommand(GoToRaster));

        IMvxCommand _delegateFunctionsCommand;
        public IMvxCommand DelegateFunctionsCommand =>
            _delegateFunctionsCommand ?? (_delegateFunctionsCommand = new MvxCommand(GoToDelegateFunctions));

        #endregion

        #region Navigation

        void GoToVector() => ShowViewModel<VectorViewModel>();

        void GoToRaster() => ShowViewModel<RasterViewModel>();

        void GoToDelegateFunctions() => ShowViewModel<DelegateFunctionsViewModel>();

        #endregion

    }
}
