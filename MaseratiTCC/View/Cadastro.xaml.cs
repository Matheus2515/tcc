using MaseratiTCC.ViewModels.Usuarios;

namespace MaseratiTCC.View;

public partial class Cadastro : ContentPage
{
    UsuarioViewModel viewModel;
    public Cadastro()
	{
		InitializeComponent();

        viewModel = new UsuarioViewModel();
        BindingContext = viewModel;
    }

    private void btnVoltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Login());
    }

    private void btnAvancar_Clicked(object sender, EventArgs e)
    {

    }
}