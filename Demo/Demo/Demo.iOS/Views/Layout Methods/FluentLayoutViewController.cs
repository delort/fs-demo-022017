using Cirrious.FluentLayouts.Touch;
using Demo.Core.ViewModels;
using Demo.iOS.Helpers;
using MvvmCross.Binding.BindingContext;
using UIKit;

namespace Demo.iOS.Views
{
    public class FluentLayoutViewController : BaseViewController<FluentLayoutViewModel>
    {
        public override string Title => iOSConstants.VIEW_CONTROLLER_FLUENTLAYOUT_TITLE;
        
        UIView _topLeftView, _topCentreView, _topRightView, _middleLeftView, _middleCentreView, _middleRightView, _bottomLeftView, _bottomCentreView, _bottomRightView;
        UILabel _topLeftLabel, _topCentreLabel, _topRightLabel, _middleLeftLabel, _middleCentreLabel, _middleRightLabel, _bottomLeftLabel, _bottomCentreLabel, _bottomRightLabel;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            CreateViewElements();

            LayoutViewElements();
        }

        void CreateViewElements()
        {
            _topLeftView = CreateEmptyView(UIColor.Yellow);
            _topCentreView = CreateEmptyView(UIColor.Red);
            _topRightView = CreateEmptyView(UIColor.Purple);
            _middleLeftView = CreateEmptyView(UIColor.Black);
            _middleCentreView = CreateEmptyView(UIColor.Blue);
            _middleRightView = CreateEmptyView(UIColor.Green);
            _bottomLeftView = CreateEmptyView(UIColor.Cyan);
            _bottomCentreView = CreateEmptyView(UIColor.Orange);
            _bottomRightView = CreateEmptyView(UIColor.Brown);

            _topLeftLabel = CreateLabel("Height and width relative to superview", UIColor.Black);
            _topCentreLabel = CreateLabel("Height and width relative to superview", UIColor.White);
            _topRightLabel = CreateLabel("Height and width inferred from siblings", UIColor.White);
            _middleLeftLabel = CreateLabel("Height inferred from siblings, width relative to superview", UIColor.White);
            _middleCentreLabel = CreateLabel("Height inferred from siblings, width relative to superview", UIColor.White);
            _middleRightLabel = CreateLabel("Height and width inferred from siblings", UIColor.Black);
            _bottomLeftLabel = CreateLabel("Height and width relative to superview", UIColor.Black);
            _bottomCentreLabel = CreateLabel("Height inferred from siblings, width relative to superview", UIColor.Black);
            _bottomRightLabel = CreateLabel("Height and width inferred from siblings", UIColor.White);

            _topLeftView.Add(_topLeftLabel);
            _topCentreView.Add(_topCentreLabel);
            _topRightView.Add(_topRightLabel);
            _middleLeftView.Add(_middleLeftLabel);
            _middleCentreView.Add(_middleCentreLabel);
            _middleRightView.Add(_middleRightLabel);
            _bottomLeftView.Add(_bottomLeftLabel);
            _bottomCentreView.Add(_bottomCentreLabel);
            _bottomRightView.Add(_bottomRightLabel);

            View.AddSubviews(_topLeftView, _topCentreView, _topRightView, _middleLeftView, _middleCentreView, _middleRightView, _bottomLeftView, _bottomCentreView, _bottomRightView);
        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();

            // These constraints rely on other constraints having previously been applied, so we use ViewDidLayoutSubviews()
            AddCenterInsideConstraints(_topLeftView, _topLeftLabel);
            AddCenterInsideConstraints(_topCentreView, _topCentreLabel);
            AddCenterInsideConstraints(_topRightView, _topRightLabel);
            AddCenterInsideConstraints(_middleLeftView, _middleLeftLabel);
            AddCenterInsideConstraints(_middleCentreView, _middleCentreLabel);
            AddCenterInsideConstraints(_middleRightView, _middleRightLabel);
            AddCenterInsideConstraints(_bottomLeftView, _bottomLeftLabel);
            AddCenterInsideConstraints(_bottomCentreView, _bottomCentreLabel);
            AddCenterInsideConstraints(_bottomRightView, _bottomRightLabel);
        }

