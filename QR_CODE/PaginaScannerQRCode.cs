using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace QR_CODE
{
    public class PaginaScannerQRCode : ContentPage
    {
        ZXingScannerPage paginaScannerQRCode;
        Button buttonLeituraQRCode;

        public PaginaScannerQRCode() : base()
        {
            buttonLeituraQRCode = new Button
            {
                Text = "Leitura de QR Code",
                AutomationId = "btnLeituraQRCode",
            };
            buttonLeituraQRCode.Clicked += async delegate
            {
                paginaScannerQRCode = new ZXingScannerPage();
                paginaScannerQRCode.OnScanResult += (result) =>
                {
                    paginaScannerQRCode.IsScanning = false;

                    Device.BeginInvokeOnMainThread(() =>
                    {
                        Navigation.PopAsync();
                        DisplayAlert("QR Code lido: ", result.Text, "OK");
                    });
                };

                await Navigation.PushAsync(paginaScannerQRCode);
            };

            var posicaoButaoPaginaScanner = new StackLayout();
            posicaoButaoPaginaScanner.Children.Add(buttonLeituraQRCode);

            Content = posicaoButaoPaginaScanner;
        }
    }
}
