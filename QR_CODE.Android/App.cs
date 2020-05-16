using Xamarin.Forms;

namespace QR_CODE.TestZXing
{
    public class App : Application
    {
        public App()
        {
            Button btnAbrirTelaScanner = new Button() { Text = "Abrir tela de Scanner QR Code" };
            btnAbrirTelaScanner.Clicked += async (sender, e) => 
            {
                await Application.Current.MainPage.Navigation.PushAsync(new PaginaScannerQRCode());
            };

            //Página principal da sua aplicação
            var novaPagina = new ContentPage
            {
                Title = "Teste Scanner QR Code",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Este é um teste do Scanner QR Code!"
                        }, btnAbrirTelaScanner
                    }
                }
            };

            MainPage = new NavigationPage(novaPagina);
        }

    }
}