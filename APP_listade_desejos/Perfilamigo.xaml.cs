namespace APP_listade_desejos
{
    public partial class PerfilPage : ContentPage
    {
        public PerfilPage(Amigo amigo)
        {
            InitializeComponent();

            // Define o contexto de dados para que a interface tenha acesso aos dados do amigo
            BindingContext = amigo;
        }
    }
    
}