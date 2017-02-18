using Cirrious.FluentLayouts.Touch;
using MvvmCross.Binding.BindingContext;
using UIKit;
using Demo.Core.ViewModels;
using Demo.iOS.Helpers;

namespace Demo.iOS.Views
{
    public class HomeViewController : BaseViewController<HomeViewModel>
    {
        public override string Title => iOSConstants.VIEW_CONTROLLER_HOME_TITLE;

        UIButton _goToVectorButton;
        MvxFluentBindingDescriptionSet<HomeViewController, HomeViewModel> _bindingSet;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            CreateViewElements();

            LayoutViewElements();

            Bind();
        }

        void CreateViewElements()
        {
            _goToVectorButton = new UIButton(UIButtonType.RoundedRect);
            _goToVectorButton.SetTitle(iOSConstants.BUTTON_VECTOR, UIControlState.Normal);

            View.AddSubviews(_goToVectorButton);
        }

        void LayoutViewElements()
        {
            View.AddConstraints(new FluentLayout[]
            {
                _goToVectorButton.AtTopOf(View, iOSConstants.CONTENT_PADDING),
                _goToVectorButton.WithSameCenterX(View)
            });
        }

        void Bind()
        {
            _bindingSet = this.CreateBindingSet<HomeViewController, HomeViewModel>();

            _bindingSet.Bind(_goToVectorButton).To(vm => vm.VectorCommand);

            _bindingSet.Apply();
        }
    }
}