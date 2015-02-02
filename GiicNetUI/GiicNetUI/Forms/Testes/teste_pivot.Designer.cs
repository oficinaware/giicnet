namespace GiicNetUI.Forms.Testes
{
    partial class teste_pivot
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dataGiicNetDataSet = new GiicNetUI.DataGiicNetDataSet();
            this.dataGiicNetDataSetBindingSource = new System.Windows.Forms.BindingSource();
            this.cLIENTESBRBindingSource = new System.Windows.Forms.BindingSource();
            this.cLIENTES_BRTableAdapter = new GiicNetUI.DataGiicNetDataSetTableAdapters.CLIENTES_BRTableAdapter();
            this.colCLIENTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDTINI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOMEABR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONTACTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODPOST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPAIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPAIS_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZONA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZONA_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOCAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNRCONT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLASSE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCALSSE_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINACTIVO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATA_INACTIVO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGiicNetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGiicNetDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBRBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cLIENTESBRBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1370, 631);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCLIENTE,
            this.colDTINI,
            this.colNOME,
            this.colNOMEABR,
            this.colCONTACTO,
            this.colCODPOST,
            this.colPAIS,
            this.colPAIS_DESC,
            this.colZONA,
            this.colZONA_DESC,
            this.colLOCAL,
            this.colcee,
            this.colNRCONT,
            this.colCLASSE,
            this.colCALSSE_DESC,
            this.colINACTIVO,
            this.colDATA_INACTIVO});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "PAIS", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // dataGiicNetDataSet
            // 
            this.dataGiicNetDataSet.DataSetName = "DataGiicNetDataSet";
            this.dataGiicNetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGiicNetDataSetBindingSource
            // 
            this.dataGiicNetDataSetBindingSource.DataSource = this.dataGiicNetDataSet;
            this.dataGiicNetDataSetBindingSource.Position = 0;
            // 
            // cLIENTESBRBindingSource
            // 
            this.cLIENTESBRBindingSource.DataMember = "CLIENTES_BR";
            this.cLIENTESBRBindingSource.DataSource = this.dataGiicNetDataSetBindingSource;
            // 
            // cLIENTES_BRTableAdapter
            // 
            this.cLIENTES_BRTableAdapter.ClearBeforeFill = true;
            // 
            // colCLIENTE
            // 
            this.colCLIENTE.FieldName = "CLIENTE";
            this.colCLIENTE.Name = "colCLIENTE";
            this.colCLIENTE.Visible = true;
            this.colCLIENTE.VisibleIndex = 0;
            // 
            // colDTINI
            // 
            this.colDTINI.FieldName = "DTINI";
            this.colDTINI.Name = "colDTINI";
            this.colDTINI.Visible = true;
            this.colDTINI.VisibleIndex = 1;
            // 
            // colNOME
            // 
            this.colNOME.FieldName = "NOME";
            this.colNOME.Name = "colNOME";
            this.colNOME.Visible = true;
            this.colNOME.VisibleIndex = 2;
            // 
            // colNOMEABR
            // 
            this.colNOMEABR.FieldName = "NOMEABR";
            this.colNOMEABR.Name = "colNOMEABR";
            this.colNOMEABR.Visible = true;
            this.colNOMEABR.VisibleIndex = 3;
            // 
            // colCONTACTO
            // 
            this.colCONTACTO.FieldName = "CONTACTO";
            this.colCONTACTO.Name = "colCONTACTO";
            this.colCONTACTO.Visible = true;
            this.colCONTACTO.VisibleIndex = 4;
            // 
            // colCODPOST
            // 
            this.colCODPOST.FieldName = "CODPOST";
            this.colCODPOST.Name = "colCODPOST";
            this.colCODPOST.Visible = true;
            this.colCODPOST.VisibleIndex = 5;
            // 
            // colPAIS
            // 
            this.colPAIS.FieldName = "PAIS";
            this.colPAIS.Name = "colPAIS";
            this.colPAIS.Visible = true;
            this.colPAIS.VisibleIndex = 6;
            // 
            // colPAIS_DESC
            // 
            this.colPAIS_DESC.FieldName = "PAIS_DESC";
            this.colPAIS_DESC.Name = "colPAIS_DESC";
            this.colPAIS_DESC.Visible = true;
            this.colPAIS_DESC.VisibleIndex = 7;
            // 
            // colZONA
            // 
            this.colZONA.FieldName = "ZONA";
            this.colZONA.Name = "colZONA";
            this.colZONA.Visible = true;
            this.colZONA.VisibleIndex = 8;
            // 
            // colZONA_DESC
            // 
            this.colZONA_DESC.FieldName = "ZONA_DESC";
            this.colZONA_DESC.Name = "colZONA_DESC";
            this.colZONA_DESC.Visible = true;
            this.colZONA_DESC.VisibleIndex = 9;
            // 
            // colLOCAL
            // 
            this.colLOCAL.FieldName = "LOCAL";
            this.colLOCAL.Name = "colLOCAL";
            this.colLOCAL.Visible = true;
            this.colLOCAL.VisibleIndex = 10;
            // 
            // colcee
            // 
            this.colcee.FieldName = "cee";
            this.colcee.Name = "colcee";
            this.colcee.Visible = true;
            this.colcee.VisibleIndex = 11;
            // 
            // colNRCONT
            // 
            this.colNRCONT.FieldName = "NRCONT";
            this.colNRCONT.Name = "colNRCONT";
            this.colNRCONT.Visible = true;
            this.colNRCONT.VisibleIndex = 12;
            // 
            // colCLASSE
            // 
            this.colCLASSE.FieldName = "CLASSE";
            this.colCLASSE.Name = "colCLASSE";
            this.colCLASSE.Visible = true;
            this.colCLASSE.VisibleIndex = 13;
            // 
            // colCALSSE_DESC
            // 
            this.colCALSSE_DESC.FieldName = "CALSSE_DESC";
            this.colCALSSE_DESC.Name = "colCALSSE_DESC";
            this.colCALSSE_DESC.Visible = true;
            this.colCALSSE_DESC.VisibleIndex = 14;
            // 
            // colINACTIVO
            // 
            this.colINACTIVO.FieldName = "INACTIVO";
            this.colINACTIVO.Name = "colINACTIVO";
            this.colINACTIVO.Visible = true;
            this.colINACTIVO.VisibleIndex = 15;
            // 
            // colDATA_INACTIVO
            // 
            this.colDATA_INACTIVO.FieldName = "DATA_INACTIVO";
            this.colDATA_INACTIVO.Name = "colDATA_INACTIVO";
            this.colDATA_INACTIVO.Visible = true;
            this.colDATA_INACTIVO.VisibleIndex = 16;
            // 
            // teste_pivot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 728);
            this.Controls.Add(this.gridControl1);
            this.Name = "teste_pivot";
            this.Text = "Teste_Pivot";
            this.Load += new System.EventHandler(this.teste_pivot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGiicNetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGiicNetDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBRBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource dataGiicNetDataSetBindingSource;
        private DataGiicNetDataSet dataGiicNetDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource cLIENTESBRBindingSource;
        private DataGiicNetDataSetTableAdapters.CLIENTES_BRTableAdapter cLIENTES_BRTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENTE;
        private DevExpress.XtraGrid.Columns.GridColumn colDTINI;
        private DevExpress.XtraGrid.Columns.GridColumn colNOME;
        private DevExpress.XtraGrid.Columns.GridColumn colNOMEABR;
        private DevExpress.XtraGrid.Columns.GridColumn colCONTACTO;
        private DevExpress.XtraGrid.Columns.GridColumn colCODPOST;
        private DevExpress.XtraGrid.Columns.GridColumn colPAIS;
        private DevExpress.XtraGrid.Columns.GridColumn colPAIS_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colZONA;
        private DevExpress.XtraGrid.Columns.GridColumn colZONA_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colLOCAL;
        private DevExpress.XtraGrid.Columns.GridColumn colcee;
        private DevExpress.XtraGrid.Columns.GridColumn colNRCONT;
        private DevExpress.XtraGrid.Columns.GridColumn colCLASSE;
        private DevExpress.XtraGrid.Columns.GridColumn colCALSSE_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colINACTIVO;
        private DevExpress.XtraGrid.Columns.GridColumn colDATA_INACTIVO;

    }
}