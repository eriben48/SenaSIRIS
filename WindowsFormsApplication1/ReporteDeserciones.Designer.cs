namespace WindowsFormsApplication1
{
    partial class ReporteDeserciones
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
            this.dataSet1 = new System.Data.DataSet();
            this.SIRISDataSet = new WindowsFormsApplication1.SIRISDataSet();
            this.ProcesoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProcesoTableAdapter = new WindowsFormsApplication1.SIRISDataSetTableAdapters.ProcesoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SIRISDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcesoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProcesoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(440, 379);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // SIRISDataSet
            // 
            this.SIRISDataSet.DataSetName = "SIRISDataSet";
            this.SIRISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProcesoBindingSource
            // 
            this.ProcesoBindingSource.DataMember = "Proceso";
            this.ProcesoBindingSource.DataSource = this.SIRISDataSet;
            // 
            // ProcesoTableAdapter
            // 
            this.ProcesoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteDeserciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 379);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteDeserciones";
            this.Text = "Reporte Deserciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReporteDeserciones_FormClosed);
            this.Load += new System.EventHandler(this.ReporteDeserciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SIRISDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcesoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.BindingSource ProcesoBindingSource;
        private SIRISDataSet SIRISDataSet;
        private SIRISDataSetTableAdapters.ProcesoTableAdapter ProcesoTableAdapter;
    }
}