        void LayoutViewElements()
        {
            var oneThirdMultiplier = 1f / 3f;
            var halfContentPadding = iOSConstants.CONTENT_PADDING / 2f;
            var halfSidePadding = iOSConstants.SIDE_PADDING / 2f;

            View.AddConstraints(new FluentLayout[]
            {
                _topLeftView.AtTopOf(View, iOSConstants.CONTENT_PADDING),
                _topLeftView.AtLeftOf(View, iOSConstants.SIDE_PADDING),
                _topLeftView.WithSameHeight(View).WithMultiplier(0.5f).Minus(iOSConstants.CONTENT_PADDING),
                _topLeftView.WithSameWidth(View).WithMultiplier(oneThirdMultiplier).Minus(iOSConstants.SIDE_PADDING),

                _topCentreView.AtTopOf(View, iOSConstants.CONTENT_PADDING),
                _topCentreView.ToRightOf(_topLeftView, halfSidePadding),
                _topCentreView.WithSameHeight(View).WithMultiplier(oneThirdMultiplier).Minus(iOSConstants.CONTENT_PADDING),
                _topCentreView.WithSameWidth(View).WithMultiplier(0.5f).Minus(iOSConstants.SIDE_PADDING),

                _topRightView.AtTopOf(View, iOSConstants.CONTENT_PADDING),
                _topRightView.ToRightOf(_topCentreView, halfSidePadding),
                _topRightView.AtRightOf(View, iOSConstants.SIDE_PADDING),
                _topRightView.WithSameHeight(_topCentreView),

                _middleLeftView.Below(_topLeftView, halfContentPadding),
                _middleLeftView.AtLeftOf(View, iOSConstants.SIDE_PADDING),
                _middleLeftView.WithSameWidth(View).WithMultiplier(oneThirdMultiplier).Minus(iOSConstants.SIDE_PADDING),

                _middleCentreView.Below(_topCentreView, halfContentPadding),
                _middleCentreView.ToRightOf(_middleLeftView, halfSidePadding),
                _middleCentreView.WithSameBottom(_middleLeftView),
                _middleCentreView.WithSameWidth(View).WithMultiplier(oneThirdMultiplier).Minus(iOSConstants.SIDE_PADDING),

                _middleRightView.Below(_topRightView, halfContentPadding),
                _middleRightView.ToRightOf(_middleCentreView, halfSidePadding),
                _middleRightView.AtRightOf(View, iOSConstants.SIDE_PADDING),
                _middleRightView.WithSameHeight(_middleCentreView),

                _bottomLeftView.Below(_middleLeftView, halfContentPadding),
                _bottomLeftView.AtBottomOf(View, iOSConstants.CONTENT_PADDING),
                _bottomLeftView.AtLeftOf(View, iOSConstants.SIDE_PADDING),
                _bottomLeftView.WithSameHeight(View).WithMultiplier(oneThirdMultiplier).Minus(iOSConstants.CONTENT_PADDING),
                _bottomLeftView.WithSameWidth(View).WithMultiplier(0.5f).Minus(iOSConstants.SIDE_PADDING),

                _bottomCentreView.Below(_middleCentreView, halfContentPadding),
                _bottomCentreView.AtBottomOf(View, iOSConstants.CONTENT_PADDING),
                _bottomCentreView.ToRightOf(_bottomLeftView, halfSidePadding),
                _bottomCentreView.WithSameHeight(_bottomLeftView),
                _bottomCentreView.WithSameWidth(View).WithMultiplier(oneThirdMultiplier).Minus(iOSConstants.SIDE_PADDING),

                _bottomRightView.Below(_middleRightView, halfContentPadding),
                _bottomRightView.AtBottomOf(View, iOSConstants.CONTENT_PADDING),
                _bottomRightView.ToRightOf(_bottomCentreView, halfSidePadding),
                _bottomRightView.AtRightOf(View, iOSConstants.SIDE_PADDING),
                _bottomRightView.WithSameHeight(_bottomLeftView)
            });
        }

        static UIView CreateEmptyView(UIColor colour)
        {
            var view = new UIView
            {
                BackgroundColor = colour,
                TranslatesAutoresizingMaskIntoConstraints = false
            };

            view.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();

            return view;
        }

        static UILabel CreateLabel(string labelText, UIColor textColour)
        {
            return new UILabel
            {
                Text = labelText,
                TextColor = textColour,
                Font = UIFont.FromName(iOSConstants.FONT_HELVETICA_NEUE, iOSConstants.FONT_SMALL),
                Lines = 0,
                LineBreakMode = UILineBreakMode.WordWrap,
                TranslatesAutoresizingMaskIntoConstraints = false
            };
        }

        static void AddCenterInsideConstraints(UIView parent, UIView child)
        {
            parent.AddConstraints(new FluentLayout[]
            {
                child.WithSameCenterX(parent),
                child.WithSameCenterY(parent),
                child.Width().LessThanOrEqualTo(parent.Bounds.Width - iOSConstants.INTERNAL_PADDING * 2)
            });
        }
    }
}
