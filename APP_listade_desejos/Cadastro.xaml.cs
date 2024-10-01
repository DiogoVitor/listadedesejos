namespace APP_listade_desejos
{
    public partial class Cadastro
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        // Evento disparado ao clicar no botão "Cadastrar"
        private void OnRegisterClicked(object sender, EventArgs e)
        {
            string nome = NameEntry.Text;
            string email = EmailEntry.Text;
            string senha = PasswordEntry.Text;
            string telefone = PhoneEntry.Text;
            string sexo = SexoEntry.Text;
            string estado = EstadoEntry.Text;
            string cidade = CidadeEntry.Text;

            // Verifica se todos os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(senha) ||
                string.IsNullOrWhiteSpace(telefone) ||
                string.IsNullOrWhiteSpace(sexo) ||
                string.IsNullOrWhiteSpace(estado) ||
                string.IsNullOrWhiteSpace(cidade))
            {
               ResultLabel.Text = "Preencha todos os campos!";
                ResultLabel.TextColor = Colors.Red;
                ResultLabel.IsVisible = true;
                return;
            }

            // Simula sucesso no cadastro
            ResultLabel.Text = "Cadastro realizado com sucesso!";
            ResultLabel.TextColor = Colors.Green;
            ResultLabel.IsVisible = true;

            // Limpa os campos de entrada
            NameEntry.Text = string.Empty;
            EmailEntry.Text = string.Empty;
            PasswordEntry.Text = string.Empty;
            PhoneEntry.Text = string.Empty;
            SexoEntry.Text = string.Empty;
            EstadoEntry.Text = string.Empty;
            CidadeEntry.Text = string.Empty;
        }
    }
}