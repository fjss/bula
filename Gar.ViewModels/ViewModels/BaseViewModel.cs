using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Gar.Core.Managers;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gar.ViewModels.ViewModels
{
    public class BaseViewModel : ViewModelBase
    {
        public INavigationService _navigationService;
        protected IDialogService _dialogService;
        public LanguageManager LanguageManager;

        private bool _isLoading;
        public bool IsLoading
        {
            get
            {
                return _isLoading;
            }
            set
            {
                Set(() => IsLoading, ref _isLoading, value);
            }
        }

        private bool _isConnected;
        public bool IsConnected
        {
            get
            {
                return _isConnected;
            }
            set
            {
                Set(() => IsConnected, ref _isConnected, value);
            }
        }

        public BaseViewModel()
        {
            if (SimpleIoc.Default.IsRegistered<INavigationService>())
                _navigationService = SimpleIoc.Default.GetInstance<INavigationService>();
            if (SimpleIoc.Default.IsRegistered<IDialogService>())
                _dialogService = SimpleIoc.Default.GetInstance<IDialogService>();
            if (SimpleIoc.Default.IsRegistered<LanguageManager>())
                LanguageManager = SimpleIoc.Default.GetInstance<LanguageManager>();

            IsConnected = CrossConnectivity.Current.IsConnected;
            CrossConnectivity.Current.ConnectivityChanged += (sender, e) => {
                IsConnected = e.IsConnected;
            };
        }
    }
}
