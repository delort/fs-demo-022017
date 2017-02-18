using MvvmCross.Core.ViewModels;

namespace Demo.Core.ViewModels
{
    public class DelegateFunctionsViewModel : MvxViewModel
    {
        #region Commands

        IMvxCommand _exportFunctionCommand;
        public IMvxCommand ExportFunctionCommand =>
            _exportFunctionCommand ?? (_exportFunctionCommand = new MvxCommand(GoToExportFunction));

        IMvxCommand _localRefFunctionCommand;
        public IMvxCommand LocalRefFunctionCommand =>
            _localRefFunctionCommand ?? (_localRefFunctionCommand = new MvxCommand(GoToLocalRefFunction));

        IMvxCommand _externalRefFunctionCommand;
        public IMvxCommand ExternalRefFunctionCommand =>
            _externalRefFunctionCommand ?? (_externalRefFunctionCommand = new MvxCommand(GoToExternalRefFunction));

        IMvxCommand _subscriptionFunctionCommand;
        public IMvxCommand SubscriptionFunctionCommand =>
            _subscriptionFunctionCommand ?? (_subscriptionFunctionCommand = new MvxCommand(GoToSubscriptionFunctions));

        #endregion

        #region Navigation

        void GoToExportFunction() => ShowViewModel<DelegateExportViewModel>();

        void GoToLocalRefFunction() => ShowViewModel<DelegateLocalReferenceViewModel>();

        void GoToExternalRefFunction() => ShowViewModel<DelegateExternalReferenceViewModel>();

        void GoToSubscriptionFunctions() => ShowViewModel<DelegateSubscriptionViewModel>();

        #endregion
    }
}
