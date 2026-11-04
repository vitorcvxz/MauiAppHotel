namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();
    }

    // Método para abrir a página Sobre
    private async void OnSobreClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}