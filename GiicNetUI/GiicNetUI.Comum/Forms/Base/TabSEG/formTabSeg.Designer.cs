namespace GiicNetUI.Comum.Forms.Base.TabSEG
{
    partial class formTabSeg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTabSeg));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CODSEG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONTACTO = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl1.Size = new System.Drawing.Size(751, 538);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CODSEG,
            this.NOME,
            this.CONTACTO,
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
            // CODSEG
            // 
            this.CODSEG.Caption = "Cod.";
            this.CODSEG.FieldName = "CODSEG";
            this.CODSEG.Name = "CODSEG";
            this.CODSEG.Visible = true;
            this.CODSEG.VisibleIndex = 0;
            this.CODSEG.Width = 36;
            // 
            // NOME
            // 
            this.NOME.Caption = "Nome";
            this.NOME.FieldName = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.Visible = true;
            this.NOME.VisibleIndex = 1;
            this.NOME.Width = 228;
            // 
            // CONTACTO
            // 
            this.CONTACTO.Caption = "Contacto";
            this.CONTACTO.FieldName = "CONTACTO";
            this.CONTACTO.Name = "CONTACTO";
            this.CONTACTO.Visible = true;
            this.CONTACTO.VisibleIndex = 2;
            this.CONTACTO.Width = 150;
            // 
            // TELEF
            // 
            this.TELEF.Caption = "Telefone";
            this.TELEF.FieldName = "TELEF";
            this.TELEF.Name = "TELEF";
            this.TELEF.Visible = true;
            this.TELEF.VisibleIndex = 3;
            this.TELEF.Width = 150;
            // 
            // FAX
            // 
            this.FAX.Caption = "Fax";
            this.FAX.FieldName = "FAX";
            this.FAX.Name = "FAX";
            this.FAX.Visible = true;
            this.FAX.VisibleIndex = 4;
            this.FAX.Width = 150;
            // 
            // formTabSeg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 538);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formTabSeg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela de Seguradoras";
            this.Load += new System.EventHandler(this.formTabSeg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn CODSEG;
        private DevExpress.XtraGrid.Columns.GridColumn NOME;
        private DevExpress.XtraGrid.Columns.GridColumn CONTACTO;
        private DevExpress.XtraGrid.Columns.GridColumn TELEF;
        private DevExpress.XtraGrid.Columns.GridColumn FAX;
    }
}