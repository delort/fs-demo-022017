using Cirrious.FluentLayouts.Touch;
using MvvmCross.Binding.BindingContext;
using UIKit;
using Demo.Core.ViewModels;

namespace Demo.iOS.Views
{
    public class HomeViewController : BaseViewController<HomeViewModel>
    {
        UIButton _goForwardButton;
        MvxFluentBindingDescriptionSet<HomeViewController, HomeViewModel> _bindingSet;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = "First View";

            CreateViewElements();

            LayoutViewElements();

            Bind();
        }

        void CreateViewElements()
        {
            _goForwardButton = new UIButton(UIButtonType.RoundedRect);
            _goForwardButton.SetTitle("Go Forward", UIControlState.Normal);
            Add(_goForwardButton);
        }

        void LayoutViewElements()
        {
            View.AddConstraints(new FluentLayout[]
            {
                _goForwardButton.AtTopOf(View, 12f),
                _goForwardButton.WithSameCenterX(View)
            });
        }

        void Bind()
        {
            _bindingSet = this.CreateBindingSet<HomeViewController, HomeViewModel>();

            _bindingSet.Apply();
        }
    }
}