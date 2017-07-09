using ControladorDePedidos.Model;
using ControladorDePedidos.Repositorio;
using System.Windows;

namespace ControladorDePedidos.WPF
{
    public partial class FormClientes : Window
    {
        RepositorioCliente repositorio;

        public FormClientes()
        {
            repositorio = new RepositorioCliente();
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CarregueElemtosDoBancoDeDados();
        }

        private void CarregueElemtosDoBancoDeDados()
        {
            lstClientes.DataContext = repositorio.Liste();
        }

        private void btnNovo_Click(object sender, RoutedEventArgs e)
        {
            var formCadastroCliente = new FormCadastroDeCliente();
            formCadastroCliente.ShowDialog();
            CarregueElemtosDoBancoDeDados();
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (lstClientes.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item na lista");
            }
            else
            {
                var itemSelecionado = (Cliente)lstClientes.SelectedItem;
                var formCadastroCliente = new FormCadastroDeCliente(itemSelecionado);
                formCadastroCliente.ShowDialog();
                CarregueElemtosDoBancoDeDados();
            }
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            if (lstClientes.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item na lista");
            }
            else
            {
                var itemSelecionado = (Cliente)lstClientes.SelectedItem;
                repositorio.Excluir(itemSelecionado);
                CarregueElemtosDoBancoDeDados();
            }
        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            CarregueElemtosDoBancoDeDados();
        }

        private void btnRelatorio_Click(object sender, RoutedEventArgs e)
        {
            var forRelat = new FormRelatorioCliente();
            forRelat.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var forRelat = new FormBuscaDeClienteBuscar();
            forRelat.Show();
        }
    }
}
