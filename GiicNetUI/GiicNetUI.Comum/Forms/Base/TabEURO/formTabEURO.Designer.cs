namespace GiicNetUI.Comum.Forms.Base.TabEURO
{
    partial class formTabEURO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTabEURO));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MOEDA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DESCRICAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COMPRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VENDA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DTCAMBIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DECIMAIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FACTOR = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(674, 551);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MOEDA,
            this.DESCRICAO,
            this.COMPRA,
            this.VENDA,
            this.DTCAMBIO,
            this.DECIMAIS,
            this.UEM,
            this.FACTOR});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.gridView1_RowDeleting);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // MOEDA
            // 
            this.MOEDA.Caption = "Moeda";
            this.MOEDA.FieldName = "MOEDA";
            this.MOEDA.Name = "MOEDA";
            this.MOEDA.Visible = true;
            this.MOEDA.VisibleIndex = 0;
            this.MOEDA.Width = 51;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.Caption = "Descritivo";
            this.DESCRICAO.FieldName = "DESCRICAO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.Visible = true;
            this.DESCRICAO.VisibleIndex = 1;
            this.DESCRICAO.Width = 180;
            // 
            // COMPRA
            // 
            this.COMPRA.Caption = "Valor Compra";
            this.COMPRA.FieldName = "COMPRA";
            this.COMPRA.Name = "COMPRA";
            this.COMPRA.Visible = true;
            this.COMPRA.VisibleIndex = 2;
            // 
            // VENDA
            // 
            this.VENDA.Caption = "Valor Venda";
            this.VENDA.FieldName = "VENDA";
            this.VENDA.Name = "VENDA";
            this.VENDA.Visible = true;
            this.VENDA.VisibleIndex = 3;
            // 
            // DTCAMBIO
            // 
            this.DTCAMBIO.Caption = "Data Cambio";
            this.DTCAMBIO.FieldName = "DTCAMBIO";
            this.DTCAMBIO.Name = "DTCAMBIO";
            this.DTCAMBIO.Visible = true;
            this.DTCAMBIO.VisibleIndex = 4;
            // 
            // DECIMAIS
            // 
            this.DECIMAIS.Caption = "Nr. Dec.";
            this.DECIMAIS.FieldName = "DECIMAIS";
            this.DECIMAIS.Name = "DECIMAIS";
            this.DECIMAIS.Visible = true;
            this.DECIMAIS.VisibleIndex = 5;
            this.DECIMAIS.Width = 50;
            // 
            // UEM
            // 
            this.UEM.Caption = "UEM";
            this.UEM.FieldName = "UEM";
            this.UEM.Name = "UEM";
            this.UEM.Visible = true;
            this.UEM.VisibleIndex = 6;
            this.UEM.Width = 40;
            // 
            // FACTOR
            // 
            this.FACTOR.Caption = "Taxa Conv. EURO";
            this.FACTOR.FieldName = "FACTOR";
            this.FACTOR.Name = "FACTOR";
            this.FACTOR.Visible = true;
            this.FACTOR.VisibleIndex = 7;
            this.FACTOR.Width = 110;
            // 
            // formTabEURO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 551);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formTabEURO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moedas";
            this.Load += new System.EventHandler(this.formTabEURO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MOEDA;
        private DevExpress.XtraGrid.Columns.GridColumn DESCRICAO;
        private DevExpress.XtraGrid.Columns.GridColumn COMPRA;
        private DevExpress.XtraGrid.Columns.GridColumn VENDA;
        private DevExpress.XtraGrid.Columns.GridColumn DTCAMBIO;
        private DevExpress.XtraGrid.Columns.GridColumn DECIMAIS;
        private DevExpress.XtraGrid.Columns.GridColumn UEM;
        private DevExpress.XtraGrid.Columns.GridColumn FACTOR;
    }
}