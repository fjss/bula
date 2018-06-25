using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gar.ViewModels.ViewModels
{
    public class ViewModelLocator
    {
        public static string LoginView = "LoginView";

        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<LoginViewModel>();
        }

        public LoginViewModel LoginViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<LoginViewModel>();
            }
        }

        public T GetViewModel<T>() where T : BaseViewModel
        {
            return SimpleIoc.Default.GetInstance<T>();
        }
    }
}
