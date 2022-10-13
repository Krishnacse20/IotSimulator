using System.Collections.Generic;

namespace IoTSimulator.Entities
{
    public class MQTTTopic
    {
        public long Time { get; set; }
        public string T { get; set; }
        public List<Data> P { get; set; }
    }
    public class MQTTPayLoad
    {
        public long Time { get; set; }
        public List<Data> P { get; set; }
    }
    public class Data
    {
        public string N { get; set; }
        public string V { get; set; }
    }
    public class DeviceRecord
    {
        public string DeviceName { get; set; }
        public long RecordCount { get; set; }
    }
}
