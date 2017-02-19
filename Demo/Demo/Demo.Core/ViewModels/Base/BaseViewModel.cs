using MvvmCross.Core.ViewModels;

namespace Demo.Core.ViewModels
{
    public abstract class BaseViewModel: MvxViewModel
    {
        #region Commands

        IMvxCommand _navigateBackCommand;
        public IMvxCommand NavigateBackCommand =>
            _navigateBackCommand ?? (_navigateBackCommand = new MvxCommand(GoBack));

        #endregion

        #region Navigation

        void GoBack() => Close(this);

        #endregion
    }
}
