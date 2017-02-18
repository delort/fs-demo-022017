using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Demo.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Droid.Shared.Attributes;

namespace Demo.Android.Views
{
    [MvxFragment(typeof(MainContainerViewModel), Resource.Id.content_frame)]
    [Register(nameof(DelegateFunctionsFragment))]
    public class DelegateFunctionsFragment : BaseFragment<DelegateFunctionsViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.layout_fragment_delegate_functions;
        protected override string ToolbarText => Resources.GetString(Resource.String.toolbar_delegate_functions);

        Button _exportButton, _loaclRefButton, _externalRefButton, _subscriptionButton;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            _exportButton = view.FindViewById<Button>(Resource.Id.button_export_function);
            _loaclRefButton = view.FindViewById<Button>(Resource.Id.button_localref_function);
            _externalRefButton = view.FindViewById<Button>(Resource.Id.button_externalref_function);
            _subscriptionButton = view.FindViewById<Button>(Resource.Id.button_subscription_function);

            Bind();

            return view;
        }

        void Bind()
        {
            var bindingSet = this.CreateBindingSet<DelegateFunctionsFragment, DelegateFunctionsViewModel>();

            bindingSet.Bind(_exportButton).To(vm => vm.ExportFunctionCommand);
            bindingSet.Bind(_loaclRefButton).To(vm => vm.LocalRefFunctionCommand);
            bindingSet.Bind(_externalRefButton).To(vm => vm.ExternalRefFunctionCommand);
            bindingSet.Bind(_subscriptionButton).To(vm => vm.SubscriptionFunctionCommand);

            bindingSet.Apply();
        }
    }
}