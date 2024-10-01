namespace APP_listade_desejos
{
    public partial class MainFlyoutPage : FlyoutPage
    {
        public MainFlyoutPage()
        {
            InitializeComponent();
        }

        // Evento disparado quando um item do menu é selecionado
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MenuItemModel;
            if (item != null)
            {
                // Altera o conteúdo principal da página
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                IsPresented = false; // Fecha o menu lateral
            }
        }
    }

    // Modelo de item de menu
    public class MenuItemModel
    {
        public string Title { get; set; }
        public Type TargetType { get; set; }
    }
}