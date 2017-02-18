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

        UIButton _goToVectorButton, _goToRasterButton;
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

            _goToRasterButton = new UIButton(UIButtonType.RoundedRect);
            _goToRasterButton.SetTitle(iOSConstants.BUTTON_RASTER, UIControlState.Normal);

            View.AddSubviews(_goToVectorButton, _goToRasterButton);
        }

        void LayoutViewElements()
        {
            View.AddConstraints(new FluentLayout[]
            {
                _goToVectorButton.AtTopOf(View, 12f),
                _goToVectorButton.WithSameCenterX(View),

                _goToRasterButton.Below(_goToVectorButton, 12f),
                _goToRasterButton.WithSameCenterX(View)
            });
        }

        void Bind()
        {
            _bindingSet = this.CreateBindingSet<HomeViewController, HomeViewModel>();

            _bindingSet.Bind(_goToVectorButton).To(vm => vm.VectorCommand);
            _bindingSet.Bind(_goToRasterButton).To(vm => vm.RasterCommand);

            _bindingSet.Apply();
        }
    }
}