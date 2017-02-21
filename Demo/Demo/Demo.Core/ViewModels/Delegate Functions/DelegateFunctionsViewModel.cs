using MvvmCross.Core.ViewModels;

namespace Demo.Core.ViewModels
{
    public class DelegateFunctionsViewModel : BaseViewModel
    {
        #region Commands

        IMvxCommand _exportFunctionCommand;
        public IMvxCommand ExportFunctionCommand => CreateCommand(ref _exportFunctionCommand, GoToExportFunction);

        IMvxCommand _localRefFunctionCommand;
        public IMvxCommand LocalRefFunctionCommand => CreateCommand(ref _localRefFunctionCommand, GoToLocalRefFunction);

        IMvxCommand _externalRefFunctionCommand;
        public IMvxCommand ExternalRefFunctionCommand => CreateCommand(ref _externalRefFunctionCommand, GoToExternalRefFunction);

        IMvxCommand _subscriptionFunctionCommand;
        public IMvxCommand SubscriptionFunctionCommand => CreateCommand(ref _subscriptionFunctionCommand, GoToSubscriptionFunctions);

        #endregion

        #region Navigation

        void GoToExportFunction() => ShowViewModel<DelegateExportViewModel>();

        void GoToLocalRefFunction() => ShowViewModel<DelegateLocalReferenceViewModel>();

        void GoToExternalRefFunction() => ShowViewModel<DelegateExternalReferenceViewModel>();

        void GoToSubscriptionFunctions() => ShowViewModel<DelegateSubscriptionViewModel>();

        #endregion
    }
}
