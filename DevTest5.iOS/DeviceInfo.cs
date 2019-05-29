using System;
using DevTest5.iOS;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceInfo))]
namespace DevTest5.iOS
{
    public class DeviceInfo : IDeviceInfo
    {

        public string GetDeviceId()
        {
            return UIDevice.CurrentDevice.IdentifierForVendor.ToString();
        }
    }
}
