namespace ControladorDePedidos.WPF
{
    partial class FormRelatorio
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
            this.VendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ControladorDePedidos2DataSet6 = new ControladorDePedidos.WPF.ControladorDePedidos2DataSet6();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VendaTableAdapter = new ControladorDePedidos.WPF.ControladorDePedidos2DataSet6TableAdapters.VendaTableAdapter();
            this.vendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.VendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControladorDePedidos2DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // VendaBindingSource
            // 
            this.VendaBindingSource.DataMember = "Venda";
            this.VendaBindingSource.DataSource = this.ControladorDePedidos2DataSet6;
            // 
            // ControladorDePedidos2DataSet6
            // 
            this.ControladorDePedidos2DataSet6.DataSetName = "ControladorDePedidos2DataSet6";
            this.ControladorDePedidos2DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ControladorDePedidos.WPF.ReportVendas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(735, 316);
            this.reportViewer1.TabIndex = 0;
            // 
            // VendaTableAdapter
            // 
            this.VendaTableAdapter.ClearBeforeFill = true;
            // 
            // vendaBindingSource1
            // 
            this.vendaBindingSource1.DataMember = "Venda";
            this.vendaBindingSource1.DataSource = this.ControladorDePedidos2DataSet6;
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 316);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRelatorio";
            this.Text = "FormRelatorio";
            this.Load += new System.EventHandler(this.FormRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControladorDePedidos2DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VendaBindingSource;
        private ControladorDePedidos2DataSet6 ControladorDePedidos2DataSet6;
        private ControladorDePedidos2DataSet6TableAdapters.VendaTableAdapter VendaTableAdapter;
        private System.Windows.Forms.BindingSource vendaBindingSource1;
    }
}