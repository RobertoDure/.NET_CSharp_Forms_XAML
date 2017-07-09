using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ControladorDePedidos.Model;
using ControladorDePedidos.Repositorio;


namespace ControladorDePedidos.WPF
{
    /// <summary>
    /// Interaction logic for FormBuscaDeFornecedor.xaml
    /// </summary>
    public partial class FormBuscaDeFornecedor : Window
    {
        RepositorioFornecedor repositorio;
        public Fornecedor ClienteSelecionado { get; set; }

        public FormBuscaDeFornecedor()
        {
            InitializeComponent();
            repositorio = new RepositorioFornecedor();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CarregueElemtosDoBancoDeDados();
        }

        private void CarregueElemtosDoBancoDeDados()
        {
            lstClientes.DataContext = repositorio.Liste();
        }

        private void txtTermoDaBusca_KeyDown(object sender, KeyEventArgs e)
        {
            var listaDeClientes = repositorio.Buscar(txtTermoDaBusca.Text);
            lstClientes.DataContext = listaDeClientes;
        }

        private void btnSelecionar_Click(object sender, RoutedEventArgs e)
        {
            if (lstClientes.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item na lista");
                return;
            }

            // ClienteSelecionado = (Cliente)lstClientes.SelectedItem;

            var itemSelecionado = (Fornecedor)lstClientes.SelectedItem;
            var formCadastroCliente = new FormCadastroDeFornecedor(itemSelecionado);
            formCadastroCliente.ShowDialog();
            CarregueElemtosDoBancoDeDados();
        }
    }
}
