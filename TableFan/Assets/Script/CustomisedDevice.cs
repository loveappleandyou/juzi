using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using UnityEngine.UI;
public class CustomisedDevice : MonoBehaviour
{
    [SerializeField] private TMP_InputField TMPname;
    [SerializeField] private TMP_Dropdown TMPcategory;
    public List<GameObject> toggle = new List<GameObject>();
    public Service service;
    static string deviceName;
    List<string> category = new List<string>();
    public void ManualAddDevice()
    {
        addToggle();
        deviceName = TMPname.text;
        string categories = string.Join(",", category);
        string customDevice = JsonUtility.ToJson(new Devices(deviceName, categories, null));
        StartCoroutine(service.SendReq($"{service.endpoint}/customDevice", service.ToByteArray(customDevice)));
        category.RemoveAll(item => item != null);
    }
    public void addToggle()
    {
        foreach (var item in toggle)
        {
            if (item.GetComponent<Toggle>().isOn && !(category.Contains(item.GetComponentInChildren<Text>().text)))
            {
                category.Add(item.GetComponentInChildren<Text>().text);
            }
        }
    }
}//总体而言，这个脚本的目的似乎是根据用户手动输入的设备名称和选中的设备类别来创建一个自定义设备，并将其发送到指定的网络端点。
