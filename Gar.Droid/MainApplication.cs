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
using GalaSoft.MvvmLight.Views;
using Gar.Core.Managers;
using Gar.Droid.Activities;
using Gar.ViewModels.ViewModels;

namespace Gar.Droid
{
    [Application]
    public class MainApplication : Application
    {
        private static ViewModelLocator _locator;
        public static ViewModelLocator Locator
        {
            get
            {
                if (_locator == null)
                {
                    _locator = new ViewModelLocator();
                    var nav = new NavigationService();

                    nav.Configure(
                        ViewModelLocator.LoginView,
                        typeof(LoginActivity));

                    SimpleIoc.Default.Register<INavigationService>(() => nav);
                    SimpleIoc.Default.Register<IDialogService>();
                    SimpleIoc.Default.Register<LanguageManager>();
                }
                return _locator;
            }
        }


        public MainApplication(IntPtr handle, JniHandleOwnership transer) : base(handle, transer)
        {

        }
    }

  
}