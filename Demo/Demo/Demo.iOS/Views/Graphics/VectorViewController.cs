using Cirrious.FluentLayouts.Touch;
using Demo.Core.ViewModels;
using Demo.iOS.Helpers;
using MvvmCross.Binding.BindingContext;
using UIKit;

namespace Demo.iOS.Views
{
    public class VectorViewController : BaseViewController<VectorViewModel>
    {
        public override string Title => iOSConstants.VIEW_CONTROLLER_VECTOR_TITLE;

        MvxFluentBindingDescriptionSet<VectorViewController, VectorViewModel> _bindingSet;
        UIImageView _vectorImageView;
        UILabel _vectorExplanantion;
        UISlider _sizeSlider;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            CreateViewElements();

            LayoutViewElements();

            Bind();
        }

        void CreateViewElements()
        {
            _vectorImageView = new UIImageView(UIImage.FromBundle("Vectors"));

            _vectorExplanantion = new UILabel
            {
                Text = iOSConstants.VECTOR_EXPLANATION,
                Font = UIFont.FromName(iOSConstants.FONT_HELVETICA_NEUE, iOSConstants.FONT_MEDIUM),
                Lines = 0,
                LineBreakMode = UILineBreakMode.WordWrap
            };

            _sizeSlider = new UISlider
            {
                MinValue = 0,
                MaxValue = (float)UIScreen.MainScreen.Bounds.Width,
                MinimumTrackTintColor = iOSConstants.DEMO_COLOR,
                MaximumTrackTintColor = iOSConstants.DEMO_COLOR,
                ThumbTintColor = iOSConstants.DEMO_COLOR
            };

            View.AddSubviews(_vectorImageView, _vectorExplanantion, _sizeSlider);
        }

        void LayoutViewElements()
        {
            View.AddConstraints(new FluentLayout[]
            {
                _vectorImageView.AtTopOf(View, iOSConstants.CONTENT_PADDING),

                _sizeSlider.AtBottomOf(View, iOSConstants.CONTENT_PADDING),
                _sizeSlider.AtLeftOf(View, iOSConstants.SIDE_PADDING),
                _sizeSlider.AtRightOf(View, iOSConstants.SIDE_PADDING),

                _vectorExplanantion.Above(_sizeSlider, iOSConstants.CONTENT_PADDING),
                _vectorExplanantion.AtLeftOf(View, iOSConstants.SIDE_PADDING),
                _vectorExplanantion.WithSameWidth(_sizeSlider),
                _vectorExplanantion.AtRightOf(View, iOSConstants.SIDE_PADDING),
            });
        }

        void Bind()
        {
            _bindingSet = this.CreateBindingSet<VectorViewController, VectorViewModel>();

            _bindingSet.Bind(_sizeSlider).To(vm => vm.Size);
            _bindingSet.Bind(_vectorImageView).For(iOSConstants.SIZE_TARGET_BINDING_KEY).To(vm => vm.Size);

            _bindingSet.Apply();
        }
    }
}
