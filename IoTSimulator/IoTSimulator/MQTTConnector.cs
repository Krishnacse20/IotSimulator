using IoTSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Windows.Forms;


namespace IoTSimulator
{
    class MQTTConnector
    {
        public MqttClient client;
        JavaScriptSerializer serializer;
        string clientId;

        public MQTTConnector()
        {
            Initialize();
        }
        public void Connect()
        {
            if (!client.IsConnected)
            {
                client.Connect(clientId, Configs.MqttBorkerUser, Configs.MqttBorkerUPassword);
            }
        }
        public void Initialize()
        {
            serializer = new JavaScriptSerializer();
            client = new MqttClient(Configs.MqttBorkerAddress);
            //client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
            clientId = Guid.NewGuid().ToString();
            client.Connect(clientId, Configs.MqttBorkerUser, Configs.MqttBorkerUPassword);
        }

        public void CloseConnection()
        {
            if (client.IsConnected)
                client.Disconnect();
        }
        public void Subscribe(string topic) => client.Subscribe(new string[] { topic }, new byte[] { 0 });

        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            Task t = Task.Run(() =>
            {
                 ProcessPayLoad(e.Topic, e.Message);
            });
        }
        /// <summary>
        /// 
        /// </summary>
      
        public async  void Publish(string topic, MQTTPayLoad payload)
        {
            Connect();
            var msg = serializer.Serialize(payload);
            if (msg != "")
            {
                await Task.Run(() =>
                {
                    if (!string.IsNullOrEmpty(topic))
                    {
                        client.Publish(topic, Encoding.UTF8.GetBytes(msg), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                    }
                });
            }
        }
        private  void  ProcessPayLoad(string topic, byte[] msg)
        {
            MQTTPayLoad payLoad = new MQTTPayLoad();
            //await Task.Run(() =>
            //{
                payLoad = serializer.Deserialize<MQTTPayLoad>(Encoding.UTF8.GetString(msg));
                //   Console.WriteLine("Received :{0}:{1}", payLoad.Time, topic);
              
            //});
        }
    }
}

