using System.Collections.ObjectModel;

namespace APP_listade_desejos
{
    public partial class Principal : ContentPage
    {
        public ObservableCollection<WishItem> WishItems { get; set; }

        public Principal()
        {
            InitializeComponent();
            
            // Inicializa a lista de desejos
            WishItems = new ObservableCollection<WishItem>();
            wishListView.ItemsSource = WishItems;
        }

        // Evento para adicionar um item à lista
        private void OnAddItemClicked(object sender, EventArgs e)
        {
            var newItem = wishEntry.Text;

            if (!string.IsNullOrWhiteSpace(newItem))
            {
                WishItems.Add(new WishItem { Name = newItem });
                wishEntry.Text = string.Empty;  // Limpa o campo de entrada
            }
        }

        // Evento para remover um item da lista
        private void OnRemoveItemClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var itemToRemove = button?.CommandParameter as WishItem;

            if (itemToRemove != null)
            {
                WishItems.Remove(itemToRemove);
            }
        }

        // Evento para remover todos os itens da lista
        private void OnRemoveAllClicked(object sender, EventArgs e)
        {
            WishItems.Clear();  // Limpa toda a lista de desejos
        }
    }

    // Classe para representar um item da lista de desejos
    public class WishItem
    {
        public string Name { get; set; }
    }
}