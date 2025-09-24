using AppMovil.ViewModels;
using AppMovil.Views.LogIn;
using Microsoft.Maui.Controls;


namespace AppMovil.Views;

public partial class CosmeticosShell : Shell
{
    public CosmeticosShell()
    {
        InitializeComponent();
        FlyoutItemsPrincipal.IsVisible = false; // Oculta el menú lateral
        RegisterRoutes();
    }

    private void RegisterRoutes()
    {
        Routing.RegisterRoute("Registrarse", typeof(SignInView));
    }

    public void EnableAppAfterLogin()
    {
        FlyoutBehavior = FlyoutBehavior.Flyout; // Habilita el FlyOut
        FlyoutItemsPrincipal.IsVisible = true; // Muestra el menú lateral
        Shell.Current.GoToAsync("//MainPage"); // Navega a la página principal
        var viewmodel = this.BindingContext as CosmeticosShellViewModel;
        viewmodel.UserIsLogout = false;
    }
    public void DisableAppAfterLogin()
    {
        FlyoutItemsPrincipal.IsVisible = false; // Oculta el menú lateral
        FlyoutBehavior = FlyoutBehavior.Disabled; // Deshabilita el FlyOut
        Shell.Current.GoToAsync("//LogIn"); // Navega a la página de login
    }
}