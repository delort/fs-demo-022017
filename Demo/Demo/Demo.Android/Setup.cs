using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using Demo.Core;
using MvvmCross.Binding.Bindings.Target.Construction;
using Demo.Android.Helpers;
using Android.Views;
using Demo.Android.Bindings;

namespace Demo.Android
{
    public class Setup : MvxAppCompatSetup
    {
        // This is a basic MVX Setup class. It can be replaced with an advanced Setup class available in the MVX Template pack
        public Setup(Context applicationContext)
               : base(applicationContext)
        {
        }

        // CreateApp() is the only method for which an override is required in Setup, however there are many other methods that you will probably need or want to override
        // Learn more about using Setup to register custom bindings, platform services, and more at https://github.com/MvvmCross/MvvmCross/wiki/Customizing-using-App-and-Setup#setupcs
        protected override IMvxApplication CreateApp() => new App();

        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
        {
            base.FillTargetFactories(registry);

            registry.RegisterCustomBindingFactory<View>(AndroidConstants.SIZE_TARGET_BINDING_KEY, view => new ViewSizeTargetBinding(view));
        }
    }
}
