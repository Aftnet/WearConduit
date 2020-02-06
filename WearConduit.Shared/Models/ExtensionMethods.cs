using Plugin.BluetoothLE;
using System;
using System.Collections.Immutable;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace WearConduit.Shared.Models
{
    internal static class ExtensionMethods
    {
        public static Task<IGattCharacteristic> GetCharacteristicAsync(this IDevice device, Guid serviceID, Guid characteristicID)
        {
            var tcs = new TaskCompletionSource<IGattCharacteristic>();
            var disposable = default(IDisposable);
            disposable = device.GetKnownCharacteristics(serviceID, new Guid[] { characteristicID }).Subscribe(d =>
            {
                disposable.Dispose();
                tcs.SetResult(d);
            }, e =>
            {
                disposable.Dispose();
                tcs.SetResult(null);
            });

            return tcs.Task;
        }

        public static Task<bool> WriteCharacteristic(this IDevice device, Guid serviceID, Guid characteristicID, byte[] payload)
        {
            var tcs = new TaskCompletionSource<bool>();
            GetCharacteristicAsync(device, serviceID, characteristicID).ContinueWith(d =>
            {
                var characteristic = d.Result;
                if (characteristic == null)
                {
                    tcs.SetResult(false);
                    return;
                }

                var disposable = default(IDisposable);
                disposable = characteristic.Write(payload).Subscribe(e =>
                {
                    disposable.Dispose();
                    tcs.SetResult(true);
                    return;
                },
                f =>
                {
                    disposable.Dispose();
                    tcs.SetResult(false);
                    return;
                });
            });

            return tcs.Task;
        }

        public static async Task<bool> WriteCharacteristicWithoutResponse(this IDevice device, Guid serviceID, Guid characteristicID, byte[] payload)
        {
            var characteristic = await GetCharacteristicAsync(device, serviceID, characteristicID);
            if (characteristic == null)
            {
                return false;
            }

            await characteristic.WriteWithoutResponse(payload);
            return true;
        }

        public static T[] GetArrayCopy<T>(this ImmutableArray<T> source)
        {
            var output = new T[source.Length];
            source.CopyTo(output);
            return output;
        }
    }
}
