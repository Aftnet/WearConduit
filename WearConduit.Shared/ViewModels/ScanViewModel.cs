using MvvmCross.ViewModels;
using Plugin.BluetoothLE;
using System;
using System.Collections.Generic;

namespace WearConduit.Shared.ViewModels
{
    public class ScanViewModel : MvxViewModel
    {
        private IAdapter Adapter { get; }
        private HashSet<Guid> ScannedUids { get; } = new HashSet<Guid>();

        public MvxObservableCollection<DeviceViewModel> Devices { get; } = new MvxObservableCollection<DeviceViewModel>();

        public ScanViewModel(IAdapter adapter)
        {
            Adapter = adapter ?? throw new ArgumentNullException(nameof(adapter));
        }

        public override void ViewAppeared()
        {
            Adapter.Scan().Subscribe(d =>
            {
                var device = d.Device;
                lock(ScannedUids)
                {
                    if (ScannedUids.Contains(device.Uuid))
                    {
                        return;
                    }

                    ScannedUids.Add(device.Uuid);
                }

                Devices.Add(new DeviceViewModel(device));
            });
        }

        public override void ViewDisappearing()
        {
            Adapter.StopScan();
        }
    }
}
