using System;
using System.Collections.Generic;
using System.Text;

namespace WearConduit.Shared.Models
{
    internal static class BluetoothLEGuids
    {
        public const string BaseGuidFormat = "0000%s-0000-1000-8000-00805f9b34fb";
    }

    internal static class GattGuids
    {
        //part of the generic BLE specs see https://developer.bluetooth.org/gatt/services/Pages/ServicesHome.aspx
        //the list is complete as of 2015-09-28
        public static readonly Guid UUID_SERVICE_ALERT_NOTIFICATION = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "1811"));
        public static readonly Guid UUID_SERVICE_AUTOMATION_IO = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "1815"));
        public static readonly Guid UUID_SERVICE_BATTERY_SERVICE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "180F"));
        public static readonly Guid UUID_SERVICE_BLOOD_PRESSURE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "1810"));
        public static readonly Guid UUID_SERVICE_BODY_COMPOSITION = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "181B"));
        public static readonly Guid UUID_SERVICE_BOND_MANAGEMENT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "181E"));
        public static readonly Guid UUID_SERVICE_CONTINUOUS_GLUCOSE_MONITORING = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "181F"));
        public static readonly Guid UUID_SERVICE_CURRENT_TIME = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "1805"));
        public static readonly Guid UUID_SERVICE_CYCLING_POWER = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "1818"));
        public static readonly Guid UUID_SERVICE_CYCLING_SPEED_AND_CADENCE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "1816"));
        public static readonly Guid UUID_SERVICE_DEVICE_INFORMATION = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "180A"));
        public static readonly Guid UUID_SERVICE_ENVIRONMENTAL_SENSING = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "181A"));
        public static readonly Guid UUID_SERVICE_GENERIC_ACCESS = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "1800"));
        public static readonly Guid UUID_SERVICE_GENERIC_ATTRIBUTE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "1801"));
        public static readonly Guid UUID_SERVICE_GLUCOSE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "1808"));
        public static readonly Guid UUID_SERVICE_HEALTH_THERMOMETER = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "1809"));
        public static readonly Guid UUID_SERVICE_HEART_RATE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "180D"));
        public static readonly Guid UUID_SERVICE_HUMAN_INTERFACE_DEVICE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "1812"));
        public static readonly Guid UUID_SERVICE_IMMEDIATE_ALERT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "1802"));
        public static readonly Guid UUID_SERVICE_INDOOR_POSITIONING = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "1821"));
        public static readonly Guid UUID_SERVICE_INTERNET_PROTOCOL_SUPPORT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "1820"));
        public static readonly Guid UUID_SERVICE_LINK_LOSS = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "1803"));
        public static readonly Guid UUID_SERVICE_LOCATION_AND_NAVIGATION = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "1819"));
        public static readonly Guid UUID_SERVICE_NEXT_DST_CHANGE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "1807"));
        public static readonly Guid UUID_SERVICE_PHONE_ALERT_STATUS = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "180E"));
        public static readonly Guid UUID_SERVICE_PULSE_OXIMETER = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "1822"));
        public static readonly Guid UUID_SERVICE_REFERENCE_TIME_UPDATE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "1806"));
        public static readonly Guid UUID_SERVICE_RUNNING_SPEED_AND_CADENCE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "1814"));
        public static readonly Guid UUID_SERVICE_SCAN_PARAMETERS = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "1813"));
        public static readonly Guid UUID_SERVICE_TX_POWER = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "1804"));
        public static readonly Guid UUID_SERVICE_USER_DATA = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "181C"));
        public static readonly Guid UUID_SERVICE_WEIGHT_SCALE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "181D"));

        //part of the generic BLE specs see https://developer.bluetooth.org/gatt/characteristics/Pages/CharacteristicsHome.aspx
        //the list is complete as of 2015-09-28
        public static readonly Guid UUID_CHARACTERISTIC_AEROBIC_HEART_RATE_LOWER_LIMIT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A7E"));
        public static readonly Guid UUID_CHARACTERISTIC_AEROBIC_HEART_RATE_UPPER_LIMIT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A84"));
        public static readonly Guid UUID_CHARACTERISTIC_AEROBIC_THRESHOLD = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A7F"));
        public static readonly Guid UUID_CHARACTERISTIC_AGE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A80"));
        public static readonly Guid UUID_CHARACTERISTIC_AGGREGATE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A5A"));
        public static readonly Guid UUID_CHARACTERISTIC_ALERT_CATEGORY_ID = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A43"));
        public static readonly Guid UUID_CHARACTERISTIC_ALERT_CATEGORY_ID_BIT_MASK = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A42"));
        public static readonly Guid UUID_CHARACTERISTIC_ALERT_LEVEL = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A06"));
        public static readonly Guid UUID_CHARACTERISTIC_CLIENT_CHARACTERISTIC_CONFIG = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2902"));

        public const byte NO_ALERT = 0x0;
        public const byte MILD_ALERT = 0x1;
        public const byte HIGH_ALERT = 0x2;

        public static readonly Guid UUID_CHARACTERISTIC_ALERT_NOTIFICATION_CONTROL_POINT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A44"));
        public static readonly Guid UUID_CHARACTERISTIC_ALERT_STATUS = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A3F"));
        public static readonly Guid UUID_CHARACTERISTIC_ALTITUDE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2AB3"));
        public static readonly Guid UUID_CHARACTERISTIC_ANAEROBIC_HEART_RATE_LOWER_LIMIT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A81"));
        public static readonly Guid UUID_CHARACTERISTIC_ANAEROBIC_HEART_RATE_UPPER_LIMIT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A82"));
        public static readonly Guid UUID_CHARACTERISTIC_ANAEROBIC_THRESHOLD = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A83"));
        public static readonly Guid UUID_CHARACTERISTIC_ANALOG = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A58"));
        public static readonly Guid UUID_CHARACTERISTIC_APPARENT_WIND_DIRECTION = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A73"));
        public static readonly Guid UUID_CHARACTERISTIC_APPARENT_WIND_SPEED = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A72"));
        public static readonly Guid UUID_CHARACTERISTIC_GAP_APPEARANCE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A01"));
        public static readonly Guid UUID_CHARACTERISTIC_BAROMETRIC_PRESSURE_TREND = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2AA3"));
        public static readonly Guid UUID_CHARACTERISTIC_BATTERY_LEVEL = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A19"));
        public static readonly Guid UUID_CHARACTERISTIC_BLOOD_PRESSURE_FEATURE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A49"));
        public static readonly Guid UUID_CHARACTERISTIC_BLOOD_PRESSURE_MEASUREMENT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A35"));
        public static readonly Guid UUID_CHARACTERISTIC_BODY_COMPOSITION_FEATURE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A9B"));
        public static readonly Guid UUID_CHARACTERISTIC_BODY_COMPOSITION_MEASUREMENT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A9C"));
        public static readonly Guid UUID_CHARACTERISTIC_BODY_SENSOR_LOCATION = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A38"));
        public static readonly Guid UUID_CHARACTERISTIC_BOND_MANAGEMENT_CONTROL_POINT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2AA4"));
        public static readonly Guid UUID_CHARACTERISTIC_BOND_MANAGEMENT_FEATURE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2AA5"));
        public static readonly Guid UUID_CHARACTERISTIC_BOOT_KEYBOARD_INPUT_REPORT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A22"));
        public static readonly Guid UUID_CHARACTERISTIC_BOOT_KEYBOARD_OUTPUT_REPORT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A32"));
        public static readonly Guid UUID_CHARACTERISTIC_BOOT_MOUSE_INPUT_REPORT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A33"));
        public static readonly Guid UUID_CHARACTERISTIC_GAP_CENTRAL_ADDRESS_RESOLUTION_SUPPORT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2AA6"));
        public static readonly Guid UUID_CHARACTERISTIC_CGM_FEATURE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2AA8"));
        public static readonly Guid UUID_CHARACTERISTIC_CGM_MEASUREMENT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2AA7"));
        public static readonly Guid UUID_CHARACTERISTIC_CGM_SESSION_RUN_TIME = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2AAB"));
        public static readonly Guid UUID_CHARACTERISTIC_CGM_SESSION_START_TIME = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2AAA"));
        public static readonly Guid UUID_CHARACTERISTIC_CGM_SPECIFIC_OPS_CONTROL_POINT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2AAC"));
        public static readonly Guid UUID_CHARACTERISTIC_CGM_STATUS = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2AA9"));
        public static readonly Guid UUID_CHARACTERISTIC_CSC_FEATURE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A5C"));
        public static readonly Guid UUID_CHARACTERISTIC_CSC_MEASUREMENT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A5B"));
        public static readonly Guid UUID_CHARACTERISTIC_CURRENT_TIME = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A2B"));
        public static readonly Guid UUID_CHARACTERISTIC_CYCLING_POWER_CONTROL_POINT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A66"));
        public static readonly Guid UUID_CHARACTERISTIC_CYCLING_POWER_FEATURE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A65"));
        public static readonly Guid UUID_CHARACTERISTIC_CYCLING_POWER_MEASUREMENT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A63"));
        public static readonly Guid UUID_CHARACTERISTIC_CYCLING_POWER_VECTOR = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A64"));
        public static readonly Guid UUID_CHARACTERISTIC_DATABASE_CHANGE_INCREMENT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A99"));
        public static readonly Guid UUID_CHARACTERISTIC_DATE_OF_BIRTH = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A85"));
        public static readonly Guid UUID_CHARACTERISTIC_DATE_OF_THRESHOLD_ASSESSMENT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A86"));
        public static readonly Guid UUID_CHARACTERISTIC_DATE_TIME = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A08"));
        public static readonly Guid UUID_CHARACTERISTIC_DAY_DATE_TIME = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A0A"));
        public static readonly Guid UUID_CHARACTERISTIC_DAY_OF_WEEK = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A09"));
        public static readonly Guid UUID_CHARACTERISTIC_DESCRIPTOR_VALUE_CHANGED = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A7D"));
        public static readonly Guid UUID_CHARACTERISTIC_GAP_DEVICE_NAME = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A00"));
        public static readonly Guid UUID_CHARACTERISTIC_DEW_POINT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A7B"));
        public static readonly Guid UUID_CHARACTERISTIC_DIGITAL = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A56"));
        public static readonly Guid UUID_CHARACTERISTIC_DST_OFFSET = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A0D"));
        public static readonly Guid UUID_CHARACTERISTIC_ELEVATION = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A6C"));
        public static readonly Guid UUID_CHARACTERISTIC_EMAIL_ADDRESS = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A87"));
        public static readonly Guid UUID_CHARACTERISTIC_EXACT_TIME_256 = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A0C"));
        public static readonly Guid UUID_CHARACTERISTIC_FAT_BURN_HEART_RATE_LOWER_LIMIT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A88"));
        public static readonly Guid UUID_CHARACTERISTIC_FAT_BURN_HEART_RATE_UPPER_LIMIT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A89"));
        public static readonly Guid UUID_CHARACTERISTIC_FIRMWARE_REVISION_STRING = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A26"));
        public static readonly Guid UUID_CHARACTERISTIC_FIRST_NAME = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A8A"));
        public static readonly Guid UUID_CHARACTERISTIC_FIVE_ZONE_HEART_RATE_LIMITS = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A8B"));
        public static readonly Guid UUID_CHARACTERISTIC_FLOOR_NUMBER = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2AB2"));
        public static readonly Guid UUID_CHARACTERISTIC_GENDER = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A8C"));
        public static readonly Guid UUID_CHARACTERISTIC_GLUCOSE_FEATURE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A51"));
        public static readonly Guid UUID_CHARACTERISTIC_GLUCOSE_MEASUREMENT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A18"));
        public static readonly Guid UUID_CHARACTERISTIC_GLUCOSE_MEASUREMENT_CONTEXT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A34"));
        public static readonly Guid UUID_CHARACTERISTIC_GUST_FACTOR = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A74"));
        public static readonly Guid UUID_CHARACTERISTIC_HARDWARE_REVISION_STRING = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A27"));
        public static readonly Guid UUID_CHARACTERISTIC_HEART_RATE_CONTROL_POINT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A39"));
        public static readonly Guid UUID_CHARACTERISTIC_HEART_RATE_MAX = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A8D"));
        public static readonly Guid UUID_CHARACTERISTIC_HEART_RATE_MEASUREMENT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A37"));
        public static readonly Guid UUID_CHARACTERISTIC_HEAT_INDEX = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A7A"));
        public static readonly Guid UUID_CHARACTERISTIC_HEIGHT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A8E"));
        public static readonly Guid UUID_CHARACTERISTIC_HID_CONTROL_POINT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A4C"));
        public static readonly Guid UUID_CHARACTERISTIC_HID_INFORMATION = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A4A"));
        public static readonly Guid UUID_CHARACTERISTIC_HIP_CIRCUMFERENCE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A8F"));
        public static readonly Guid UUID_CHARACTERISTIC_HUMIDITY = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A6F"));
        public static readonly Guid UUID_CHARACTERISTIC_IEEE_11073_20601_REGULATORY_CERTIFICATION_DATA_LIST = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A2A"));
        public static readonly Guid UUID_CHARACTERISTIC_INDOOR_POSITIONING_CONFIGURATION = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2AAD"));
        public static readonly Guid UUID_CHARACTERISTIC_INTERMEDIATE_BLOOD_PRESSURE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A36"));
        public static readonly Guid UUID_CHARACTERISTIC_INTERMEDIATE_TEMPERATURE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A1E"));
        public static readonly Guid UUID_CHARACTERISTIC_IRRADIANCE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A77"));
        public static readonly Guid UUID_CHARACTERISTIC_LANGUAGE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2AA2"));
        public static readonly Guid UUID_CHARACTERISTIC_LAST_NAME = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A90"));
        public static readonly Guid UUID_CHARACTERISTIC_LATITUDE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2AAE"));
        public static readonly Guid UUID_CHARACTERISTIC_LN_CONTROL_POINT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A6B"));
        public static readonly Guid UUID_CHARACTERISTIC_LN_FEATURE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A6A"));
        public static readonly Guid UUID_CHARACTERISTIC_LOCAL_EAST_COORDINATE_XML = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2AB1"));
        public static readonly Guid UUID_CHARACTERISTIC_LOCAL_NORTH_COORDINATE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2AB0"));
        public static readonly Guid UUID_CHARACTERISTIC_LOCAL_TIME_INFORMATION = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A0F"));
        public static readonly Guid UUID_CHARACTERISTIC_LOCATION_AND_SPEED = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A67"));
        public static readonly Guid UUID_CHARACTERISTIC_LOCATION_NAME = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2AB5"));
        public static readonly Guid UUID_CHARACTERISTIC_LONGITUDE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2AAF"));
        public static readonly Guid UUID_CHARACTERISTIC_MAGNETIC_DECLINATION = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A2C"));
        public static readonly Guid UUID_CHARACTERISTIC_MAGNETIC_FLUX_DENSITY_2D = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2AA0"));
        public static readonly Guid UUID_CHARACTERISTIC_MAGNETIC_FLUX_DENSITY_3D = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2AA1"));
        public static readonly Guid UUID_CHARACTERISTIC_MANUFACTURER_NAME_STRING = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A29"));
        public static readonly Guid UUID_CHARACTERISTIC_MAXIMUM_RECOMMENDED_HEART_RATE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A91"));
        public static readonly Guid UUID_CHARACTERISTIC_MEASUREMENT_INTERVAL = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A21"));
        public static readonly Guid UUID_CHARACTERISTIC_MODEL_NUMBER_STRING = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A24"));
        public static readonly Guid UUID_CHARACTERISTIC_NAVIGATION = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A68"));
        public static readonly Guid UUID_CHARACTERISTIC_NEW_ALERT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A46"));
        public static readonly Guid UUID_CHARACTERISTIC_GAP_PERIPHERAL_PREFERRED_CONNECTION_PARAMETERS = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A04"));
        public static readonly Guid UUID_CHARACTERISTIC_GAP_PERIPHERAL_PRIVACY_FLAG = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A02"));
        public static readonly Guid UUID_CHARACTERISTIC_PLX_CONTINUOUS_MEASUREMENT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A5F"));
        public static readonly Guid UUID_CHARACTERISTIC_PLX_FEATURES = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A60"));
        public static readonly Guid UUID_CHARACTERISTIC_PLX_SPOT_CHECK_MEASUREMENT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A5E"));
        public static readonly Guid UUID_CHARACTERISTIC_PNP_ID = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A50"));
        public static readonly Guid UUID_CHARACTERISTIC_POLLEN_CONCENTRATION = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A75"));
        public static readonly Guid UUID_CHARACTERISTIC_POSITION_QUALITY = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A69"));
        public static readonly Guid UUID_CHARACTERISTIC_PRESSURE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A6D"));
        public static readonly Guid UUID_CHARACTERISTIC_PROTOCOL_MODE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A4E"));
        public static readonly Guid UUID_CHARACTERISTIC_RAINFALL = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A78"));
        public static readonly Guid UUID_CHARACTERISTIC_GAP_RECONNECTION_ADDRESS = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A03"));
        public static readonly Guid UUID_CHARACTERISTIC_RECORD_ACCESS_CONTROL_POINT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A52"));
        public static readonly Guid UUID_CHARACTERISTIC_REFERENCE_TIME_INFORMATION = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A14"));
        public static readonly Guid UUID_CHARACTERISTIC_REPORT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A4D"));
        public static readonly Guid UUID_CHARACTERISTIC_REPORT_MAP = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A4B"));
        public static readonly Guid UUID_CHARACTERISTIC_RESTING_HEART_RATE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A92"));
        public static readonly Guid UUID_CHARACTERISTIC_RINGER_CONTROL_POINT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A40"));
        public static readonly Guid UUID_CHARACTERISTIC_RINGER_SETTING = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A41"));
        public static readonly Guid UUID_CHARACTERISTIC_RSC_FEATURE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A54"));
        public static readonly Guid UUID_CHARACTERISTIC_RSC_MEASUREMENT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A53"));
        public static readonly Guid UUID_CHARACTERISTIC_SC_CONTROL_POINT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A55"));
        public static readonly Guid UUID_CHARACTERISTIC_SCAN_INTERVAL_WINDOW = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A4F"));
        public static readonly Guid UUID_CHARACTERISTIC_SCAN_REFRESH = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A31"));
        public static readonly Guid UUID_CHARACTERISTIC_SENSOR_LOCATION = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A5D"));
        public static readonly Guid UUID_CHARACTERISTIC_SERIAL_NUMBER_STRING = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A25"));
        public static readonly Guid UUID_CHARACTERISTIC_GATT_SERVICE_CHANGED = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A05"));
        public static readonly Guid UUID_CHARACTERISTIC_SOFTWARE_REVISION_STRING = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A28"));
        public static readonly Guid UUID_CHARACTERISTIC_SPORT_TYPE_FOR_AEROBIC_AND_ANAEROBIC_THRESHOLDS = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A93"));
        public static readonly Guid UUID_CHARACTERISTIC_SUPPORTED_NEW_ALERT_CATEGORY = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A47"));
        public static readonly Guid UUID_CHARACTERISTIC_SUPPORTED_UNREAD_ALERT_CATEGORY = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A48"));
        public static readonly Guid UUID_CHARACTERISTIC_SYSTEM_ID = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A23"));
        public static readonly Guid UUID_CHARACTERISTIC_TEMPERATURE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A6E"));
        public static readonly Guid UUID_CHARACTERISTIC_TEMPERATURE_MEASUREMENT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A1C"));
        public static readonly Guid UUID_CHARACTERISTIC_TEMPERATURE_TYPE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A1D"));
        public static readonly Guid UUID_CHARACTERISTIC_THREE_ZONE_HEART_RATE_LIMITS = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A94"));
        public static readonly Guid UUID_CHARACTERISTIC_TIME_ACCURACY = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A12"));
        public static readonly Guid UUID_CHARACTERISTIC_TIME_SOURCE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A13"));
        public static readonly Guid UUID_CHARACTERISTIC_TIME_UPDATE_CONTROL_POINT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A16"));
        public static readonly Guid UUID_CHARACTERISTIC_TIME_UPDATE_STATE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A17"));
        public static readonly Guid UUID_CHARACTERISTIC_TIME_WITH_DST = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A11"));
        public static readonly Guid UUID_CHARACTERISTIC_TIME_ZONE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A0E"));
        public static readonly Guid UUID_CHARACTERISTIC_TRUE_WIND_DIRECTION = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A71"));
        public static readonly Guid UUID_CHARACTERISTIC_TRUE_WIND_SPEED = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A70"));
        public static readonly Guid UUID_CHARACTERISTIC_TWO_ZONE_HEART_RATE_LIMIT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A95"));
        public static readonly Guid UUID_CHARACTERISTIC_TX_POWER_LEVEL = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A07"));
        public static readonly Guid UUID_CHARACTERISTIC_UNCERTAINTY = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2AB4"));
        public static readonly Guid UUID_CHARACTERISTIC_UNREAD_ALERT_STATUS = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A45"));
        public static readonly Guid UUID_CHARACTERISTIC_USER_CONTROL_POINT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A9F"));
        public static readonly Guid UUID_CHARACTERISTIC_USER_INDEX = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A9A"));
        public static readonly Guid UUID_CHARACTERISTIC_UV_INDEX = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A76"));
        public static readonly Guid UUID_CHARACTERISTIC_VO2_MAX = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A96"));
        public static readonly Guid UUID_CHARACTERISTIC_WAIST_CIRCUMFERENCE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A97"));
        public static readonly Guid UUID_CHARACTERISTIC_WEIGHT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A98"));
        public static readonly Guid UUID_CHARACTERISTIC_WEIGHT_MEASUREMENT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A9D"));
        public static readonly Guid UUID_CHARACTERISTIC_WEIGHT_SCALE_FEATURE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A9E"));
        public static readonly Guid UUID_CHARACTERISTIC_WIND_CHILL = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "2A79"));
    }

    internal static class MiBand3Guids
    {
        public const string MAC_ADDRESS_FILTER_1_1A = "88:0F:10";
        public const string MAC_ADDRESS_FILTER_1S = "C8:0F:10";

        public static Guid UUID_SERVICE_MIBAND_SERVICE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "FEE0"));
        public static Guid UUID_SERVICE_MIBAND2_SERVICE = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "FEE1"));
        public static Guid UUID_SERVICE_HEART_RATE = GattGuids.UUID_SERVICE_HEART_RATE;
        public const string UUID_SERVICE_WEIGHT_SERVICE = "00001530-0000-3512-2118-0009af100700";

        public static Guid UUID_CHARACTERISTIC_DEVICE_INFO = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "FF01"));

        public static Guid UUID_CHARACTERISTIC_DEVICE_NAME = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "FF02"));

        public static Guid UUID_CHARACTERISTIC_NOTIFICATION = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "FF03"));

        public static Guid UUID_CHARACTERISTIC_USER_INFO = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "FF04"));

        public static Guid UUID_CHARACTERISTIC_CONTROL_POINT = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "FF05"));

        public static Guid UUID_CHARACTERISTIC_REALTIME_STEPS = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "FF06"));

        public static Guid UUID_CHARACTERISTIC_ACTIVITY_DATA = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "FF07"));

        public static Guid UUID_CHARACTERISTIC_FIRMWARE_DATA = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "FF08"));

        public static Guid UUID_CHARACTERISTIC_LE_PARAMS = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "FF09"));

        public static Guid UUID_CHARACTERISTIC_DATE_TIME = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "FF0A"));

        public static Guid UUID_CHARACTERISTIC_STATISTICS = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "FF0B"));

        public static Guid UUID_CHARACTERISTIC_BATTERY = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "FF0C"));

        public static Guid UUID_CHARACTERISTIC_TEST = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "FF0D"));

        public static Guid UUID_CHARACTERISTIC_SENSOR_DATA = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "FF0E"));

        public static Guid UUID_CHARACTERISTIC_PAIR = new Guid(string.Format(BluetoothLEGuids.BaseGuidFormat, "FF0F"));

        public static Guid UUID_CHARACTERISTIC_HEART_RATE_CONTROL_POINT = GattGuids.UUID_CHARACTERISTIC_HEART_RATE_CONTROL_POINT;
        public static Guid UUID_CHARACTERISTIC_HEART_RATE_MEASUREMENT = GattGuids.UUID_CHARACTERISTIC_HEART_RATE_MEASUREMENT;



        /* FURTHER GuidS that were mixed with the other params below. The base Guid for these is unknown */

        public static byte ALIAS_LEN = 0xa;

        /*NOTIFICATIONS: usually received on the UUID_CHARACTERISTIC_NOTIFICATION characteristic */

        public static byte NOTIFY_NORMAL = 0x0;

        public static byte NOTIFY_FIRMWARE_UPDATE_FAILED = 0x1;

        public static byte NOTIFY_FIRMWARE_UPDATE_SUCCESS = 0x2;

        public static byte NOTIFY_CONN_PARAM_UPDATE_FAILED = 0x3;

        public static byte NOTIFY_CONN_PARAM_UPDATE_SUCCESS = 0x4;

        public static byte NOTIFY_AUTHENTICATION_SUCCESS = 0x5;

        public static byte NOTIFY_AUTHENTICATION_FAILED = 0x6;

        public static byte NOTIFY_FITNESS_GOAL_ACHIEVED = 0x7;

        public static byte NOTIFY_SET_LATENCY_SUCCESS = 0x8;

        public static byte NOTIFY_RESET_AUTHENTICATION_FAILED = 0x9;

        public static byte NOTIFY_RESET_AUTHENTICATION_SUCCESS = 0xa;

        public static byte NOTIFY_FW_CHECK_FAILED = 0xb;

        public static byte NOTIFY_FW_CHECK_SUCCESS = 0xc;

        public static byte NOTIFY_STATUS_MOTOR_NOTIFY = 0xd;

        public static byte NOTIFY_STATUS_MOTOR_CALL = 0xe;

        public static byte NOTIFY_STATUS_MOTOR_DISCONNECT = 0xf;

        public static byte NOTIFY_STATUS_MOTOR_SMART_ALARM = 0x10;

        public static byte NOTIFY_STATUS_MOTOR_ALARM = 0x11;

        public static byte NOTIFY_STATUS_MOTOR_GOAL = 0x12;

        public static byte NOTIFY_STATUS_MOTOR_AUTH = 0x13;

        public static byte NOTIFY_STATUS_MOTOR_SHUTDOWN = 0x14;

        public static byte NOTIFY_STATUS_MOTOR_AUTH_SUCCESS = 0x15;

        public static byte NOTIFY_STATUS_MOTOR_TEST = 0x16;

        // 0x18 is returned when we cancel data sync, perhaps is an ack for this message

        public static byte NOTIFY_UNKNOWN = 0xff;

        public static int NOTIFY_PAIR_CANCEL = 0xef;

        public static int NOTIFY_DEVICE_MALFUNCTION = 0xff;


        /* MESSAGES: unknown */

        public static byte MSG_CONNECTED = 0x0;

        public static byte MSG_DISCONNECTED = 0x1;

        public static byte MSG_CONNECTION_FAILED = 0x2;

        public static byte MSG_INITIALIZATION_FAILED = 0x3;

        public static byte MSG_INITIALIZATION_SUCCESS = 0x4;

        public static byte MSG_STEPS_CHANGED = 0x5;

        public static byte MSG_DEVICE_STATUS_CHANGED = 0x6;

        public static byte MSG_BATTERY_STATUS_CHANGED = 0x7;

        /* COMMANDS: usually sent to UUID_CHARACTERISTIC_CONTROL_POINT characteristic */

        public static byte COMMAND_SET_TIMER = 0x4;

        public static byte COMMAND_SET_FITNESS_GOAL = 0x5;

        public static byte COMMAND_FETCH_DATA = 0x6;

        public static byte COMMAND_SEND_FIRMWARE_INFO = 0x7;

        public static byte COMMAND_SEND_NOTIFICATION = 0x8;

        public static byte COMMAND_FACTORYRESET = 0x9;

        public static byte COMMAND_CONFIRM_ACTIVITY_DATA_TRANSFER_COMPLETE = 0xa;

        public static byte COMMAND_SYNC = 0xb;

        public static byte COMMAND_REBOOT = 0xc;

        public static byte COMMAND_SET_WEAR_LOCATION = 0xf;

        public static byte COMMAND_STOP_SYNC_DATA = 0x11;

        public static byte COMMAND_STOP_MOTOR_VIBRATE = 0x13;

        public static byte COMMAND_SET_REALTIME_STEPS_NOTIFICATION = 0x3;

        public static byte COMMAND_SET_REALTIME_STEP = 0x10;

        // Test HR
        public static byte COMMAND_SET_HR_SLEEP = 0x0;
        public static byte COMMAND_SET__HR_CONTINUOUS = 0x1;
        public static byte COMMAND_SET_HR_MANUAL = 0x2;

        public static byte COMMAND_GET_SENSOR_DATA = 0x12;

        /* FURTHER COMMANDS: unchecked therefore left commented


        public static byte COMMAND_FACTORY_RESET = 0x9t;

        public static int COMMAND_SET_COLOR_THEME = et;

        */

        /* CONNECTION: unknown

        public static CONNECTION_LATENCY_LEVEL_LOW = 0x0t;

        public static CONNECTION_LATENCY_LEVEL_MEDIUM = 0x1t;

        public static CONNECTION_LATENCY_LEVEL_HIGH = 0x2t;

        */

        /* MODES: probably related to the sample data structure
        */

        public static byte MODE_REGULAR_DATA_LEN_BYTE = 0x0;

        // was MODE_REGULAR_DATA_LEN_MINITE
        public static byte MODE_REGULAR_DATA_LEN_MINUTE = 0x1;

        /* PROFILE: unknown

        public static PROFILE_STATE_UNKNOWN:I = 0x0

        public static PROFILE_STATE_INITIALIZATION_SUCCESS:I = 0x1

        public static PROFILE_STATE_INITIALIZATION_FAILED:I = 0x2

        public static PROFILE_STATE_AUTHENTICATION_SUCCESS:I = 0x3

        public static PROFILE_STATE_AUTHENTICATION_FAILED:I = 0x4

        */

        // TEST_*: sent to UUID_CHARACTERISTIC_TEST characteristic

        public static byte TEST_DISCONNECTED_REMINDER = 0x5;

        public static byte TEST_NOTIFICATION = 0x3;

        public static byte TEST_REMOTE_DISCONNECT = 0x1;

        public static byte TEST_SELFTEST = 0x2;

        private static Dictionary<Guid, string> MIBAND_DEBUG = new Dictionary<Guid, string>
        {
            {UUID_SERVICE_MIBAND_SERVICE, "MiBand Service"},
            {UUID_SERVICE_HEART_RATE, "MiBand HR Service"},

            {UUID_CHARACTERISTIC_DEVICE_INFO, "Device Info"},
            {UUID_CHARACTERISTIC_DEVICE_NAME, "Device Name"},
            {UUID_CHARACTERISTIC_NOTIFICATION, "Notification"},
            {UUID_CHARACTERISTIC_USER_INFO, "User Info"},
            {UUID_CHARACTERISTIC_CONTROL_POINT, "Control Point"},
            {UUID_CHARACTERISTIC_REALTIME_STEPS, "Realtime Steps"},
            {UUID_CHARACTERISTIC_ACTIVITY_DATA, "Activity Data"},
            {UUID_CHARACTERISTIC_FIRMWARE_DATA, "Firmware Data"},
            {UUID_CHARACTERISTIC_LE_PARAMS, "LE Params"},
            {UUID_CHARACTERISTIC_DATE_TIME, "Date/Time"},
            {UUID_CHARACTERISTIC_STATISTICS, "Statistics"},
            {UUID_CHARACTERISTIC_BATTERY, "Battery"},
            {UUID_CHARACTERISTIC_TEST, "Test"},
            {UUID_CHARACTERISTIC_SENSOR_DATA, "Sensor Data"},
            {UUID_CHARACTERISTIC_PAIR, "Pair"},
            {UUID_CHARACTERISTIC_HEART_RATE_CONTROL_POINT, "Heart Rate Control Point"},
            {UUID_CHARACTERISTIC_HEART_RATE_MEASUREMENT, "Heart Rate Measure"},
        };
    }
}
