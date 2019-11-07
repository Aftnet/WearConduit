using MvvmCross.Commands;
using MvvmCross.ViewModels;
using Plugin.BluetoothLE;
using System;
using System.Collections.Generic;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace WearConduit.Shared.ViewModels
{
    public class ScanViewModel : MvxViewModel
    {
        private IAdapter Adapter { get; }
        private HashSet<Guid> ScannedUids { get; } = new HashSet<Guid>();

        public MvxObservableCollection<DeviceViewModel> Devices { get; } = new MvxObservableCollection<DeviceViewModel>();

        public IMvxCommand<DeviceViewModel> PairDevice { get; }

        public ScanViewModel(IAdapter adapter)
        {
            Adapter = adapter ?? throw new ArgumentNullException(nameof(adapter));

            PairDevice = new MvxCommand<DeviceViewModel>(async d =>
            {
                Adapter.StopScan();
                d.Device.Connect();
                var services = await d.Device.DiscoverServices().AsQbservable().ToArray();

            });
        }

        public override void ViewAppeared()
        {
            Adapter.Scan(new ScanConfig { ScanType = BleScanType.LowLatency }).ObserveOn(CurrentThreadScheduler.Instance).Subscribe(d =>
            {
                var device = d.Device;
                if (ScannedUids.Contains(device.Uuid) || !device.Name.Contains("Band"))
                {
                    return;
                }

                ScannedUids.Add(device.Uuid);
                Devices.Add(new DeviceViewModel(device));
            });
        }

        public override void ViewDisappearing()
        {
            Adapter.StopScan();
        }
    }
}
