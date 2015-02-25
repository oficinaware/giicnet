namespace GiicNetUI.Comum.Forms.Base.TabRETENCOES
{
    partial class formTABRETENCOES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTABRETENCOES));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.COD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DESCRICAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TAXA = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl1.Size = new System.Drawing.Size(371, 432);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.COD,
            this.TIPO,
            this.DESCRICAO,
            this.TAXA});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // COD
            // 
            this.COD.Caption = "Cod.";
            this.COD.FieldName = "COD";
            this.COD.Name = "COD";
            this.COD.Visible = true;
            this.COD.VisibleIndex = 0;
            this.COD.Width = 35;
            // 
            // TIPO
            // 
            this.TIPO.Caption = "Tipo";
            this.TIPO.FieldName = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.Visible = true;
            this.TIPO.VisibleIndex = 1;
            this.TIPO.Width = 30;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.Caption = "Nome Aplicável";
            this.DESCRICAO.FieldName = "DESCRICAO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.Visible = true;
            this.DESCRICAO.VisibleIndex = 2;
            this.DESCRICAO.Width = 235;
            // 
            // TAXA
            // 
            this.TAXA.Caption = "Taxa";
            this.TAXA.FieldName = "TAXA";
            this.TAXA.Name = "TAXA";
            this.TAXA.Visible = true;
            this.TAXA.VisibleIndex = 3;
            this.TAXA.Width = 53;
            // 
            // formTABRETENCOES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 432);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formTABRETENCOES";
            this.Text = "Tabela de Retenções na Fonte";
            this.Load += new System.EventHandler(this.formTABRETENCOES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn COD;
        private DevExpress.XtraGrid.Columns.GridColumn TIPO;
        private DevExpress.XtraGrid.Columns.GridColumn DESCRICAO;
        private DevExpress.XtraGrid.Columns.GridColumn TAXA;
    }
}