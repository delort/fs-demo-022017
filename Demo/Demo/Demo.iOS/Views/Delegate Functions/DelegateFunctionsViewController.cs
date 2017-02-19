using Cirrious.FluentLayouts.Touch;
using Demo.Core.ViewModels;
using Demo.iOS.Helpers;
using MvvmCross.Binding.BindingContext;
using UIKit;

namespace Demo.iOS.Views
{
    public class DelegateFunctionsViewController : BaseViewController<DelegateFunctionsViewModel>
    {
        public override string Title => iOSConstants.VIEW_CONTROLLER_DELEGATE_FUNCTIONS_TITLE;

        UIButton _goToLocalrefFunctionButton, _goToExternalrefFunctionButton, _goToSubscriptionFunctionButton;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            CreateViewElements();

            LayoutViewElements();

            Bind();
        }

        void CreateViewElements()
        {
            _goToLocalrefFunctionButton = new UIButton(UIButtonType.RoundedRect);
            _goToLocalrefFunctionButton.SetTitle(iOSConstants.BUTTON_LOCALREF_FUNCTION, UIControlState.Normal);

            _goToExternalrefFunctionButton = new UIButton(UIButtonType.RoundedRect);
            _goToExternalrefFunctionButton.SetTitle(iOSConstants.BUTTON_EXTERNALREF_FUNCTION, UIControlState.Normal);

            _goToSubscriptionFunctionButton = new UIButton(UIButtonType.RoundedRect);
            _goToSubscriptionFunctionButton.SetTitle(iOSConstants.BUTTON_SUBSCRIPTION_FUNCTION, UIControlState.Normal);

            View.AddSubviews(_goToLocalrefFunctionButton, _goToExternalrefFunctionButton, _goToSubscriptionFunctionButton);
        }

        void LayoutViewElements()
        {
            View.AddConstraints(new FluentLayout[]
            {
                _goToLocalrefFunctionButton.AtTopOf(View, iOSConstants.CONTENT_PADDING),
                _goToLocalrefFunctionButton.WithSameCenterX(View),

                _goToExternalrefFunctionButton.Below(_goToLocalrefFunctionButton, iOSConstants.CONTENT_PADDING),
                _goToExternalrefFunctionButton.WithSameCenterX(View),

                _goToSubscriptionFunctionButton.Below(_goToExternalrefFunctionButton, iOSConstants.CONTENT_PADDING),
                _goToSubscriptionFunctionButton.WithSameCenterX(View)
            });
        }

        void Bind()
        {
            var bindingSet = this.CreateBindingSet<DelegateFunctionsViewController, DelegateFunctionsViewModel>();

            bindingSet.Bind(_goToLocalrefFunctionButton).To(vm => vm.LocalRefFunctionCommand);
            bindingSet.Bind(_goToExternalrefFunctionButton).To(vm => vm.ExternalRefFunctionCommand);
            bindingSet.Bind(_goToSubscriptionFunctionButton).To(vm => vm.SubscriptionFunctionCommand);

            bindingSet.Apply();
        }
    }
}
