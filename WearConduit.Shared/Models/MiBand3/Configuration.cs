using Plugin.BluetoothLE;
using System;
using System.Text;
using System.Threading.Tasks;

namespace WearConduit.Shared.Models.MiBand3
{
    internal static class Configuration
    {
        public static Task<bool> SetTimeAsync(IDevice device, DateTime time)
        {
            var payload = ConversionHelper.GetTimeBytes(time, ConversionHelper.TimeUnit.Seconds);
            return device.WriteCharacteristic(Resources.GuidServiceConfiguration, Resources.GuidCurrentTime, payload);
        }

        /// <summary>
        /// Sets the language of the Mi Band to the given language. String has to be in format en-EN. If language is not supported nothing will happen
        /// </summary>
        /// <param name="localeString"></param>
        public static Task<bool> SetLanguageAsync(IDevice device, string localeString)
        {
            var payload = new byte[Resources.PayloadTemplateSetLanguage.Length];
            Resources.PayloadTemplateSetLanguage.CopyTo(payload);
            Buffer.BlockCopy(Encoding.ASCII.GetBytes(localeString), 0, payload, 3, Encoding.ASCII.GetBytes(localeString).Length);
            return device.WriteCharacteristicWithoutResponse(Resources.GuidServiceConfiguration, Resources.GuidCharacteristicConfiguration, payload);
        }

        /// <summary>
        /// Set the Mi Bands time unit to either 24 hours when true or 12 hours when false
        /// </summary>
        /// <param name="is24format"></param>
        public static Task<bool> SetTimeDisplayUnit(IDevice device, bool is24format)
        {
            var payload = is24format ? Resources.PayloadSetTimeFormat24h.GetArrayCopy() : Resources.PayloadSetTimeFormat12h.GetArrayCopy();
            return device.WriteCharacteristicWithoutResponse(Resources.GuidServiceConfiguration, Resources.GuidCharacteristicConfiguration, payload);
        }

        /// <summary>
        /// Set the Mi Bands Date format to either dd/MM/YYYY if true or MM/dd/YYYY if false
        /// </summary>
        /// <param name="isdMY"></param>
        public static Task<bool> SetDateDisplayUnit(IDevice device, bool isdMY)
        {
            var payload = isdMY ? Resources.PayloadDateFormatDDMMYYYY.GetArrayCopy() : Resources.PayloadDateFormatMMDDYYYY.GetArrayCopy();
            return device.WriteCharacteristicWithoutResponse(Resources.GuidServiceConfiguration, Resources.GuidCharacteristicConfiguration, payload);
        }

        /// <summary>
        /// Set the step target on the Mi Band. Max value of 2 bytes (around 65.000)
        /// </summary>
        /// <param name="goal"></param>
        public static Task<bool> SetStepGoal(IDevice device, int goal)
        {
            var beginCommand = new byte[] { 0x10, 0x0, 0x0 };
            var endCommand = new byte[] { 0, 0 };
            var goalBytes = BitConverter.GetBytes((ushort)goal);

            var payload = new byte[beginCommand.Length + endCommand.Length + goalBytes.Length];

            Buffer.BlockCopy(beginCommand, 0, payload, 0, beginCommand.Length);
            Buffer.BlockCopy(goalBytes, 0, payload, beginCommand.Length, goalBytes.Length);
            Buffer.BlockCopy(endCommand, 0, payload, beginCommand.Length + goalBytes.Length, endCommand.Length);

            return device.WriteCharacteristicWithoutResponse(Resources.GuidServiceConfiguration, Resources.GuidCharacteristicConfiguration, payload);
        }

        public static Task<bool> EnableStepGoalNotification(IDevice device, bool enable)
        {
            var payload = enable ? Resources.PayloadEnableGoalNotification.GetArrayCopy() : Resources.PayloadDisableGoalNotification.GetArrayCopy();
            return device.WriteCharacteristicWithoutResponse(Resources.GuidServiceConfiguration, Resources.GuidCharacteristicConfiguration, payload);
        }

        /// <summary>
        /// Set permanent activate on wrist lift. true for enable. false for disable
        /// </summary>
        /// <param name="activate"></param>
        public static Task<bool> SetActivateOnWristLift(IDevice device, bool activate)
        {
            var payload = activate ? Resources.PayloadEnableActivateOnLiftWrist.GetArrayCopy() : Resources.PayloadDisableActivateOnLiftWrist.GetArrayCopy();
            return device.WriteCharacteristicWithoutResponse(Resources.GuidServiceConfiguration, Resources.GuidCharacteristicConfiguration, payload);
        }

        /// <summary>
        /// Set the activate display on lift wrist only to be active between the two given times. Date's dont matter
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public static Task<bool> SetActivateOnWristLift(IDevice device, DateTime from, DateTime to)
        {
            var payload = Resources.PayloadTemplateScheduleActivateOnLiftWrist.GetArrayCopy();

            payload[4] = Convert.ToByte(from.Hour);
            payload[5] = Convert.ToByte(from.Minute);

            payload[6] = Convert.ToByte(to.Hour);
            payload[7] = Convert.ToByte(to.Minute);

            return device.WriteCharacteristicWithoutResponse(Resources.GuidServiceConfiguration, Resources.GuidCharacteristicConfiguration, payload);
        }

        /// <summary>
        /// Enable or Disable the sleep measurement of the devices
        /// </summary>
        /// <param name="enable"></param>
        public static Task<bool> EnableSleepTracking(IDevice device, bool enable)
        {
            var payload = enable ? Resources.PayloadEnableSleepMeasurement.GetArrayCopy() : Resources.PayloadDisableSleepMeasurement.GetArrayCopy();
            return device.WriteCharacteristicWithoutResponse(Resources.GuidServiceConfiguration, Resources.GuidCharacteristicConfiguration, payload);
        }
    }
}
