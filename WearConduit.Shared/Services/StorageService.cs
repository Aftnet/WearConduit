using LiteDB;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WearConduit.Shared.Services
{
    public class StorageService : IStorageService
    {
        private LiteRepository Store { get; }

        public StorageService(string connectionString = null)
        {
            Store = new LiteRepository(connectionString ?? "Store.db");
        }

        public Task<List<ManagedDevice>> GetManagedDevicesAsync()
        {
            return Task.Run(() => Store.Query<ManagedDevice>().ToList());
        }

        public Task AddManagedDeviceAsync(Guid ID, byte[] SecurityData = null)
        {
            return Task.Run(() => Store.Upsert<ManagedDevice>(new ManagedDevice
            {
                ID = ID,
                SecurityData = SecurityData,
                Added = DateTime.UtcNow
            }));
        }

        public Task<bool> RemoveManagedDeviceAsync(Guid ID)
        {
            return Task.Run(() => Store.Delete<ManagedDevice>(ID));
        }
    }
}
