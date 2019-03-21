using System;
using DevTest5.iOS;
using UIKit;

namespace DevTest5.iOS
{
    public class DeviceInfo
    {

        public string GetDeviceId()
        {
            return UIDevice.CurrentDevice.IdentifierForVendor.ToString();
        }
    }
}
