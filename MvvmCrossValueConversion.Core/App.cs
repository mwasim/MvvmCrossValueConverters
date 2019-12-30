using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MvvmCrossValueConversion.Core.ViewModels;

namespace MvvmCrossValueConversion.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            /*
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            */

            RegisterAppStart<HomeViewModel>();
        }
    }
}
