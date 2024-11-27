namespace MauiAppEventoPrograma.Telas;

public partial class DetalheEvento : ContentPage
{
	public DetalheEvento()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PopModalAsync();
    }
}