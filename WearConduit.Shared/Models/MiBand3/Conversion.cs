﻿using System;

namespace WearConduit.Shared.Models.MiBand3
{
    internal static class ConversionHelper
    {
        public enum TimeUnit { Seconds, Days, Hours, Minutes, Unknown = -1 }

        public static byte[] ShortDateTimeToRawBytes(DateTime dateTime)
        {
            byte[] year = FromUint16(dateTime.Year);
            return new[] {
                year[0],
                year[1],
                FromUint8(dateTime.Month),
                FromUint8(dateTime.Day),
                FromUint8(dateTime.Hour),
                FromUint8(dateTime.Minute)
            };
        }

        public static byte[] DateTimeToRawBytes(DateTime dateTime)
        {
            byte[] year = FromUint16(dateTime.Year);
            return new[] {
                year[0],
                year[1],
                FromUint8(dateTime.Month),
                FromUint8(dateTime.Day),
                FromUint8(dateTime.Hour),
                FromUint8(dateTime.Minute),
                FromUint8(dateTime.Second),
                DayOfWeekToRawBytes(dateTime),
                (byte) 0
            };
        }

        public static byte[] GetTimeBytes(DateTime dateTime, TimeUnit precision)
        {
            byte[] bytes;
            if (precision == TimeUnit.Minutes)
            {
                bytes = ShortDateTimeToRawBytes(dateTime);
            }
            else if (precision == TimeUnit.Seconds)
            {
                bytes = DateTimeToRawBytes(dateTime);
            }
            else
            {
                throw new ArgumentException();
            }

            byte[] all = new byte[bytes.Length + 2];
            Buffer.BlockCopy(bytes, 0, all, 0, bytes.Length);
            Buffer.BlockCopy(new byte[] { 0, 4 }, 0, all, bytes.Length, 2);

            return all;
        }

        private static byte DayOfWeekToRawBytes(DateTime dateTime)
        {
            int dayValue = (int)dateTime.DayOfWeek;
            if (dateTime.DayOfWeek == DayOfWeek.Saturday)
            {
                return 7;
            }
            return (byte)dayValue;
        }

        public static byte FromUint8(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            return bytes[0];
        }

        public static byte[] FromUint16(int value)
        {
            return BitConverter.GetBytes((short)value);
        }

        public static int ToUint16(byte[] bytes)
        {
            return (bytes[1] << 8 | bytes[0]);
        }

        public static DateTime RawBytesToCalendar(byte[] value)
        {
            if (value.Length >= 7)
            {
                int year = ToUint16(new byte[] { value[0], value[1], 0, 0 });
                DateTime timestamp = new DateTime(
                        year,
                        (value[2] & 0xff),
                        value[3] & 0xff,
                        value[4] & 0xff,
                        value[5] & 0xff,
                        value[6] & 0xff
                );
                return timestamp;
            }
            return new DateTime();
        }
    }
}
