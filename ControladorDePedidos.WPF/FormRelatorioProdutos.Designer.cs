namespace ControladorDePedidos.WPF
{
    partial class FormRelatorioProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ControladorDePedidos2DataSet6 = new ControladorDePedidos.WPF.ControladorDePedidos2DataSet6();
            this.ProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProdutoTableAdapter = new ControladorDePedidos.WPF.ControladorDePedidos2DataSet6TableAdapters.ProdutoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ControladorDePedidos2DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProdutoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ControladorDePedidos.WPF.ReportProdutos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(768, 322);
            this.reportViewer1.TabIndex = 0;
            // 
            // ControladorDePedidos2DataSet6
            // 
            this.ControladorDePedidos2DataSet6.DataSetName = "ControladorDePedidos2DataSet6";
            this.ControladorDePedidos2DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProdutoBindingSource
            // 
            this.ProdutoBindingSource.DataMember = "Produto";
            this.ProdutoBindingSource.DataSource = this.ControladorDePedidos2DataSet6;
            // 
            // ProdutoTableAdapter
            // 
            this.ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // FormRelatorioProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 322);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRelatorioProdutos";
            this.Text = "FormRelatorioProdutos";
            this.Load += new System.EventHandler(this.FormRelatorioProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ControladorDePedidos2DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProdutoBindingSource;
        private ControladorDePedidos2DataSet6 ControladorDePedidos2DataSet6;
        private ControladorDePedidos2DataSet6TableAdapters.ProdutoTableAdapter ProdutoTableAdapter;
    }
}