using System;
using MvvmCross.Binding;
using MvvmCross.Binding.Bindings.Target;
using UIKit;

namespace Demo.iOS.Bindings
{
    // For more information on custom bindings, see:
    // https://mvvmcross.com/docs/customize-app#section-registering-custom-bindings
    // http://slodge.blogspot.co.za/2013/06/n28-custom-bindings-n1-days-of-mvvmcross.html
    public class ViewSizeTargetBinding : MvxConvertingTargetBinding
    {
        public ViewSizeTargetBinding(UIView target) : base(target)
        {
        }

        public override Type TargetType => typeof(UIView);

        // For more information on the different binding mode options see:
        // https://mvvmcross.com/docs/data-binding#section-binding-modes
        public override MvxBindingMode DefaultMode => MvxBindingMode.OneWay;

        protected override void SetValueImpl(object target, object value)
        {
            var thisTarget = target as UIView;

            if (target == null)
                return;

            var size = (int)value;

            var frame = thisTarget.Frame;

            frame.Height = size;
            frame.Width = size;

            thisTarget.Frame = frame;
        }
    }
}
