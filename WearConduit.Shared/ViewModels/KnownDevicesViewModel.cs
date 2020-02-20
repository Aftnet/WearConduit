using MvvmCross.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace WearConduit.Shared.ViewModels
{
    public class KnownDevicesViewModelItem : MvxViewModel
    {
        public enum States { Connected, Disconnected }

        public string Name { get; }

        private States state = States.Disconnected;

        public States State
        {
            get => state;
            private set => SetProperty(ref state, value);
        }

        public KnownDevicesViewModelItem(string name, States state)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            State = state;
        }
    }

    public class KnownDevicesViewModel : MvxViewModel
    {
        public bool NoDevices => !Devices.Any();
        public MvxObservableCollection<KnownDevicesViewModelItem> Devices { get; } = new MvxObservableCollection<KnownDevicesViewModelItem>();

        public override void Prepare()
        {
            base.Prepare();
        }
    }
}
