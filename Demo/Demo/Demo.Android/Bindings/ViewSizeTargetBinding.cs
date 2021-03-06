using System;
using Android.Views;
using MvvmCross.Binding;
using MvvmCross.Binding.Bindings.Target;

namespace Demo.Android.Bindings
{
    // For more information on custom bindings, see:
    // https://mvvmcross.com/docs/customize-app#section-registering-custom-bindings
    // http://slodge.blogspot.co.za/2013/06/n28-custom-bindings-n1-days-of-mvvmcross.html
    public class ViewSizeTargetBinding : MvxConvertingTargetBinding
    {
        public ViewSizeTargetBinding(View target) : base(target)
        {
        }

        public override Type TargetType => typeof(View);

        // For more information on the different binding mode options see:
        // https://mvvmcross.com/docs/data-binding#section-binding-modes
        public override MvxBindingMode DefaultMode => MvxBindingMode.OneWay;

        protected override void SetValueImpl(object target, object value)
        {
            var thisTarget = target as View;

            if (target == null)
                return;

            var size = (int)value;

            var layoutParameters = thisTarget.LayoutParameters;

            layoutParameters.Height = size;
            layoutParameters.Width = size;

            thisTarget.LayoutParameters = layoutParameters;
        }
    }
}
