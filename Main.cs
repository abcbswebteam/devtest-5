using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using DevTest5.Droid;

namespace DevTest5.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");



            DevTest5.iOS.DeviceInfo obj = new DeviceInfo();
         

            Console.WriteLine("iOS Device Id: {0}"+obj.GetDeviceId());
        }
    }
}
