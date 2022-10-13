using IoTSimulator.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace IoTSimulator
{
    public partial class Form1 : Form
    {
        //System.Timers.Timer publishTimer;
        //int s = 10;
        int counter, second = 10, index = 0;
        bool isActive;
        MQTTConnector myConnector;
        public MqttClient client;
        public string topic = "Sample Topic";
        string msg_recvd, topic_recvd;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            counter = 0;
            second = 0;
            isActive = false;

            myConnector = new MQTTConnector();
            myConnector.client.MqttMsgPublishReceived += MqttMsgReceived;
            textR1.Text = "0";
            textR2.Text = "0";
            textR3.Text = "0";
            textR4.Text = "0";
            textR5.Text = "0";
            textR6.Text = "0";
            textR1_.Text = "R1";
            textR2_.Text = "R2";
            textR3_.Text = "R3";
            textR4_.Text = "R4";
            textR5_.Text = "R5";
            textR6_.Text = "R6";
            //dfault topic
            topicTextbox.Text = topic;
        }



        private void StartButton_Click(object sender, EventArgs e)
        {
            if (ValidValues())
            {
                if (validateTopic())
                {
                    isActive = true;
                    Timer.Start();
                    //     myConnector.client.MqttMsgPublishReceived += MqttMsgReceived;
                    StartButton.Enabled = false;
                    StopButton.Enabled = true;
                    error_detail.ForeColor = Color.Green;
                    error_detail.Text = "Successfully started !!";
                }
                else
                {
                    error_detail.ForeColor = Color.Red;
                    error_detail.Text = "Invalid Character  only a-z ,A - Z ,0 - 9,_(underscore), - (dash), .(dot), / are allowed ";               }

                // clear error
            }
            else
            {
                error_detail.ForeColor = Color.Red;
                error_detail.Text="Error!! Please fill all details!!";

            }
        }
        
        private void StopButton_Click(object sender, EventArgs e)
        {
            isActive = false;
            StartButton.Enabled = true;
            StopButton.Enabled = false;
            Timer.Stop();
        }
        private bool validateTopic()
        {
            topic = topicTextbox.Text;
            for(int i=0;i<topic.Length;i++)
            {
                if(check(topic[i]))
                {
                    continue;
                }
                else
                {
                    return false;
                }

            }
            return true;
        }
        private bool check(char x1)
        {
            if ((x1 >= 'a' && x1 <= 'z' )|| ( x1 >= 0 && x1 <= 9) || (x1 >= 'A' && x1 <= 'Z') ||( x1 == '_') || x1 == '-' || x1 == '.' || x1 == '/')
            {
                return true;
            }
            return false;
        }

        private bool ValidValues()
        {
         
            bool flag= true;
            if (string.IsNullOrEmpty(textR1.Text) ||  string.IsNullOrEmpty(textR1_.Text)) 
            {
              
               if(textR1.Text=="")
                {
                    textR1.Focus();
                    errorProvider.SetError(textR1, "Enter the Value");
                  
                }
               else
                {
                    textR1_.Focus();
                    errorProvider.SetError(textR1, "Enter the TagName");
                  
                }
                flag = false;
            }
            else
            {
                errorProvider.Clear();
            }


              if (string.IsNullOrEmpty(textR2.Text) || string.IsNullOrEmpty(textR2_.Text))
            {
                if (textR2.Text == "")
                {
                    textR2.Focus();
                    errorProvider.SetError(textR2, "Enter the Value");

                }
                else
                {
                    textR2_.Focus();
                    errorProvider.SetError(textR2_, "Enter the TagName");

                }
                flag = false;
            }

            if (string.IsNullOrEmpty(textR3.Text) || string.IsNullOrEmpty(textR3_.Text))
            {
                if (textR3.Text == "")
                {
                    textR3.Focus();
                    errorProvider.SetError(textR3, "Enter the Value");

                }
                else
                {
                    textR3_.Focus();
                    errorProvider.SetError(textR3_, "Enter the TagName");

                }
                flag = false;
            }
              if (string.IsNullOrEmpty(textR4.Text) || string.IsNullOrEmpty(textR4_.Text))
            {
                if (textR4.Text == "")
                {
                    textR4.Focus();
               
                    errorProvider.SetError(textR4, "Enter the Value");

                }
                else
                {
                    textR4_.Focus();
                 
                    errorProvider.SetError(textR4_, "Enter the TagName");

                }
                flag = false;
            }
             if (string.IsNullOrEmpty(textR5.Text) || string.IsNullOrEmpty(textR5_.Text))
            {
                if (textR5.Text == "")
                {
                    textR5.Focus();
                    //     textR1.BorderStyle
                    errorProvider.SetError(textR5, "Enter the Value");

                }
                else
                {
                    textR5_.Focus();
                   
                    errorProvider.SetError(textR5_, "Enter the TagName");

                }
                flag = false;
            }
             if (string.IsNullOrEmpty(textR6.Text) || string.IsNullOrEmpty(textR6_.Text))
            {
                if (textR6.Text == "")
                {
                    textR6.Focus();

                    errorProvider.SetError(textR6, "Enter the Value");

                }
                else
                {
                    textR6_.Focus();
                 
                    errorProvider.SetError(textR6_, "Enter the TagName");

                }
                flag = false;
            }
               if (string.IsNullOrEmpty(topicTextbox.Text))
            {
                topicTextbox.Focus();
                errorProvider.SetError(topicTextbox, "Enter the Topic ");
                flag = false;
            }


        return flag;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                counter++;
                if (counter >= 100)
                {
                    second--;
                    counter = 0;
                }
                if (second == 0)
                {
                    PreparePayLoadandPublish();

                  
                    Random rand_value = new Random();
                   textR1.Text = rand_value.Next(0, 9).ToString();
                    textR2.Text = rand_value.Next(0, 9).ToString();
                    textR3.Text = rand_value.Next(0, 9).ToString();
                    textR4.Text = rand_value.Next(0, 9).ToString();
                    textR5.Text = rand_value.Next(0, 9).ToString();
                    textR6.Text = rand_value.Next(0, 9).ToString();
                    second = 10;
                }
            }
            textResult.Text = second.ToString();
        }

        private void publish_button_Click(object sender, EventArgs e)
        {
            if (ValidValues() )
            {
                if(validateTopic())
                {
                    PreparePayLoadandPublish();
                    error_detail.ForeColor = Color.Green;
                    error_detail.Text = "Successfully Published!!!";
                }
                else
                {
                    error_detail.ForeColor = Color.Red;
                    error_detail.Text = "Invalid Character  only a-z ,A - Z ,0 - 9,_(underscore), - (dash), .(dot), / are allowed ";
                }
             
            }
            else
            {
                error_detail.ForeColor = Color.Red;
                error_detail.Text = "Error!! Please fill all details!!";
            }
        }

     

        private void FormClosing1(object sender, FormClosingEventArgs e)
        {
            isActive = false;
            myConnector.CloseConnection();
            Application.DoEvents();
            Application.Exit();
            Environment.Exit(0);
        }

        private void PreparePayLoadandPublish()
        {

            //Create payload object and bind values

            MQTTPayLoad payLoad = new MQTTPayLoad()
            {
                Time = DateTime.UtcNow.Ticks,
                P = new List<Data>() {
                        new Data {  N= textR1_.Text, V=textR1.Text },
                        new Data {  N= textR2_.Text, V= textR2.Text},
                        new Data {  N=textR3_.Text, V=textR3.Text },
                        new Data {  N=textR4_.Text, V=textR4.Text},
                        new Data {  N=textR5_.Text, V= textR5.Text},
                        new Data {  N=textR6_.Text, V= textR6.Text},
                         }
            };
            //TODO use topic from Form
            index++;
            topic = topicTextbox.Text;
            myConnector.Subscribe(topic);
            myConnector.Publish(topic, payLoad);
            displayBox.Text = string.Format("Publishing :{0}: {1} \n ", index, topic) + displayBox.Text;
        }
        private void MqttMsgReceived(object sender, MqttMsgPublishEventArgs e)
        {
            Invoke(new Action(() =>
            {
                msg_recvd = Encoding.UTF8.GetString(e.Message);
                //topic_recvd = e.Topic;

                displayBox.Text = string.Format("Recieved :{0}:{1}:{2}\n", index, e.Topic, msg_recvd) + displayBox.Text;

            }
             ));
        }
    }
}