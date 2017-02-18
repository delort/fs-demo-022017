using Cirrious.FluentLayouts.Touch;
using Demo.Core.ViewModels;
using Demo.iOS.Helpers;
using MvvmCross.Binding.BindingContext;

namespace Demo.iOS.Views
{
    public class RasterViewController : BaseViewController<RasterViewModel>
    {
        public override string Title => iOSConstants.VIEW_CONTROLLER_RASTER_TITLE;

        MvxFluentBindingDescriptionSet<RasterViewController, RasterViewModel> _bindingSet;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            CreateViewElements();

            LayoutViewElements();

            Bind();
        }

        void CreateViewElements()
        {
        }

        void LayoutViewElements()
        {
            View.AddConstraints(new FluentLayout[]
            {
            });
        }

        void Bind()
        {
            _bindingSet = this.CreateBindingSet<RasterViewController, RasterViewModel>();

            _bindingSet.Apply();
        }
    }
}
