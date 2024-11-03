
using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quatos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte de Luxo",
                ValorDiariaAdulto = 100.0,
                ValorDiariaCriaca = 75.0
            },
            new Quarto()
            {
                Descricao = "Suíte com Hidromassagem",
                ValorDiariaAdulto = 130.0,
                ValorDiariaCriaca = 80.0
            },
            new Quarto()
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 70.0,
                ValorDiariaCriaca = 40.0
            },
            new Quarto()
            {
                Descricao = "Suíte Super Star",
                ValorDiariaAdulto = 150.0,
                ValorDiariaCriaca = 75.0
            },

         };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratracaoHospedagem());
        }

        // Definir dimenções da janela de exibição
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base. CreateWindow(activationState);

            window.Width = 400;
            window.Height = 700;

            return window; 
        }
    }
}
