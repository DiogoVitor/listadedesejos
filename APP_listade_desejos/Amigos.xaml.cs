using System.Collections.ObjectModel;

namespace APP_listade_desejos
{
    public partial class AmigosPage : ContentPage
    {
        // ObservableCollection para armazenar a lista de amigos
        public ObservableCollection<Amigo> Amigos { get; set; }
        public ObservableCollection<Amigo> AmigosFiltrados { get; set; }

        public AmigosPage()
        {
            InitializeComponent();

            // Inicializa a lista de amigos
            Amigos = new ObservableCollection<Amigo>
            {
                new Amigo { Nome = "João" },
                new Amigo { Nome = "Maria" },
                new Amigo { Nome = "Carlos" },
            };

            // Define a lista de amigos na interface
            amigosListView.ItemsSource = Amigos;
        }

        // Evento disparado quando o botão "Adicionar Amigo" é clicado
        private async void OnAddAmigoClicked(object sender, EventArgs e)
        {
            string novoAmigoNome = await DisplayPromptAsync("Adicionar Amigo", "Digite o nome do novo amigo:");

            if (!string.IsNullOrWhiteSpace(novoAmigoNome))
            {
                Amigos.Add(new Amigo { Nome = novoAmigoNome });
            }
        }

        // Evento para remover um amigo da lista
        private void OnRemoveAmigoClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var amigoParaRemover = button?.CommandParameter as Amigo;

            if (amigoParaRemover != null)
            {
                Amigos.Remove(amigoParaRemover);
            }
        }

        // Evento para bloquear um amigo
        private void OnBlockAmigoClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var amigoParaBloquear = button?.CommandParameter as Amigo;

            if (amigoParaBloquear != null)
            {
                // Simulação de bloqueio - aqui você poderia implementar lógica adicional
                DisplayAlert("Bloquear Amigo", $"Você bloqueou {amigoParaBloquear.Nome}.", "OK");
            }
        }

        // Evento disparado ao buscar amigos
        private void OnSearchBarTextChanged(object sender, TextChangedEventArgs e)
        {
            string filtro = e.NewTextValue;

            if (string.IsNullOrWhiteSpace(filtro))
            {
                amigosListView.ItemsSource = Amigos;
            }
            else
            {
                amigosListView.ItemsSource = Amigos.Where(a => a.Nome.ToLower().Contains(filtro.ToLower()));
            }
        }
        
        // Evento disparado quando o nome do amigo é clicado
        private async void OnAmigoTapped(object sender, EventArgs e)
        {
            var label = sender as Label;
            var amigo = label?.BindingContext as Amigo;

            if (amigo != null)
            {
                // Navega para a página de perfil do amigo
                await Navigation.PushAsync(new PerfilPage(amigo));
            }
        }

    }

    // Classe para representar um amigo
    public class Amigo
    {
        public string Nome { get; set; }
    }
}
