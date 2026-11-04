namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            Window window = new(new NavigationPage(new Views.ContratacaoHospedagem()));

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}