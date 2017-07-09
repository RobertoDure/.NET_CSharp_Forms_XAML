using ControladorDePedidos.Model;
using ControladorDePedidos.Repositorio;
using System.Windows;

namespace ControladorDePedidos.WPF
{
    public partial class FormCadastroDeFornecedor : Window
    {
        public int Codigo { get; set; }
        public FormCadastroDeFornecedor()
        {
            InitializeComponent();
        }

        public FormCadastroDeFornecedor(Fornecedor fornecedor)
        {
            InitializeComponent();
            Codigo = fornecedor.Codigo;
            txtNome.Text = fornecedor.Nome;
            txtEmail.Text = fornecedor.Email;
            txtCNPJ.Text = fornecedor.CNPJ;
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            var codigo = Codigo;
            var nome = txtNome.Text;
            var email = txtEmail.Text;
            var cnpj = txtCNPJ.Text;
            var repositorio = new RepositorioFornecedor();

              if (this.txtNome.Text != string.Empty && this.txtEmail.Text != string.Empty && this.txtCNPJ.Text != string.Empty)
            {
            if (codigo == 0)
            {
                // Novo cadastro
                var fornecedor = new Fornecedor
                {
                    Nome = nome,
                    Email = email,
                    CNPJ = cnpj
                };

                repositorio.Adicione(fornecedor); // Cadastrar no banco de dados
            }
            else
            {
                // Editando
                var fornecedor = new Fornecedor
                {
                    Codigo = codigo,
                    Nome = nome,
                    Email = email,
                    CNPJ = cnpj
                };

                repositorio.Atualize(fornecedor); // Atualizar no banco de dados
            }
              }else{
                    MessageBox.Show("Nenhum Campo pode ficar vazio.!!");
              }
            this.Close();
        }
    }
}
