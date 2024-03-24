public class Devices
{
    public string name;
    public string category;
    public string status;
    public Devices(int id, string action)
    {

        switch (id)
        {
            case 1:
                name = "LED-light";
                category = "Sight";
                status = action;
                break;
            case 2:
                name = "VR-Headset";
                category = "Sight";
                status = action;
                break;
            case 3:
                name = "headphone";
                category = "Audio";
                status = action;
                break;
            case 4:
                name = "speaker";
                category = "Audio";
                status = action;
                break;
            case 5:
                name = "exoskeletons";
                category = "Haptic";
                status = action;
                break;
            case 6:
                name = "glove";
                category = "Haptic";
                status = action;
                break;
            case 7:
                name = "joysticks";
                category = "Haptic";
                status = action;
                break;
            case 8:
                name = "fan";
                category = "Haptic";
                status = action;
                break;
            case 9:
                name = "olfactometers";
                category = "Smell";
                status = action;
                break;
            case 10:
                name = "electronic vaporizers";
                category = "Audio";
                status = action;
                break;
        }
    }
    public Devices(string name, string category, string action)
    {
        this.name = name;
        this.category = category;
        this.status = action;
    }
}
//这是一个名为"Devices"的类，用于创建设备对象。

该类包含以下字段：

name：设备的名称
category：设备的类别
status：设备的状态
类还包含以下两个构造函数：

带有id和action参数的构造函数：根据给定的id值选择设备名称、类别和状态。根据不同的id值，设备的名称、类别和状态会有所不同。
带有name、category和action参数的构造函数：使用给定的设备名称、类别和状态来创建设备对象。
通过这个类，你可以根据设备的ID和操作来创建设备对象，也可以直接指定设备的名称、类别和状态创建设备对象。