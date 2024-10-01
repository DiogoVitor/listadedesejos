using Microsoft.Maui.Controls;
using System;

namespace APP_listade_desejos
{
    public partial class Sobre : ContentPage
    {
        public Sobre()
        {
            InitializeComponent();
        }

        // Manipulador de evento para o botão "Enviar E-mail"
        private async void OnEmailButtonClicked(object sender, EventArgs e)
        {
            try
            {
                // Abre o cliente de e-mail
                await Launcher.OpenAsync(new Uri("mailto:seuemail@exemplo.com"));
            }
            catch (Exception ex)
            {
                // Trate possíveis exceções aqui
                await DisplayAlert("Erro", "Não foi possível abrir o aplicativo de e-mail", "OK");
            }
        }

        // Manipulador de evento para o botão "Visite nosso site"
        private async void OnWebsiteButtonClicked(object sender, EventArgs e)
        {
            try
            {
                // Abre o navegador com o site
                await Launcher.OpenAsync(new Uri("https://www.seusite.com"));
            }
            catch (Exception ex)
            {
                // Trate possíveis exceções aqui
                await DisplayAlert("Erro", "Não foi possível abrir o navegador", "OK");
            }
        }
    }
}
