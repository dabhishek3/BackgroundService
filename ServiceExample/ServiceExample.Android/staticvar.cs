using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ServiceExample.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(staticvar))]
namespace ServiceExample.Droid
{
    public class staticvar : IStaticVar
    {
        public int valuea()
        {
            //a = MyWorker.abc;
            int abcd = MyWorker.abc;
            return abcd;
        }
    }
}