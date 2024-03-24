using UnityEngine;
public class CreateDefaultTable : MonoBehaviour
{
    private void OnMouseDown()
    {
    [SerializeField] private string endpoint = "http://192.168.124.143:8000";
    public Service service;
        
        StartCoroutine(service.SendReq($"{endpoint}/hello", service.ToByteArray(deviceTable)));
        
    }
}//该脚本的目的似乎是通过发送"DeviceTable.json"文件的内容作为字节数组，向指定的"endpoint"发出创建设备表的网络请求。
//然而，由于你提供的代码中缺少"Service"类及其方法的定义，无法理解该网络请求是如何处理的。
