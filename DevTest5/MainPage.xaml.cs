using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DevTest5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            IDeviceInfo deviceInfo = null;
            deviceId.Text = deviceInfo.GetDeviceId();
        }
    }
}
