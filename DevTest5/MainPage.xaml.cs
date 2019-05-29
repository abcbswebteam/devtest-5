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
        IDeviceInfo _deviceInfo;
        public MainPage()
        {
            InitializeComponent();
            _deviceInfo = DependencyService.Get<IDeviceInfo>();
            deviceId.Text = _deviceInfo.GetDeviceId();
        }
    }
}
