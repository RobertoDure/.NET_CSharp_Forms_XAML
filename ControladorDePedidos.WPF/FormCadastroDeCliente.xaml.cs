using ControladorDePedidos.Model;
using ControladorDePedidos.Repositorio;
using System.Windows;

namespace ControladorDePedidos.WPF
{
    public partial class FormCadastroDeCliente : Window
    {
        public FormCadastroDeCliente()
        {
            InitializeComponent();
            this.DataContext = new Cliente();
        }

        public FormCadastroDeCliente(Cliente cliente)
        {
            InitializeComponent();
            this.DataContext = cliente;
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            var cliente = (Cliente)this.DataContext;
            var repositorio = new RepositorioCliente();

            if (this.txtCPF.Text != string.Empty && this.txtNome.Text != string.Empty && this.txtEndereco.Text != string.Empty && this.txtTelefone.Text != string.Empty)
            {
            if (cliente.Codigo == 0)
            {
                // Novo cadastro
                repositorio.Adicione(cliente); // Cadastrar no banco de dados
            }
            else
            {
                // Editando
                repositorio.Atualize(cliente); // Atualizar no banco de dados
            }
            }
            else
            {
                MessageBox.Show("Nenhum Campo pode ficar vazio.!!");
            }
            this.Close();
        }
    }
}
