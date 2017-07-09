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

namespace ControladorDePedidos.WPF
{
    /// <summary>
    /// Interaction logic for FormBuscaCliente.xaml
    /// </summary>
    public partial class FormBuscaCliente : Window
    {
        public FormBuscaCliente()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            ControladorDePedidos.WPF.ControladorDePedidos2DataSet controladorDePedidos2DataSet = ((ControladorDePedidos.WPF.ControladorDePedidos2DataSet)(this.FindResource("controladorDePedidos2DataSet")));
            // Load data into the table Cliente. You can modify this code as needed.
            ControladorDePedidos.WPF.ControladorDePedidos2DataSetTableAdapters.ClienteTableAdapter controladorDePedidos2DataSetClienteTableAdapter = new ControladorDePedidos.WPF.ControladorDePedidos2DataSetTableAdapters.ClienteTableAdapter();
            controladorDePedidos2DataSetClienteTableAdapter.Fill(controladorDePedidos2DataSet.Cliente);
            System.Windows.Data.CollectionViewSource clienteViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("clienteViewSource")));
            clienteViewSource.View.MoveCurrentToFirst();
        }

        private void btBuscaCliente_Click(object sender, RoutedEventArgs e)
        {
         
        }
    }
}
