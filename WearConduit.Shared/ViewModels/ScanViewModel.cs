using MvvmCross.ViewModels;
using Plugin.BLE.Abstractions.Contracts;
using System;

namespace WearConduit.Shared.ViewModels
{
    public class ScanViewModel : MvxViewModel
    {
        private IAdapter Adapter { get; }
        public MvxObservableCollection<DeviceViewModel> Devices { get; } = new MvxObservableCollection<DeviceViewModel>();

        public ScanViewModel(IAdapter adapter)
        {
            Adapter = adapter ?? throw new ArgumentNullException(nameof(adapter));

            Adapter.ScanMode = ScanMode.LowLatency;
            Adapter.ScanTimeout = 10;
            Adapter.DeviceDiscovered += Adapter_DeviceDiscovered;
        }

        private void Adapter_DeviceDiscovered(object sender, Plugin.BLE.Abstractions.EventArgs.DeviceEventArgs e)
        {
            Devices.Add(new DeviceViewModel(e.Device));
        }

        public override void ViewAppeared()
        {
            Adapter.StartScanningForDevicesAsync();
        }

        public override void ViewDisappearing()
        {
            Adapter.StopScanningForDevicesAsync();
        }
    }
}
