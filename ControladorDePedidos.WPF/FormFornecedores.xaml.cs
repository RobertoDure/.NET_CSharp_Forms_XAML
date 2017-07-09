using ControladorDePedidos.Model;
using ControladorDePedidos.Repositorio;
using System.Windows;

namespace ControladorDePedidos.WPF
{
    public partial class FormFornecedores : Window
    {
        RepositorioFornecedor repositorio;

        public FormFornecedores()
        {
            repositorio = new RepositorioFornecedor();
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CarregueElemtosDoBancoDeDados();
        }

        private void CarregueElemtosDoBancoDeDados()
        {
            lstFornecedores.DataContext = repositorio.Liste();
        }

        private void btnNovo_Click(object sender, RoutedEventArgs e)
        {
            var formCadastroFornecedor = new FormCadastroDeFornecedor();
            formCadastroFornecedor.ShowDialog();
            CarregueElemtosDoBancoDeDados();
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if(lstFornecedores.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item na lista");
            }
            else
            {
                var itemSelecionado = (Fornecedor)lstFornecedores.SelectedItem;
                var formCadastroFornecedor = new FormCadastroDeFornecedor(itemSelecionado);
                formCadastroFornecedor.ShowDialog();
                CarregueElemtosDoBancoDeDados();
            }
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            if (lstFornecedores.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item na lista");
            }
            else
            {
                var itemSelecionado = (Fornecedor)lstFornecedores.SelectedItem;
                repositorio.Excluir(itemSelecionado);
                CarregueElemtosDoBancoDeDados();
            }
        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            CarregueElemtosDoBancoDeDados();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var form = new FormBuscaDeFornecedor();
            form.Show();
        }
    }
}
