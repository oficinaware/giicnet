namespace GiicNetUI.Comum.Forms.Base.TabPag
{
    partial class formTabPag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTabPag));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CNDPAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DESCRICAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NRDIAS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DESCONTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIAINI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIAPAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SENTIDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PRESTACOES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(741, 560);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CNDPAG,
            this.DESCRICAO,
            this.NRDIAS,
            this.DESCONTO,
            this.DIAINI,
            this.DIAPAG,
            this.SENTIDO,
            this.PRESTACOES});
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
            // CNDPAG
            // 
            this.CNDPAG.Caption = "Cond. Pag.";
            this.CNDPAG.FieldName = "CNDPAG";
            this.CNDPAG.Name = "CNDPAG";
            this.CNDPAG.Visible = true;
            this.CNDPAG.VisibleIndex = 0;
            this.CNDPAG.Width = 85;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.Caption = "Descrição *";
            this.DESCRICAO.FieldName = "DESCRICAO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.Visible = true;
            this.DESCRICAO.VisibleIndex = 1;
            this.DESCRICAO.Width = 252;
            // 
            // NRDIAS
            // 
            this.NRDIAS.Caption = "Nr. Dias *";
            this.NRDIAS.DisplayFormat.FormatString = "d0";
            this.NRDIAS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NRDIAS.FieldName = "NRDIAS";
            this.NRDIAS.Name = "NRDIAS";
            this.NRDIAS.Visible = true;
            this.NRDIAS.VisibleIndex = 2;
            this.NRDIAS.Width = 60;
            // 
            // DESCONTO
            // 
            this.DESCONTO.Caption = "Desconto %";
            this.DESCONTO.DisplayFormat.FormatString = "d1";
            this.DESCONTO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DESCONTO.FieldName = "DESCONTO";
            this.DESCONTO.Name = "DESCONTO";
            this.DESCONTO.Visible = true;
            this.DESCONTO.VisibleIndex = 3;
            this.DESCONTO.Width = 70;
            // 
            // DIAINI
            // 
            this.DIAINI.AppearanceCell.Options.UseTextOptions = true;
            this.DIAINI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DIAINI.Caption = "Dia Início";
            this.DIAINI.FieldName = "DIAINI";
            this.DIAINI.Name = "DIAINI";
            this.DIAINI.Visible = true;
            this.DIAINI.VisibleIndex = 4;
            this.DIAINI.Width = 60;
            // 
            // DIAPAG
            // 
            this.DIAPAG.AppearanceCell.Options.UseTextOptions = true;
            this.DIAPAG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DIAPAG.Caption = "Dia Fixo";
            this.DIAPAG.FieldName = "DIAPAG";
            this.DIAPAG.Name = "DIAPAG";
            this.DIAPAG.Visible = true;
            this.DIAPAG.VisibleIndex = 5;
            this.DIAPAG.Width = 60;
            // 
            // SENTIDO
            // 
            this.SENTIDO.AppearanceCell.Options.UseTextOptions = true;
            this.SENTIDO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SENTIDO.Caption = "Sentido";
            this.SENTIDO.FieldName = "SENTIDO";
            this.SENTIDO.Name = "SENTIDO";
            this.SENTIDO.Visible = true;
            this.SENTIDO.VisibleIndex = 6;
            this.SENTIDO.Width = 46;
            // 
            // PRESTACOES
            // 
            this.PRESTACOES.AppearanceCell.Options.UseTextOptions = true;
            this.PRESTACOES.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PRESTACOES.Caption = "Prestações";
            this.PRESTACOES.FieldName = "PRESTACOES";
            this.PRESTACOES.Name = "PRESTACOES";
            this.PRESTACOES.Visible = true;
            this.PRESTACOES.VisibleIndex = 7;
            this.PRESTACOES.Width = 90;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // formTabPag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 560);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formTabPag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Condições de Pagamento";
            this.Load += new System.EventHandler(this.formTabPag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn CNDPAG;
        private DevExpress.XtraGrid.Columns.GridColumn DESCRICAO;
        private DevExpress.XtraGrid.Columns.GridColumn NRDIAS;
        private DevExpress.XtraGrid.Columns.GridColumn DESCONTO;
        private DevExpress.XtraGrid.Columns.GridColumn DIAINI;
        private DevExpress.XtraGrid.Columns.GridColumn DIAPAG;
        private DevExpress.XtraGrid.Columns.GridColumn SENTIDO;
        private DevExpress.XtraGrid.Columns.GridColumn PRESTACOES;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    }
}