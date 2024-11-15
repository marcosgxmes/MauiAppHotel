using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class ContratracaoHospedagem : ContentPage
{
    App PropriedadesApp;

	public ContratracaoHospedagem()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_room.ItemsSource = PropriedadesApp.lista_quatos;

        dtpck_checkin.MinimumDate = DateTime.Now;

        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(3);
	}

    // IA PARA PAGINA SERVIÇOS CONTRATADOS
    private async void Button_Clicked_1(object sender, EventArgs e)
    {
		try
		{
            Hospedagem h = new()
            {
                QuartoSelecionado = (Quarto)pck_room.SelectedItem,
                QntAdultos = Convert.ToInt32(stp_adults.Value),
                QtdCriancas = Convert.ToInt32(stp_kids.Value),
                DataCheckin = dtpck_checkin.Date,
                DataCheckout = dtpck_checkout.Date,
            };

			await Navigation.PushAsync(new HospedagemContradada()
            {
                BindingContext = h
            });

		} catch (Exception ex)
		{
			await DisplayAlert("ops", ex.Message, "Fechar");
		}
    }

    // IR PARA PAGINA SOBRE
    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new SobreProjeto());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "Fechar");
        }
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = elemento.Date;

        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(3);
    }
}