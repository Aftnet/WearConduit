using MvvmCross.ViewModels;
using Plugin.BluetoothLE;
using System;
using System.Reactive.Linq;

namespace WearConduit.Shared.ViewModels
{
    public class TestViewModel : MvxViewModel
    {
        private Guid BandUID { get; } = new Guid("00000000-0000-0000-0000-e3129364c7d7");
        private IAdapter Adapter { get; }

        public TestViewModel(IAdapter adapter)
        {
            Adapter = adapter ?? throw new ArgumentNullException(nameof(adapter));
        }

        public override async void ViewAppeared()
        {
            var device = await Adapter.GetKnownDevice(BandUID).FirstOrDefaultAsync();
            if (device.IsPairingAvailable())
            {
                var success = await device.PairingRequest().FirstAsync();
            }

            device.Connect();
            await Models.MiBand3.Authentication.AuthenticateAsync(device);
        }
    }
}
