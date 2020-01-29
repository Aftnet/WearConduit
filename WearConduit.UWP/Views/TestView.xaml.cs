using MvvmCross.Platforms.Uap.Views;
using MvvmCross.ViewModels;
using WearConduit.Shared.ViewModels;

namespace WearConduit.UWP.Views
{
    [MvxViewFor(typeof(TestViewModel))]
    public sealed partial class TestView : MvxWindowsPage
    {
        public TestViewModel VM => ViewModel as TestViewModel;

        public TestView()
        {
            this.InitializeComponent();
        }
    }
}
