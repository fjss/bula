using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GalaSoft.MvvmLight.Ioc;
using Gar.Core.Managers;
using Gar.ViewModels.ViewModels;

namespace Gar.Droid.Activities
{
    public partial class BaseActivity<T> : Activity where T : BaseViewModel
    {
        protected T ViewModel
        {
            get;
            private set;
        }

        public BaseActivity()
        {
            ViewModel = MainApplication.Locator.GetViewModel<T>();
        }


    }
}