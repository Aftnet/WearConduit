using MvvmCross.Platforms.Uap.Core;
using MvvmCross.Platforms.Uap.Views;

namespace WearConduit.UWP
{
    sealed partial class App
    {
        public App()
        {
            InitializeComponent();
        }
    }

    public abstract class WearConduitApp : MvxApplication<MvxWindowsSetup<Shared.App>, Shared.App>
    {
    }
}