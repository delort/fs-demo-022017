using System;
using Cirrious.FluentLayouts.Touch;
using Demo.Core.ViewModels;
using Demo.iOS.Helpers;
using MvvmCross.iOS.Views;

namespace Demo.iOS.Views
{
    [MvxFromStoryboard(StoryboardName = "DemoStoryboard")]
    public partial class StoryboardView : MvxViewController
    {
        public StoryboardView(IntPtr handle) : base(handle) { }
    }
}
