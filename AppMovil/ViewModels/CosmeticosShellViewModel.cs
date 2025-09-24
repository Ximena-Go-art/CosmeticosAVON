using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AppMovil.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMovil.ViewModels
{
    public partial class CosmeticosShellViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool userIsLogout = true;

        public IRelayCommand LogoutCommand { get; }
        public CosmeticosShellViewModel()
        {
            LogoutCommand = new RelayCommand(OnLogout);
        }

        private void OnLogout()
        {
            userIsLogout = true;
            var cosmeticosShell = (CosmeticosShell)App.Current.MainPage;
            cosmeticosShell.DisableAppAfterLogin();
        }

    }
}
