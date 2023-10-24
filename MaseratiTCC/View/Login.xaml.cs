using MaseratiTCC.ViewModels.Usuarios;

namespace MaseratiTCC.View;

public partial class Login : ContentPage
{
    UsuarioViewModel usuarioViewModel;
    public Login()
	{
		InitializeComponent();
        usuarioViewModel = new UsuarioViewModel();
        BindingContext = usuarioViewModel;
    }

    private void btnEsqueceu_Clicked(object sender, EventArgs e)
    {

    }

    private void btnConfirmar_Clicked(object sender, EventArgs e)
    {

    }

    private void btnCadastrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Cadastro());
    }
}