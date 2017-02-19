using Demo.Core;
using Demo.iOS.Bindings;
using Demo.iOS.Helpers;
using Demo.Plugin.AlertDialog;
using Demo.Plugin.AlertDialog.iOS;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.Platform;
using UIKit;

namespace Demo.iOS
{
    public class Setup : MvxIosSetup
    {
        // This is a basic MVX Setup class. It can be replaced with an advanced Setup class available in the MVX Template pack
        public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }

        // CreateApp() is the only method for which an override is required in Setup, however there are many other methods that you will probably need or want to override
        // Learn more about using Setup to register custom bindings, platform services, and more at https://github.com/MvvmCross/MvvmCross/wiki/Customizing-using-App-and-Setup#setupcs
        protected override IMvxApplication CreateApp() => new App();

        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
        {
            base.FillTargetFactories(registry);

            registry.RegisterCustomBindingFactory<UIView>(iOSConstants.SIZE_TARGET_BINDING_KEY, view => new ViewSizeTargetBinding(view));
        }
    }
}
