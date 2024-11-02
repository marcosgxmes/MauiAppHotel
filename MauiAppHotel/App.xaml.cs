
namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
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
