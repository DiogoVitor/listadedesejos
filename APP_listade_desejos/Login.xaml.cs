namespace APP_listade_desejos
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        // Evento para Logar
        private void OnLoginClicked(object sender, EventArgs e)
        {
            string email = emailEntry.Text;
            string senha = passwordEntry.Text;

            // Validação simples para campos preenchidos
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                resultLabel.Text = "Por favor, preencha todos os campos.";
                resultLabel.TextColor = Colors.Red;
                resultLabel.IsVisible = true;
                return;
            }

            // Simula uma tentativa de login
            if (email == "teste@teste.com" && senha == "12345")
            {
                resultLabel.Text = "Login bem-sucedido!";
                resultLabel.TextColor = Colors.Green;
            }
            else
            {
                resultLabel.Text = "Email ou senha incorretos.";
                resultLabel.TextColor = Colors.Red;
            }

            resultLabel.IsVisible = true;
        }

        // Evento para o botão "Esqueceu a senha?"
        private void OnForgotPasswordClicked(object sender, EventArgs e)
        {
            DisplayAlert("Recuperar Senha", "Um link de recuperação foi enviado para seu email.", "OK");
        }

        // Evento para o botão "Criar Conta"
        private void OnCreateAccountClicked(object sender, EventArgs e)
        {
            // Navegar para a página de cadastro
            Navigation.PushAsync(new Cadastro());
        }
    }
}