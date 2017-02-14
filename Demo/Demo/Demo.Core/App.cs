using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using Demo.Core.ViewModels;

namespace Demo.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<HomeViewModel>();
        }
    }
}
