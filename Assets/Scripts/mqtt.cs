using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using M2MqttUnity;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Net.Sockets;


public class mqtt : MonoBehaviour
{
    /*//http://tdoc.info/blog/2014/11/10/mqtt_csharp.html
    private MqttClient client;
    // The connection information
    public string brokerHostname = "192.168.0.2";
    public int brokerPort = 8883;
//    public string userName = "test";
//    public string password = "test";
//    public TextAsset certificate;
    // listen on all the Topic
    static string subTopic = "#";
    // Start is called before the first frame update*/

    // Use this for initialization
    void Start()
    {/*
        if (brokerHostname != null) // && userName != null && password != null)
        {
            Debug.Log("connecting to " + brokerHostname + ":" + brokerPort);
            Connect();
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
            byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE };
            client.Subscribe(new string[] { subTopic }, qosLevels);
        }
       // Publish("Salon/Radio", "OFF");*/
    }


    // Update is called once per frame
    void Update()
    {

    }
    void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
    {/*
        string msg = System.Text.Encoding.UTF8.GetString(e.Message);
        Debug.Log("Received message from " + e.Topic + " : " + msg);*/
    }
    public void Publish(string _topic, string msg)
    {/*
        client.Publish(
            _topic, System.Text.Encoding.UTF8.GetBytes(msg),
            MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE, false);*/
    }
    // public static bool MyRemoteCertificateValidationCallback(System.Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
    // {
    //   return true;
    //}
    private void Connect()
    {/*
        Debug.Log("about to connect on '" + brokerHostname + "'");
        // Forming a certificate based on a TextAsset
        // X509Certificate cert = new X509Certificate();
        // cert.Import(certificate.bytes);
        // Debug.Log("Using the certificate '" + cert + "'");
        client = new MqttClient(brokerHostname);//, brokerPort, false, cert, null, MqttSslProtocols.TLSv1_0, MyRemoteCertificateValidationCallback);
        string clientId = Guid.NewGuid().ToString();
        Debug.Log("About to connect");// '" + userName + "' / '" + password + "'");
        try
        {
            client.Connect(clientId);// userName, password);
            Debug.Log("connect");
        }
        catch (Exception e)
        {
            Debug.LogError("Connection error: " + e);
        }*/
    }
}