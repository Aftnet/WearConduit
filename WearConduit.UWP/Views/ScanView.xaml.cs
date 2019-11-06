using MvvmCross.Platforms.Uap.Views;
using MvvmCross.ViewModels;
using WearConduit.Shared.ViewModels;

namespace WearConduit.UWP.Views
{
    [MvxViewFor(typeof(ScanViewModel))]
    public sealed partial class ScanView : MvxWindowsPage
    {
        public ScanViewModel VM => ViewModel as ScanViewModel;

        public ScanView()
        {
            this.InitializeComponent();
        }

        private void ListView_ItemClick(object sender, Windows.UI.Xaml.Controls.ItemClickEventArgs e)
        {
            VM.PairDevice.Execute((DeviceViewModel)e.ClickedItem);
        }
    }
}
