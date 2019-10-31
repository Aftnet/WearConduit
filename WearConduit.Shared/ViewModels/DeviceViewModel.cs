using Plugin.BluetoothLE;
using System;

namespace WearConduit.Shared.ViewModels
{
    public class DeviceViewModel
    {
        private IDevice Device { get; }
        public Guid ID => Device.Uuid;
        public string Name => Device.Name;

        public DeviceViewModel(IDevice device)
        {
            Device = device ?? throw new ArgumentNullException(nameof(device));
        }
    }
}
