using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using WearConduit.Shared.Services;
using Xunit;

namespace WearConduit.Shared.Test.Services
{
    public class StorageServiceTest : TestBase<StorageService>
    {
        protected internal override StorageService InstantiateTarget() => new StorageService();

        private FileInfo DBFile { get; }

        public StorageServiceTest()
        {
            DBFile = new FileInfo("TestDB.db");

            if (DBFile.Exists)
            {
                DBFile.Delete();
            }
        }

        [Fact]
        public async Task StorageWorks()
        {
            var result = await Target.GetManagedDevicesAsync();
            Assert.Empty(result);

            var testGUID = Guid.NewGuid();
            var testData = new byte[8];
            new Random().NextBytes(testData);
            await Target.AddManagedDeviceAsync(testGUID, testData);
            result = await Target.GetManagedDevicesAsync();
            Assert.NotEmpty(result);

            await Target.RemoveManagedDeviceAsync(testGUID);
            result = await Target.GetManagedDevicesAsync();
            Assert.Empty(result);
        }
    }
}
