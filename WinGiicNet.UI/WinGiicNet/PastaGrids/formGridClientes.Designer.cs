namespace WinGiicNet.PastaGrids
{
    partial class formGridClientes
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
            this.CLIENTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOMEABR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CLASSE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PAIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ZONA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AGENTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NRCONT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TELEF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TELEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COD_CTB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.INATIVO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DATA_INATIVO = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl1.Size = new System.Drawing.Size(1932, 1092);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CLIENTE,
            this.NOME,
            this.NOMEABR,
            this.CLASSE,
            this.PAIS,
            this.ZONA,
            this.AGENTE,
            this.NRCONT,
            this.TELEF,
            this.TELEX,
            this.COD_CTB,
            this.INATIVO,
            this.DATA_INATIVO});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // CLIENTE
            // 
            this.CLIENTE.Caption = "Cliente";
            this.CLIENTE.FieldName = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.Visible = true;
            this.CLIENTE.VisibleIndex = 0;
            this.CLIENTE.Width = 52;
            // 
            // NOME
            // 
            this.NOME.Caption = "Nome";
            this.NOME.FieldName = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.Visible = true;
            this.NOME.VisibleIndex = 1;
            this.NOME.Width = 235;
            // 
            // NOMEABR
            // 
            this.NOMEABR.Caption = "Nome Abr.";
            this.NOMEABR.FieldName = "NOMEABR";
            this.NOMEABR.Name = "NOMEABR";
            this.NOMEABR.Visible = true;
            this.NOMEABR.VisibleIndex = 2;
            this.NOMEABR.Width = 80;
            // 
            // CLASSE
            // 
            this.CLASSE.Caption = "Classe";
            this.CLASSE.FieldName = "CLASSE";
            this.CLASSE.Name = "CLASSE";
            this.CLASSE.Visible = true;
            this.CLASSE.VisibleIndex = 3;
            this.CLASSE.Width = 37;
            // 
            // PAIS
            // 
            this.PAIS.Caption = "País";
            this.PAIS.FieldName = "PAIS";
            this.PAIS.Name = "PAIS";
            this.PAIS.Visible = true;
            this.PAIS.VisibleIndex = 4;
            this.PAIS.Width = 31;
            // 
            // ZONA
            // 
            this.ZONA.Caption = "Zona";
            this.ZONA.FieldName = "ZONA";
            this.ZONA.Name = "ZONA";
            this.ZONA.Visible = true;
            this.ZONA.VisibleIndex = 5;
            this.ZONA.Width = 31;
            // 
            // AGENTE
            // 
            this.AGENTE.Caption = "Age.";
            this.AGENTE.FieldName = "AGENTE";
            this.AGENTE.Name = "AGENTE";
            this.AGENTE.Visible = true;
            this.AGENTE.VisibleIndex = 6;
            this.AGENTE.Width = 31;
            // 
            // NRCONT
            // 
            this.NRCONT.Caption = "Nr. Contrib.";
            this.NRCONT.FieldName = "NRCONT";
            this.NRCONT.Name = "NRCONT";
            this.NRCONT.Visible = true;
            this.NRCONT.VisibleIndex = 7;
            this.NRCONT.Width = 80;
            // 
            // TELEF
            // 
            this.TELEF.Caption = "Telefone";
            this.TELEF.FieldName = "TELEF";
            this.TELEF.Name = "TELEF";
            this.TELEF.Visible = true;
            this.TELEF.VisibleIndex = 8;
            this.TELEF.Width = 90;
            // 
            // TELEX
            // 
            this.TELEX.Caption = "Email";
            this.TELEX.FieldName = "TELEX";
            this.TELEX.Name = "TELEX";
            this.TELEX.Visible = true;
            this.TELEX.VisibleIndex = 9;
            this.TELEX.Width = 151;
            // 
            // COD_CTB
            // 
            this.COD_CTB.Caption = "Cod. CTB";
            this.COD_CTB.FieldName = "COD_CTB";
            this.COD_CTB.Name = "COD_CTB";
            this.COD_CTB.Visible = true;
            this.COD_CTB.VisibleIndex = 10;
            this.COD_CTB.Width = 60;
            // 
            // INATIVO
            // 
            this.INATIVO.Caption = "Inativo";
            this.INATIVO.FieldName = "INATIVO";
            this.INATIVO.Name = "INATIVO";
            this.INATIVO.Visible = true;
            this.INATIVO.VisibleIndex = 11;
            this.INATIVO.Width = 40;
            // 
            // DATA_INATIVO
            // 
            this.DATA_INATIVO.Caption = "Data";
            this.DATA_INATIVO.FieldName = "DATA_INATIVO";
            this.DATA_INATIVO.Name = "DATA_INATIVO";
            this.DATA_INATIVO.Visible = true;
            this.DATA_INATIVO.VisibleIndex = 12;
            this.DATA_INATIVO.Width = 77;
            // 
            // formGridClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1932, 1092);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formGridClientes";
            this.Text = "formGridClientes";
            this.Load += new System.EventHandler(this.formGridClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn CLIENTE;
        private DevExpress.XtraGrid.Columns.GridColumn NOME;
        private DevExpress.XtraGrid.Columns.GridColumn NOMEABR;
        private DevExpress.XtraGrid.Columns.GridColumn CLASSE;
        private DevExpress.XtraGrid.Columns.GridColumn PAIS;
        private DevExpress.XtraGrid.Columns.GridColumn ZONA;
        private DevExpress.XtraGrid.Columns.GridColumn AGENTE;
        private DevExpress.XtraGrid.Columns.GridColumn NRCONT;
        private DevExpress.XtraGrid.Columns.GridColumn TELEF;
        private DevExpress.XtraGrid.Columns.GridColumn TELEX;
        private DevExpress.XtraGrid.Columns.GridColumn COD_CTB;
        private DevExpress.XtraGrid.Columns.GridColumn INATIVO;
        private DevExpress.XtraGrid.Columns.GridColumn DATA_INATIVO;
    }
}