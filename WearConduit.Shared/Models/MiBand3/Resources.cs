using System;
using System.Collections.Immutable;

namespace WearConduit.Shared.Models.MiBand3
{
    public static class Resources
    {
        //Authentication
        public static Guid GuidServiceAuth { get; } = new Guid("0000fee1-0000-1000-8000-00805f9b34fb");
        public static Guid GuidCharacteristicAuth { get; } = new Guid("00000009-0000-3512-2118-0009af100700");

        public static byte AuthResponse { get; } = 0x10;
        public static byte AuthSendKey { get; } = 0x01;
        public static byte AuthRequestRandomAuthNumber { get; } = 0x02;
        public static byte AuthSendEncryptedAuthNumber { get; } = 0x03;
        public static byte AuthSuccess { get; } = 0x01;
        public static ImmutableArray<byte> RequestNumber { get; } = ImmutableArray.Create<byte>(0x02, 0x00);

        //General Guid for device settings
        public static Guid GuidDeviceConfiguration { get; } = new Guid("00000003-0000-3512-2118-0009af100700");

        public static ImmutableArray<byte> Byte_EnableActivateOnLiftWrist { get; } = ImmutableArray.Create<byte>(0x06, 0x05, 0x00, 0x01);
        public static ImmutableArray<byte> Byte_DisableActivateOnLiftWrist { get; } = ImmutableArray.Create<byte>(0x06, 0x05, 0x00, 0x00);
        public static ImmutableArray<byte> Byte_ScheduleActivateOnLiftWrist_Template { get; } = ImmutableArray.Create<byte>(0x06, 0x05, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00);

        public static ImmutableArray<byte> Byte_SetLanguage_Template { get; } = ImmutableArray.Create<byte>(0x06, 0x17, 0x00, 0, 0, 0, 0, 0);

        public static ImmutableArray<byte> Byte_TimeFomat_24hours { get; } = ImmutableArray.Create<byte>(0x06, 0x02, 0x0, 0x1);
        public static ImmutableArray<byte> Byte_TimeFomat_12hours { get; } = ImmutableArray.Create<byte>(0x06, 0x02, 0x0, 0x0);

        public static ImmutableArray<byte> Byte_EnableGoalNotification { get; } = ImmutableArray.Create<byte>(0x06, 0x06, 0x00, 0x01);
        public static ImmutableArray<byte> Byte_DisableGoalNotification { get; } = ImmutableArray.Create<byte>(0x06, 0x06, 0x00, 0x00);

        public static ImmutableArray<byte> Byte_EnableSleepMeasurement { get; } = ImmutableArray.Create<byte>(0x15, 0x00, 0x01);
        public static ImmutableArray<byte> Byte_DisableSleepMeasurement { get; } = ImmutableArray.Create<byte>(0x15, 0x00, 0x00);

        public static ImmutableArray<byte> Byte_DateFormat_dd_MM_YYYY { get; } = ImmutableArray.Create<byte>(0x06, 30, 0x00, Convert.ToByte('d'), Convert.ToByte('d'), Convert.ToByte('/'), Convert.ToByte('M'), Convert.ToByte('M'), Convert.ToByte('/'), Convert.ToByte('y'), Convert.ToByte('y'), Convert.ToByte('y'), Convert.ToByte('y'));
        public static ImmutableArray<byte> Byte_DateFormat_MM_dd_YYYY { get; } = ImmutableArray.Create<byte>(0x06, 30, 0x00, Convert.ToByte('M'), Convert.ToByte('M'), Convert.ToByte('/'), Convert.ToByte('d'), Convert.ToByte('d'), Convert.ToByte('/'), Convert.ToByte('y'), Convert.ToByte('y'), Convert.ToByte('y'), Convert.ToByte('y'));

        //User settings
        public static Guid GuidUserInfo { get; } = new Guid("00000008-0000-3512-2118-0009af100700");

        //Battery Guid
        public static Guid GuidBatteryInfo { get; } = new Guid("00000006-0000-3512-2118-0009af100700");

        //Current Time Guid
        public static Guid GuidCurrentTime { get; } = new Guid("00002A2B-0000-1000-8000-00805f9b34fb");

        //Heartrate Control Point Guid
        public static Guid GuidHeartRateControl { get; } = new Guid("00002A39-0000-1000-8000-00805f9b34fb");

        //Heartrate Realtime Guid
        public static Guid GuidHeartrate { get; } = new Guid("00002A37-0000-1000-8000-00805f9b34fb");

        //Request & get samples
        public static Guid GuidSamplesRequest { get; } = new Guid("00000004-0000-3512-2118-0009af100700");
        public static Guid GuidActivityData { get; } = new Guid("00000005-0000-3512-2118-0009af100700");

        public static byte Response { get; } = 0x10;
        public static byte CommandActivityDataStartDate { get; } = 0x01;
        public static byte Success { get; } = 0x01;

        public static ImmutableArray<byte> ResponseActivityDataStartDateSuccess { get; } = ImmutableArray.Create<byte>(Response, CommandActivityDataStartDate, Success);

        //Steps Realtime Guid
        public static Guid GuidStepsInfo { get; } = new Guid("00000007-0000-3512-2118-0009af100700");
    }
}
