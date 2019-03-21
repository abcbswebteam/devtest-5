using System;
using DevTest5.Droid;

namespace DevTest5.Droid
{
    public class DeviceInfo
    {

        public string GetDeviceId()
        {
            return Android.Provider.Settings.Secure.GetString(Android.App.Application.Context.ContentResolver, Android.Provider.Settings.Secure.AndroidId);
        }
    }
}
