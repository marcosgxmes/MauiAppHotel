namespace MauiAppHotel.Views;

public partial class SobreProjeto : ContentPage
{
	public SobreProjeto()
	{
		InitializeComponent();
	}

   

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {   // Voltar para tela anteriro
            Navigation.PopAsync();

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Fechar");
        }
    }
}