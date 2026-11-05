namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;

    public ContratacaoHospedagem()
    {
        InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(1);

        DateTime data_checkin = dtpck_checkin.Date ?? DateTime.Today;

        dtpck_checkout.MinimumDate = data_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_checkin.AddMonths(6);
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DateTime data_selecionada_checkin = Convert.ToDateTime(e.NewDate);

        DateTime data_minima = data_selecionada_checkin.AddDays(1);
        DateTime data_maxima = data_selecionada_checkin.AddMonths(6);

        dtpck_checkout.MinimumDate = data_minima;
        dtpck_checkout.MaximumDate = data_maxima;

        DateTime data_checkout = Convert.ToDateTime(dtpck_checkout.Date);

        if (data_checkout <= data_selecionada_checkin)
        {
            dtpck_checkout.Date = data_minima;
        }
    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContratada());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
    private async void OnSobreClicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new Sobre());
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}