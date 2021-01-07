using MQTTnet;
using MQTTnet.Client.Options;
using MQTTnet.Extensions.ManagedClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHomeServer.Clients
{
    public class MQTTClient
    {
        private static IManagedMqttClient client;

        /// &lt;summary&gt;
        /// Connect to broker.
        /// &lt;/summary
        /// &lt;returns&gt;Task.&lt;/returns
        /// 

        public MQTTClient()
        {
            var result = ConnectAsync();
        }

        public static async Task ConnectAsync()
        {
            string clientId = Guid.NewGuid().ToString();
            string mqttURI = "127.0.0.1";
            string mqttUser = "Test";
            string mqttPassword = "Asdf1234";
            int mqttPort = 1883;
            bool mqttSecure = false;
            var messageBuilder = new MqttClientOptionsBuilder()
                .WithClientId(clientId)
                .WithCredentials(mqttUser, mqttPassword)
                .WithTcpServer(mqttURI, mqttPort)
                .WithCleanSession();
            
            var options = mqttSecure
                ? messageBuilder
                .WithTls()
                .Build()
                : messageBuilder
                .Build();
            
          var managedOptions = new ManagedMqttClientOptionsBuilder()
            .WithAutoReconnectDelay(TimeSpan.FromSeconds(5))
            .WithClientOptions(options)
            .Build();
            
           client = new MqttFactory().CreateManagedMqttClient();
            
          await client.StartAsync(managedOptions);
        }
    }
}
