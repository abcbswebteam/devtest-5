using System;
using DevTest5.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceInfo))]
namespace DevTest5.Droid
{
    public class DeviceInfo : IDeviceInfo
    {

        public string GetDeviceId()
        {
            return Android.Provider.Settings.Secure.GetString(Android.App.Application.Context.ContentResolver, Android.Provider.Settings.Secure.AndroidId);
        }
    }
}
