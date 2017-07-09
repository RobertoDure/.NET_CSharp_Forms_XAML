using ControladorDePedidos.Model;
using ControladorDePedidos.Repositorio;
using System.Windows;

namespace ControladorDePedidos.WPF
{
    public partial class FormCadastroDeUsuario : Window
    {
        public FormCadastroDeUsuario()
        {
            InitializeComponent();
            this.DataContext = new Usuario();
        }

        public FormCadastroDeUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.DataContext = usuario;
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            var usuario = (Usuario)this.DataContext;
            var repositorio = new RepositorioUsuario();

            if (usuario.Codigo == 0)
            {
                if (string.IsNullOrEmpty(txtSenha.Password))
                {
                    MessageBox.Show("As senhas devem ser informada");
                    return;
                }
            }

            if (txtSenha.Password != txtConfirmaSenha.Password)
            {
                MessageBox.Show("As senhas devem ser iguais");
                return;
            }

            if (usuario.Codigo == 0 || !string.IsNullOrEmpty(txtSenha.Password))
            {
                usuario.Senha = txtSenha.Password;
            }

            if (usuario.Codigo == 0)
            {
                // Novo cadastro
                repositorio.Adicione(usuario); // Cadastrar no banco de dados
            }
            else
            {
                // Editando
                repositorio.Atualize(usuario); // Atualizar no banco de dados
            }

            this.Close();
        }
    }
}
