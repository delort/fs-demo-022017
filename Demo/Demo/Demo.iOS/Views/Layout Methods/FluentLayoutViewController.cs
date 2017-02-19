using System;
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

        MvxFluentBindingDescriptionSet<FluentLayoutViewController, FluentLayoutViewModel> _bindingSet;
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

            _topLeftLabel = CreateLabel("Top Left", UIColor.Black);
            _topCentreLabel = CreateLabel("Top Centre", UIColor.White);
            _topRightLabel = CreateLabel("Top Right", UIColor.White);
            _middleLeftLabel = CreateLabel("Middle Left", UIColor.White);
            _middleCentreLabel = CreateLabel("Middle Centre", UIColor.White);
            _middleRightLabel = CreateLabel("Middle Right", UIColor.Black);
            _bottomLeftLabel = CreateLabel("Bottom Left", UIColor.Black);
            _bottomCentreLabel = CreateLabel("Bottom Centre", UIColor.Black);
            _bottomRightLabel = CreateLabel("Bottom Right", UIColor.White);

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

        void LayoutViewElements()
        {
            AddCenterInsideConstraints(_topLeftView, _topLeftLabel);
            AddCenterInsideConstraints(_topCentreView, _topCentreLabel);
            AddCenterInsideConstraints(_topRightView, _topRightLabel);
            AddCenterInsideConstraints(_middleLeftView, _middleLeftLabel);
            AddCenterInsideConstraints(_middleCentreView, _middleCentreLabel);
            AddCenterInsideConstraints(_middleRightView, _middleRightLabel);
            AddCenterInsideConstraints(_bottomLeftView, _bottomLeftLabel);
            AddCenterInsideConstraints(_bottomCentreView, _bottomCentreLabel);
            AddCenterInsideConstraints(_bottomRightView, _bottomRightLabel);

            View.AddConstraints(new FluentLayout[]
            {
                _topLeftView.AtTopOf(View),
                _topLeftView.AtLeftOf(View),
                _topLeftView.WithSameHeight(View).WithMultiplier(1f / 3f),
                _topLeftView.WithSameWidth(View).WithMultiplier(1f / 3f),

                _topCentreView.AtTopOf(View),
                _topCentreView.ToRightOf(_topLeftView),
                _topCentreView.WithSameHeight(View).WithMultiplier(1f / 3f),
                _topCentreView.WithSameWidth(View).WithMultiplier(1f / 3f),

                _topRightView.AtTopOf(View),
                _topRightView.ToRightOf(_topCentreView),
                _topRightView.WithSameHeight(View).WithMultiplier(1f / 3f),
                _topRightView.WithSameWidth(View).WithMultiplier(1f / 3f),

                _middleLeftView.Below(_topLeftView),
                _middleLeftView.AtLeftOf(View),
                _middleLeftView.WithSameHeight(View).WithMultiplier(1f / 3f),
                _middleLeftView.WithSameWidth(View).WithMultiplier(1f / 3f),

                _middleCentreView.Below(_topCentreView),
                _middleCentreView.ToRightOf(_middleLeftView),
                _middleCentreView.WithSameHeight(View).WithMultiplier(1f / 3f),
                _middleCentreView.WithSameWidth(View).WithMultiplier(1f / 3f),

                _middleRightView.Below(_topRightView),
                _middleRightView.ToRightOf(_middleCentreView),
                _middleRightView.WithSameHeight(View).WithMultiplier(1f / 3f),
                _middleRightView.WithSameWidth(View).WithMultiplier(1f / 3f),

                _bottomLeftView.Below(_middleLeftView),
                _bottomLeftView.AtLeftOf(View),
                _bottomLeftView.WithSameHeight(View).WithMultiplier(1f / 3f),
                _bottomLeftView.WithSameWidth(View).WithMultiplier(1f / 3f),

                _bottomCentreView.Below(_middleCentreView),
                _bottomCentreView.ToRightOf(_bottomLeftView),
                _bottomCentreView.WithSameHeight(View).WithMultiplier(1f / 3f),
                _bottomCentreView.WithSameWidth(View).WithMultiplier(1f / 3f),

                _bottomRightView.Below(_middleRightView),
                _bottomRightView.ToRightOf(_bottomCentreView),
                _bottomRightView.WithSameHeight(View).WithMultiplier(1f / 3f),
                _bottomRightView.WithSameWidth(View).WithMultiplier(1f / 3f),
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
                Font = UIFont.FromName(iOSConstants.FONT_HELVETICA_NEUE, iOSConstants.FONT_MEDIUM),
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
                child.WithSameCenterY(parent)
            });
        }
    }
}
