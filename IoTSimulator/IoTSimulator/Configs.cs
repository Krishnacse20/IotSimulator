
namespace IoTSimulator
{
    public static class Configs
    {
        static string _mqttBorkerAddress;
        static string _mqttBorkerUName;
        static string _mqttBorkerUPwd;
        public static string MqttBorkerAddress
        {
            get
            {
                if (string.IsNullOrEmpty(_mqttBorkerAddress))
                    _mqttBorkerAddress = getConfig("MQTTBrokerAddress");
                return _mqttBorkerAddress;
            }
        }
        public static string MqttBorkerUser
        {
            get
            {
                if (string.IsNullOrEmpty(_mqttBorkerUName))
                    _mqttBorkerUName = getConfig("MQTTBrokerUname");
                return _mqttBorkerUName;
            }
        }
        public static string MqttBorkerUPassword
        {
            get
            {
                if (string.IsNullOrEmpty(_mqttBorkerUPwd))
                    _mqttBorkerUPwd = getConfig("MQTTBrokerUPassword");
                return _mqttBorkerUPwd;
            }
        }

        private static string getConfig(string key) => new System.Configuration.AppSettingsReader().GetValue(key, typeof(string)).ToString();
    }
}
