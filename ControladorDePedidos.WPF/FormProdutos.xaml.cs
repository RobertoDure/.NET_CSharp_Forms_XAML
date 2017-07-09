using ControladorDePedidos.Model;
using ControladorDePedidos.Repositorio;
using System.Windows;

namespace ControladorDePedidos.WPF
{
    public partial class FormProdutos : Window
    {
        RepositorioProduto repositorio;

        public FormProdutos()
        {
            repositorio = new RepositorioProduto();
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CarregueElemtosDoBancoDeDados();
        }

        private void CarregueElemtosDoBancoDeDados()
        {
            lstProdutos.DataContext = repositorio.Liste();
        }

        private void btnMarcas_Click(object sender, RoutedEventArgs e)
        {
            var formMarca = new FormMarcas();
            formMarca.Show();
        }

        private void btnNovo_Click(object sender, RoutedEventArgs e)
        {
            var formCadastroDeProduto = new FormCadastroDeProduto();
            formCadastroDeProduto.ShowDialog();
            CarregueElemtosDoBancoDeDados();
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if(lstProdutos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item");
                return;
            }

            var produto = (Produto)lstProdutos.SelectedItem;
            var formCadastroDeProduto = new FormCadastroDeProduto(produto);
            formCadastroDeProduto.ShowDialog();
            CarregueElemtosDoBancoDeDados();
        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            CarregueElemtosDoBancoDeDados();
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            if (lstProdutos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item");
                return;
            }

            var produto = (Produto)lstProdutos.SelectedItem;
            repositorio.Excluir(produto);
            CarregueElemtosDoBancoDeDados();
        }

        private void btnRelatorio_Click(object sender, RoutedEventArgs e)
        {
            var form = new FormRelatorioProdutos();
            form.Show();
        }
    }
}
