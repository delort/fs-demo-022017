using Cirrious.FluentLayouts.Touch;
using Demo.Core.ViewModels;
using Demo.iOS.Helpers;
using MvvmCross.Binding.BindingContext;

namespace Demo.iOS.Views
{
    public class VectorViewController : BaseViewController<VectorViewModel>
    {
        public override string Title => iOSConstants.VIEW_CONTROLLER_VECTOR_TITLE;

        MvxFluentBindingDescriptionSet<VectorViewController, VectorViewModel> _bindingSet;

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
            _bindingSet = this.CreateBindingSet<VectorViewController, VectorViewModel>();

            _bindingSet.Apply();
        }
    }
}
