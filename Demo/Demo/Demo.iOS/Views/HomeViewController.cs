using Cirrious.FluentLayouts.Touch;
using Demo.Core.ViewModels;
using Demo.iOS.Helpers;
using MvvmCross.Binding.BindingContext;
using UIKit;

namespace Demo.iOS.Views
{
    public class HomeViewController : BaseViewController<HomeViewModel>
    {
        public override string Title => iOSConstants.VIEW_CONTROLLER_HOME_TITLE;

        MvxFluentBindingDescriptionSet<HomeViewController, HomeViewModel> _bindingSet;
        UIButton _goToVectorButton, _goToFluentLayoutButton, _goToStoryboardButton, _goToDelegateFunctionsButton, _showPluginAlertButton;

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

            _goToFluentLayoutButton = new UIButton(UIButtonType.RoundedRect);
            _goToFluentLayoutButton.SetTitle(iOSConstants.BUTTON_FLUENTLAYOUT, UIControlState.Normal);

            _goToStoryboardButton = new UIButton(UIButtonType.RoundedRect);
            _goToStoryboardButton.SetTitle(iOSConstants.BUTTON_STORYBOARD, UIControlState.Normal);

            _goToDelegateFunctionsButton = new UIButton(UIButtonType.RoundedRect);
            _goToDelegateFunctionsButton.SetTitle(iOSConstants.BUTTON_DELEGATE_FUNCTIONS, UIControlState.Normal);

            _showPluginAlertButton = new UIButton(UIButtonType.RoundedRect);
            _showPluginAlertButton.SetTitle(iOSConstants.BUTTON_PLUGIN_ALERT, UIControlState.Normal);

            View.AddSubviews(_goToVectorButton, _goToFluentLayoutButton, _goToStoryboardButton, _goToDelegateFunctionsButton, _showPluginAlertButton);
        }

        void LayoutViewElements()
        {
            View.AddConstraints(new FluentLayout[]
            {
                _goToVectorButton.AtTopOf(View, iOSConstants.CONTENT_PADDING),
                _goToVectorButton.WithSameCenterX(View),

                _goToFluentLayoutButton.Below(_goToVectorButton, iOSConstants.CONTENT_PADDING),
                _goToFluentLayoutButton.WithSameCenterX(View),

                _goToStoryboardButton.Below(_goToFluentLayoutButton, iOSConstants.CONTENT_PADDING),
                _goToStoryboardButton.WithSameCenterX(View),

                _goToDelegateFunctionsButton.Below(_goToStoryboardButton, iOSConstants.CONTENT_PADDING),
                _goToDelegateFunctionsButton.WithSameCenterX(View),

                _showPluginAlertButton.Below(_goToDelegateFunctionsButton, iOSConstants.CONTENT_PADDING),
                _showPluginAlertButton.WithSameCenterX(View)
            });
        }

        void Bind()
        {
            _bindingSet = this.CreateBindingSet<HomeViewController, HomeViewModel>();

            _bindingSet.Bind(_goToVectorButton).To(vm => vm.VectorCommand);
            _bindingSet.Bind(_goToFluentLayoutButton).To(vm => vm.FluentLayoutCommand);
            _bindingSet.Bind(_goToStoryboardButton).To(vm => vm.StoryboardCommand);
            _bindingSet.Bind(_goToDelegateFunctionsButton).To(vm => vm.DelegateFunctionsCommand);
            _bindingSet.Bind(_showPluginAlertButton).To(vm => vm.PluginAlertCommand);

            _bindingSet.Apply();
        }
    }
}
