namespace MauiAppHotel.Views;

public partial class BeneficiosHotel : ContentPage
{
    public BeneficiosHotel()
    {
        InitializeComponent();
    }

    private async void Reservar_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Reserva", "Você será redirecionado para a página de reservas.", "OK");
    }
}