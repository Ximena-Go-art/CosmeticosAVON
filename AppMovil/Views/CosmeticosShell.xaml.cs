using AppMovil.ViewModels;
using AppMovil.Views.LogIn;
using Microsoft.Maui.Controls;


namespace AppMovil.Views;

public partial class CosmeticosShell : Shell
{
    public CosmeticosShell()
    {
        InitializeComponent();
        FlyoutItemsPrincipal.IsVisible = false; // Oculta el men� lateral
        RegisterRoutes();
    }

    private void RegisterRoutes()
    {
        Routing.RegisterRoute("Registrarse", typeof(SignInView));
    }

    public void EnableAppAfterLogin()
    {
        FlyoutBehavior = FlyoutBehavior.Flyout; // Habilita el FlyOut
        FlyoutItemsPrincipal.IsVisible = true; // Muestra el men� lateral
        Shell.Current.GoToAsync("//MainPage"); // Navega a la p�gina principal
        var viewmodel = this.BindingContext as CosmeticosShellViewModel;
        viewmodel.UserIsLogout = false;
    }
    public void DisableAppAfterLogin()
    {
        FlyoutItemsPrincipal.IsVisible = false; // Oculta el men� lateral
        FlyoutBehavior = FlyoutBehavior.Disabled; // Deshabilita el FlyOut
        Shell.Current.GoToAsync("//LogIn"); // Navega a la p�gina de login
    }
}