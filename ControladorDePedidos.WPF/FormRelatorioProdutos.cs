using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControladorDePedidos.Repositorio;
using ControladorDePedidos.Model;
using Microsoft.Reporting.WinForms;

namespace ControladorDePedidos.WPF
{
    public partial class FormRelatorioProdutos : Form
    {
        public FormRelatorioProdutos()
        {
            InitializeComponent();
        }

        private void FormRelatorioProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ControladorDePedidos2DataSet6.Produto' table. You can move, or remove it, as needed.
            ProdutosCRUD prod = new ProdutosCRUD();
            List<Produto> lista = prod.ElemtosDoBancoDeDadosProduto();

            ReportDataSource rds = new ReportDataSource("DataSet1", lista);
            //ReportDataSource rds2 = new ReportDataSource("DataSet2", list);

            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = "ControladorDePedidos.WPF.ReportProdutos.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(rds);
            // reportViewer1.LocalReport.DataSources.Add(rds2);

            this.reportViewer1.RefreshReport();
        }
    }
}
