using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ServiceExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var deviceInfoService = DependencyService.Get<IStaticVar>();
            if (deviceInfoService != null)
            {
                DeviceModelLabel.Text = deviceInfoService.valuea().ToString();
            }
        }
    }
}
