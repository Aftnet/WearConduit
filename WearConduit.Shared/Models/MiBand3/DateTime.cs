using System;
using System.Collections.Generic;
using System.Text;

namespace WearConduit.Shared.Models.MiBand3
{
    class DateTime
    {
        public void SetTime(DateTime time)
        {
            //Convert time to bytes
            byte[] timeToSet = ConversionHelper.GetTimeBytes(time, ConversionHelper.TimeUnit.Seconds);

            //Send to MiBand
            _miBand3.GetCharacteristic(MiBand3Resource.GuidCurrentTime).Write(timeToSet).Subscribe(result =>
            {
                Console.WriteLine("Time set to " + time.ToString());
            });
        }
    }
}
