namespace MauiAppHotel.Views;

public partial class HospedagemContradada : ContentPage
{
	public HospedagemContradada()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{   // Voltar para tela anteriro
			Navigation.PopAsync();

		} catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "Fechar");
		}
    }
}