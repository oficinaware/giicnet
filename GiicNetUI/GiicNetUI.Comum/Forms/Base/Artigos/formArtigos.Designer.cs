namespace GiicNetUI.Comum.Forms.Base.Artigos
{
    partial class formArtigos
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
            this.ARTIGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FAMILIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DESCRICAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DESC_ABR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARTAZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UNMED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FORN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PRCCUST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PRCVND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DATAREVPRC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ESCALA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESERVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CODBARRAS = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl1.Size = new System.Drawing.Size(1512, 849);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ARTIGO,
            this.FAMILIA,
            this.DESCRICAO,
            this.DESC_ABR,
            this.CARTAZ,
            this.UNMED,
            this.FORN,
            this.PRCCUST,
            this.PRCVND,
            this.DATAREVPRC,
            this.ESCALA,
            this.RESERVA,
            this.CODBARRAS});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // ARTIGO
            // 
            this.ARTIGO.Caption = "Código Artigo";
            this.ARTIGO.FieldName = "ARTIGO";
            this.ARTIGO.Name = "ARTIGO";
            this.ARTIGO.Visible = true;
            this.ARTIGO.VisibleIndex = 0;
            this.ARTIGO.Width = 138;
            // 
            // FAMILIA
            // 
            this.FAMILIA.Caption = "Família";
            this.FAMILIA.Name = "FAMILIA";
            this.FAMILIA.Visible = true;
            this.FAMILIA.VisibleIndex = 1;
            this.FAMILIA.Width = 69;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.Caption = "Designação";
            this.DESCRICAO.FieldName = "DESCRICAO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.Visible = true;
            this.DESCRICAO.VisibleIndex = 2;
            this.DESCRICAO.Width = 347;
            // 
            // DESC_ABR
            // 
            this.DESC_ABR.Caption = "Desc. Abrev.";
            this.DESC_ABR.FieldName = "DESC_ABR";
            this.DESC_ABR.Name = "DESC_ABR";
            this.DESC_ABR.Visible = true;
            this.DESC_ABR.VisibleIndex = 3;
            this.DESC_ABR.Width = 138;
            // 
            // CARTAZ
            // 
            this.CARTAZ.Caption = "Cartaz";
            this.CARTAZ.FieldName = "CARTAZ";
            this.CARTAZ.Name = "CARTAZ";
            this.CARTAZ.Visible = true;
            this.CARTAZ.VisibleIndex = 4;
            this.CARTAZ.Width = 55;
            // 
            // UNMED
            // 
            this.UNMED.Caption = "Un. Med.";
            this.UNMED.FieldName = "UNMED";
            this.UNMED.Name = "UNMED";
            this.UNMED.Visible = true;
            this.UNMED.VisibleIndex = 5;
            this.UNMED.Width = 55;
            // 
            // FORN
            // 
            this.FORN.Caption = "Fornecedor";
            this.FORN.FieldName = "FORN";
            this.FORN.Name = "FORN";
            this.FORN.Visible = true;
            this.FORN.VisibleIndex = 6;
            this.FORN.Width = 138;
            // 
            // PRCCUST
            // 
            this.PRCCUST.Caption = "Preço Custo";
            this.PRCCUST.FieldName = "PRCCUST";
            this.PRCCUST.Name = "PRCCUST";
            this.PRCCUST.Visible = true;
            this.PRCCUST.VisibleIndex = 7;
            this.PRCCUST.Width = 69;
            // 
            // PRCVND
            // 
            this.PRCVND.Caption = "Preço Venda";
            this.PRCVND.FieldName = "PRCVND";
            this.PRCVND.Name = "PRCVND";
            this.PRCVND.Visible = true;
            this.PRCVND.VisibleIndex = 8;
            this.PRCVND.Width = 69;
            // 
            // DATAREVPRC
            // 
            this.DATAREVPRC.Caption = "Rev. Prc.";
            this.DATAREVPRC.FieldName = "DATAREVPRC";
            this.DATAREVPRC.Name = "DATAREVPRC";
            this.DATAREVPRC.Visible = true;
            this.DATAREVPRC.VisibleIndex = 9;
            this.DATAREVPRC.Width = 138;
            // 
            // ESCALA
            // 
            this.ESCALA.Caption = "Escala";
            this.ESCALA.FieldName = "ESCALA";
            this.ESCALA.Name = "ESCALA";
            this.ESCALA.Visible = true;
            this.ESCALA.VisibleIndex = 10;
            this.ESCALA.Width = 55;
            // 
            // RESERVA
            // 
            this.RESERVA.Caption = "Reserva";
            this.RESERVA.FieldName = "RESERVA";
            this.RESERVA.Name = "RESERVA";
            this.RESERVA.Visible = true;
            this.RESERVA.VisibleIndex = 12;
            this.RESERVA.Width = 50;
            // 
            // CODBARRAS
            // 
            this.CODBARRAS.Caption = "Cod. Barras";
            this.CODBARRAS.FieldName = "CODBARRAS";
            this.CODBARRAS.Name = "CODBARRAS";
            this.CODBARRAS.Visible = true;
            this.CODBARRAS.VisibleIndex = 11;
            this.CODBARRAS.Width = 111;
            // 
            // formArtigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 849);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formArtigos";
            this.Text = "formArtigos";
            this.Load += new System.EventHandler(this.formArtigos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ARTIGO;
        private DevExpress.XtraGrid.Columns.GridColumn FAMILIA;
        private DevExpress.XtraGrid.Columns.GridColumn DESCRICAO;
        private DevExpress.XtraGrid.Columns.GridColumn DESC_ABR;
        private DevExpress.XtraGrid.Columns.GridColumn CARTAZ;
        private DevExpress.XtraGrid.Columns.GridColumn UNMED;
        private DevExpress.XtraGrid.Columns.GridColumn FORN;
        private DevExpress.XtraGrid.Columns.GridColumn PRCCUST;
        private DevExpress.XtraGrid.Columns.GridColumn PRCVND;
        private DevExpress.XtraGrid.Columns.GridColumn DATAREVPRC;
        private DevExpress.XtraGrid.Columns.GridColumn ESCALA;
        private DevExpress.XtraGrid.Columns.GridColumn CODBARRAS;
        private DevExpress.XtraGrid.Columns.GridColumn RESERVA;
    }
}