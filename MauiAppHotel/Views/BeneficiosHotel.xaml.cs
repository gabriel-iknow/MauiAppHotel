namespace MauiAppHotel.Views;

public partial class BeneficiosHotel : ContentPage
{
    public BeneficiosHotel()
    {
        InitializeComponent();
    }

    private async void Reservar_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Reserva", "Voc� ser� redirecionado para a p�gina de reservas.", "OK");
    }
}