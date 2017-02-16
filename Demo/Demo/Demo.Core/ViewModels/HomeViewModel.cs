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

        #endregion

        #region Helpers

        void GoToVector() => ShowViewModel<VectorViewModel>();

        void GoToRaster() => ShowViewModel<RasterViewModel>();

        #endregion

    }
}
