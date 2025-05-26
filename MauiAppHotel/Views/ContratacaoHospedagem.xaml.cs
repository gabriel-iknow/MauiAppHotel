namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}
    private async void AbrirSobre(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}