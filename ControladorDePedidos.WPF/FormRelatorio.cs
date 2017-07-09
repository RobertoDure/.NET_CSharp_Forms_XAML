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
    public partial class FormRelatorio : Form
    {
        List<ItemDaVenda> list = new List<ItemDaVenda>();
        Venda vend = new Venda();
        public FormRelatorio()
        {
            InitializeComponent();
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ControladorDePedidos2DataSet6.Venda' table. You can move, or remove it, as needed.

            VendasCRUD crud = new VendasCRUD();
            List<Venda> lista = crud.ElemtosDoBancoDeDadosVenda();
   
                ReportDataSource rds = new ReportDataSource("DataSet1", lista);
                //ReportDataSource rds2 = new ReportDataSource("DataSet2", list);

                reportViewer1.Reset();
                reportViewer1.LocalReport.ReportEmbeddedResource = "ControladorDePedidos.WPF.ReportVendas.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();

                reportViewer1.LocalReport.DataSources.Add(rds);
                // reportViewer1.LocalReport.DataSources.Add(rds2);

                this.reportViewer1.RefreshReport();

        }
    }
}
