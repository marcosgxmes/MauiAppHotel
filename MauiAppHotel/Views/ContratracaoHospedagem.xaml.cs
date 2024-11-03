namespace MauiAppHotel.Views;

public partial class ContratracaoHospedagem : ContentPage
{
	public ContratracaoHospedagem()
	{
		InitializeComponent();
	}

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
}