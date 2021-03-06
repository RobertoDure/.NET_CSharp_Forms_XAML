﻿using ControladorDePedidos.Model;
using ControladorDePedidos.Repositorio;
using System.Windows;
using System.Windows.Input;

namespace ControladorDePedidos.WPF
{
    public partial class FormBuscaDeCliente : Window
    {
        RepositorioCliente repositorio;
        public Cliente ClienteSelecionado { get; set; }

        public FormBuscaDeCliente()
        {
            InitializeComponent();
            repositorio = new RepositorioCliente();
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
            if(lstClientes.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item na lista");
                return;
            }

            ClienteSelecionado = (Cliente)lstClientes.SelectedItem;
            this.Close();
        }
    }
}
