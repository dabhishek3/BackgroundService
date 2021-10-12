using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceExample.Droid
{
    public class MyWorker: Worker
    {
       public static int abc=1;
        public MyWorker(Context context, WorkerParameters workerParameters) : base(context, workerParameters)
        {

        }
        public override Result DoWork()
        {
            var taxReturn = CalculateTaxes();
            
            Android.Util.Log.Debug("CalculatorWorker", $"Your Tax Return is: {taxReturn}");
            return Result.InvokeSuccess();
        }

        public double CalculateTaxes()
        {
            abc = abc + 1;
            return 2000;
        }
    }
}