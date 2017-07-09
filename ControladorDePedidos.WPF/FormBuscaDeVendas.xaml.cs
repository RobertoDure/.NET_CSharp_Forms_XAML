﻿using System;
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
    /// Interaction logic for FormBuscaDeVendas.xaml
    /// </summary>
    public partial class FormBuscaDeVendas : Window
    {
        RepositorioVenda repositorio;
        public Fornecedor ClienteSelecionado { get; set; }

        public FormBuscaDeVendas()
        {
            InitializeComponent();
            repositorio = new RepositorioVenda();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CarregueElemtosDoBancoDeDados();
        }

        private void CarregueElemtosDoBancoDeDados()
        {
            lstVendas.DataContext = repositorio.Liste();
        }

        private void txtTermoDaBusca_KeyDown(object sender, KeyEventArgs e)
        {
            var listaDeClientes = repositorio.Buscar(txtTermoDaBusca.Text);
            lstVendas.DataContext = listaDeClientes;
        }

        private void btnSelecionar_Click(object sender, RoutedEventArgs e)
        {
            if (lstVendas.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item na lista");
                return;
            }

            var itemSelecionado = (Venda)lstVendas.SelectedItem;
            var formCadastroCliente = new FormCadastroDeVenda(itemSelecionado);
            formCadastroCliente.ShowDialog();
            CarregueElemtosDoBancoDeDados();
        }
    }
}