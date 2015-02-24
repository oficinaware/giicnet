namespace GiicNetUI.Comum.Forms.Base.TabCONTASBAN
{
    partial class formCONTASBAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCONTASBAN));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_CONTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NIB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SWIFTCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CODAGENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DESCRICAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TELEF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FAX = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl1.Size = new System.Drawing.Size(904, 522);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_CONTA,
            this.IBAN,
            this.NIB,
            this.SWIFTCODE,
            this.CODAGENCIA,
            this.DESCRICAO,
            this.TELEF,
            this.FAX});
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
            // ID_CONTA
            // 
            this.ID_CONTA.Caption = "Id. Conta";
            this.ID_CONTA.FieldName = "ID_CONTA";
            this.ID_CONTA.Name = "ID_CONTA";
            this.ID_CONTA.Visible = true;
            this.ID_CONTA.VisibleIndex = 0;
            this.ID_CONTA.Width = 60;
            // 
            // IBAN
            // 
            this.IBAN.Caption = "IBAN";
            this.IBAN.FieldName = "IBAN";
            this.IBAN.Name = "IBAN";
            this.IBAN.Visible = true;
            this.IBAN.VisibleIndex = 1;
            this.IBAN.Width = 160;
            // 
            // NIB
            // 
            this.NIB.Caption = "NIB";
            this.NIB.FieldName = "NIB";
            this.NIB.Name = "NIB";
            this.NIB.Visible = true;
            this.NIB.VisibleIndex = 2;
            this.NIB.Width = 139;
            // 
            // SWIFTCODE
            // 
            this.SWIFTCODE.Caption = "SwiftCode";
            this.SWIFTCODE.FieldName = "SWIFTCODE";
            this.SWIFTCODE.Name = "SWIFTCODE";
            this.SWIFTCODE.Visible = true;
            this.SWIFTCODE.VisibleIndex = 3;
            this.SWIFTCODE.Width = 100;
            // 
            // CODAGENCIA
            // 
            this.CODAGENCIA.Caption = "Cod. Agência";
            this.CODAGENCIA.FieldName = "CODAGENCIA";
            this.CODAGENCIA.Name = "CODAGENCIA";
            this.CODAGENCIA.Visible = true;
            this.CODAGENCIA.VisibleIndex = 4;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.Caption = "Nome";
            this.DESCRICAO.FieldName = "DESCRICAO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.Visible = true;
            this.DESCRICAO.VisibleIndex = 5;
            this.DESCRICAO.Width = 150;
            // 
            // TELEF
            // 
            this.TELEF.Caption = "Telefone";
            this.TELEF.FieldName = "TELEX";
            this.TELEF.Name = "TELEF";
            this.TELEF.Visible = true;
            this.TELEF.VisibleIndex = 6;
            this.TELEF.Width = 100;
            // 
            // FAX
            // 
            this.FAX.Caption = "Fax";
            this.FAX.FieldName = "FAX";
            this.FAX.Name = "FAX";
            this.FAX.Visible = true;
            this.FAX.VisibleIndex = 7;
            this.FAX.Width = 102;
            // 
            // formCONTASBAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 522);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCONTASBAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas de Bancos";
            this.Load += new System.EventHandler(this.formCONTASBAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID_CONTA;
        private DevExpress.XtraGrid.Columns.GridColumn IBAN;
        private DevExpress.XtraGrid.Columns.GridColumn NIB;
        private DevExpress.XtraGrid.Columns.GridColumn SWIFTCODE;
        private DevExpress.XtraGrid.Columns.GridColumn CODAGENCIA;
        private DevExpress.XtraGrid.Columns.GridColumn DESCRICAO;
        private DevExpress.XtraGrid.Columns.GridColumn TELEF;
        private DevExpress.XtraGrid.Columns.GridColumn FAX;
    }
}