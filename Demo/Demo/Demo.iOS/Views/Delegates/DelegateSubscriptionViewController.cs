using Cirrious.FluentLayouts.Touch;
using Demo.Core.ViewModels;
using Demo.iOS.Helpers;
using UIKit;

namespace Demo.iOS.Views
{
    public class DelegateSubscriptionViewController : BaseViewController<DelegateSubscriptionViewModel>
    {
        public override string Title => iOSConstants.VIEW_CONTROLLER_SUBSCRIPTION_FUNCTION_TITLE;

        UIButton _goToBackButton;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            CreateViewElements();

            LayoutViewElements();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            _goToBackButton.TouchUpInside += GoToBackButton_TouchUpInside;
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
            _goToBackButton.TouchUpInside -= GoToBackButton_TouchUpInside;
        }

        void CreateViewElements()
        {
            _goToBackButton = new UIButton(UIButtonType.RoundedRect);
            _goToBackButton.SetTitle(iOSConstants.BUTTON_CLOSE, UIControlState.Normal);

            View.AddSubviews(_goToBackButton);
        }

        void LayoutViewElements()
        {
            View.AddConstraints(new FluentLayout[]
            {
                _goToBackButton.AtTopOf(View, iOSConstants.CONTENT_PADDING),
                _goToBackButton.WithSameCenterX(View)
            });
        }

        void GoToBackButton_TouchUpInside(object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"Closing {nameof(DelegateLocalReferenceViewController)}");
            this.ViewModel.NavigateBackCommand.Execute();
        }
    }
}
