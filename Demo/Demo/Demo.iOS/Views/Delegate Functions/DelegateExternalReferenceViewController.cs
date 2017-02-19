using Cirrious.FluentLayouts.Touch;
using Demo.Core.ViewModels;
using Demo.iOS.Helpers;
using UIKit;

namespace Demo.iOS.Views
{
    public class DelegateExternalReferenceViewController : BaseViewController<DelegateExternalReferenceViewModel>
    {
        public override string Title => iOSConstants.VIEW_CONTROLLER_EXTERNALREF_FUNCTION_TITLE;

        UIButton _goToBackButton;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            CreateViewElements();

            LayoutViewElements();

            DelegateAssignment();
        }

        void CreateViewElements()
        {
            _goToBackButton = new UIButton(UIButtonType.RoundedRect);
            _goToBackButton.SetTitle(iOSConstants.BUTTON_MESSAGE, UIControlState.Normal);

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

        void DelegateAssignment()
        {
            _goToBackButton.TouchUpInside += delegate
            {
                System.Diagnostics.Debug.WriteLine($"Clicked {nameof(DelegateExternalReferenceViewController)}");
            };
        }
    }
}
