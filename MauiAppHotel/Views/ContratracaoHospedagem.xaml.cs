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

    // IA PARA PAGINA SOBRE
    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new SobreProjeto());

		} catch (Exception ex)
		{
			DisplayAlert("ops", ex.Message, "Fechar");
		}
    }

    // IR PARA PAGINA SERVIÇOS CONTRATADOS
    private void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContradada());

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