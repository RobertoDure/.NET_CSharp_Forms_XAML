namespace ControladorDePedidos.WPF
{
    partial class FormRelatorioCompras
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
            this.CompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CompraTableAdapter = new ControladorDePedidos.WPF.ControladorDePedidos2DataSet6TableAdapters.CompraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ControladorDePedidos2DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CompraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ControladorDePedidos.WPF.ReportCompras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(704, 303);
            this.reportViewer1.TabIndex = 0;
            // 
            // ControladorDePedidos2DataSet6
            // 
            this.ControladorDePedidos2DataSet6.DataSetName = "ControladorDePedidos2DataSet6";
            this.ControladorDePedidos2DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CompraBindingSource
            // 
            this.CompraBindingSource.DataMember = "Compra";
            this.CompraBindingSource.DataSource = this.ControladorDePedidos2DataSet6;
            // 
            // CompraTableAdapter
            // 
            this.CompraTableAdapter.ClearBeforeFill = true;
            // 
            // FormRelatorioCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 303);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRelatorioCompras";
            this.Text = "FormRelatorioCompras";
            this.Load += new System.EventHandler(this.FormRelatorioCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ControladorDePedidos2DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CompraBindingSource;
        private ControladorDePedidos2DataSet6 ControladorDePedidos2DataSet6;
        private ControladorDePedidos2DataSet6TableAdapters.CompraTableAdapter CompraTableAdapter;
    }
}