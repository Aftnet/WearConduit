using MvvmCross;
using MvvmCross.ViewModels;
using WearConduit.Shared.ViewModels;

namespace WearConduit.Shared
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            var ioc = Mvx.IoCProvider;
            ioc.RegisterSingleton(Plugin.BluetoothLE.CrossBleAdapter.Current);
            RegisterAppStart<TestViewModel>();
        }
    }
}
