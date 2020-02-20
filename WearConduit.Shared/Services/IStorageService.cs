using LiteDB;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WearConduit.Shared.Services
{
    public class ManagedDevice
    {
        [BsonId]
        public Guid ID { get; set; }
        public DateTime Added { get; set; }
        public byte[] SecurityData { get; set; }
    }

    public interface IStorageService
    {
        Task AddManagedDeviceAsync(Guid ID, byte[] SecurityData = null);
        Task<List<ManagedDevice>> GetManagedDevicesAsync();
        Task<bool> RemoveManagedDeviceAsync(Guid ID);
    }
}