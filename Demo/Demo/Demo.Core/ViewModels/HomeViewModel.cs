using MvvmCross.Core.ViewModels;

namespace Demo.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {

        #region Commands

        IMvxCommand _vectorCommand;
        public IMvxCommand VectorCommand =>
            _vectorCommand ?? (_vectorCommand = new MvxCommand(GoToVector));

        IMvxCommand _memoryCommand;
        public IMvxCommand MemoryCommand =>
            _memoryCommand ?? (_memoryCommand = new MvxCommand(GoToMemory));

        #endregion

        #region Helpers

        void GoToVector() => ShowViewModel<VectorViewModel>();

        void GoToMemory() => ShowViewModel<MemoryDemoViewModel>();

        #endregion

    }
}
