using System;
using MvvmCross.Core.ViewModels;

namespace Demo.Core.ViewModels
{
    public abstract class BaseViewModel : MvxViewModel
    {
        #region Commands

        IMvxCommand _navigateBackCommand;
        public IMvxCommand NavigateBackCommand => CreateCommand(ref _navigateBackCommand, GoBack);

        #endregion

        #region Navigation

        void GoBack() => Close(this);

        #endregion

        #region Helpers

        public IMvxCommand CreateCommand(ref IMvxCommand localCommand, Action commandExecution, Func<bool> canExecuteCommand = null)
            => localCommand ?? (localCommand = new MvxCommand(commandExecution, canExecuteCommand));

        #endregion
    }
}
