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

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContratada());

        }
        catch (Exception ex)
        {
            DisplayAlert("Erro", "Ocorreu um erro ao processar a solicitação: " + ex.Message, "OK");

        }
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BeneficiosHotel());
    }
}
