using UnityEngine;
using System.Collections;
using System.Net;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt.Utility;
using uPLibrary.Networking.M2Mqtt.Exceptions;
using UnityEngine.UI;

using System;
using TMPro;

public class TemperaturaText : MonoBehaviour
{
    public TextMeshPro textTemperatura;
    public string brokerEndPoint = "test.mosquitto.org";
	public int brokerPort = 1883;
	public string temperatureTopic = "casa/sala/temperatura";
    public string hourTopic = "casa/sala/hora";
    private MqttClient client;
    string lastMessage;
    float actualTemp;
    float actualHour;
   

    void Start()
    {
        client = new MqttClient(brokerEndPoint, brokerPort, false, null); 
		client.MqttMsgPublishReceived += client_MqttMsgPublishReceived; 
        string clientId = Guid.NewGuid().ToString(); 
		client.Connect(clientId); 

        client.Subscribe(new string[] { temperatureTopic }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
        client.Subscribe(new string[] { hourTopic }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });

    }

    void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e) 
	{ 
		Debug.Log("Received: " + System.Text.Encoding.UTF8.GetString(e.Message)  );
		lastMessage = System.Text.Encoding.UTF8.GetString(e.Message);
		
        if(e.Topic.Equals(hourTopic))
        {
            float hora;
            float.TryParse(lastMessage, out hora);
            actualHour = hora;;
        }

        if(e.Topic.Equals(temperatureTopic))
        {
            float temp;
            float.TryParse(lastMessage, out temp);
            actualTemp = temp;
        }
        
        
	}
    void Update()
    {
        
        textTemperatura.text = "Temperatura " + actualTemp.ToString() + "º\nHora " + actualHour.ToString();
           
    }
}
