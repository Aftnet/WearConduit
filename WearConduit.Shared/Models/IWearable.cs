using Plugin.BluetoothLE;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace WearConduit.Shared
{
    public interface IWearable
    {
        IDevice Device { get; }

        Task<bool> PairAsync();
        Task<bool> UnairAsync();

        Task<bool> SetTimeAsync(DateTime dateTime);
        Task<bool> SetLocaleAsync(CultureInfo culture);

        Task<bool> SendNotificationAsync(string message);
    }
}
