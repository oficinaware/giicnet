namespace GiicNetUI.Comum.Forms.Base.Clientes
{
    partial class formClientes
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
            this.IDIOMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PAIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ZONA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AGENTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NRCONT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TELEF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TELEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COD_CTB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.INATIVO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DATA_INATIVO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CALSSE_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
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
            this.CLIENTE,
            this.NOME,
            this.NOMEABR,
            this.CLASSE,
            this.IDIOMA,
            this.PAIS,
            this.ZONA,
            this.AGENTE,
            this.NRCONT,
            this.TELEF,
            this.TELEX,
            this.COD_CTB,
            this.INATIVO,
            this.DATA_INATIVO,
            this.CALSSE_DESC});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AllowFindPanel = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // CLIENTE
            // 
            this.CLIENTE.Caption = "Cliente";
            this.CLIENTE.FieldName = "CLIENTE";
            this.CLIENTE.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.Visible = true;
            this.CLIENTE.VisibleIndex = 0;
            this.CLIENTE.Width = 50;
            // 
            // NOME
            // 
            this.NOME.Caption = "Nome";
            this.NOME.FieldName = "NOME";
            this.NOME.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.NOME.Name = "NOME";
            this.NOME.Visible = true;
            this.NOME.VisibleIndex = 1;
            this.NOME.Width = 250;
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
            this.CLASSE.Width = 40;
            // 
            // IDIOMA
            // 
            this.IDIOMA.Caption = "Idioma";
            this.IDIOMA.Name = "IDIOMA";
            this.IDIOMA.Visible = true;
            this.IDIOMA.VisibleIndex = 13;
            this.IDIOMA.Width = 40;
            // 
            // PAIS
            // 
            this.PAIS.Caption = "País";
            this.PAIS.FieldName = "PAIS";
            this.PAIS.Name = "PAIS";
            this.PAIS.Visible = true;
            this.PAIS.VisibleIndex = 4;
            this.PAIS.Width = 35;
            // 
            // ZONA
            // 
            this.ZONA.Caption = "Zona";
            this.ZONA.FieldName = "ZONA";
            this.ZONA.Name = "ZONA";
            this.ZONA.Visible = true;
            this.ZONA.VisibleIndex = 5;
            this.ZONA.Width = 35;
            // 
            // AGENTE
            // 
            this.AGENTE.Caption = "Age.";
            this.AGENTE.FieldName = "AGENTE";
            this.AGENTE.Name = "AGENTE";
            this.AGENTE.Visible = true;
            this.AGENTE.VisibleIndex = 6;
            this.AGENTE.Width = 32;
            // 
            // NRCONT
            // 
            this.NRCONT.Caption = "Nr. Contrib.";
            this.NRCONT.FieldName = "NRCONT";
            this.NRCONT.Name = "NRCONT";
            this.NRCONT.Visible = true;
            this.NRCONT.VisibleIndex = 7;
            this.NRCONT.Width = 90;
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
            this.TELEX.Width = 160;
            // 
            // COD_CTB
            // 
            this.COD_CTB.Caption = "Cod. CTB";
            this.COD_CTB.FieldName = "COD_CTB";
            this.COD_CTB.Name = "COD_CTB";
            this.COD_CTB.Visible = true;
            this.COD_CTB.VisibleIndex = 10;
            this.COD_CTB.Width = 80;
            // 
            // INATIVO
            // 
            this.INATIVO.Caption = "Inativo";
            this.INATIVO.FieldName = "INATIVO";
            this.INATIVO.Name = "INATIVO";
            this.INATIVO.Visible = true;
            this.INATIVO.VisibleIndex = 11;
            this.INATIVO.Width = 60;
            // 
            // DATA_INATIVO
            // 
            this.DATA_INATIVO.Caption = "Data";
            this.DATA_INATIVO.FieldName = "DATA_INATIVO";
            this.DATA_INATIVO.Name = "DATA_INATIVO";
            this.DATA_INATIVO.Visible = true;
            this.DATA_INATIVO.VisibleIndex = 12;
            this.DATA_INATIVO.Width = 90;
            // 
            // CALSSE_DESC
            // 
            this.CALSSE_DESC.Caption = "Classe Desc.";
            this.CALSSE_DESC.Name = "CALSSE_DESC";
            this.CALSSE_DESC.Visible = true;
            this.CALSSE_DESC.VisibleIndex = 14;
            this.CALSSE_DESC.Width = 100;
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panelFiltros.Controls.Add(this.textEdit3);
            this.panelFiltros.Controls.Add(this.textEdit2);
            this.panelFiltros.Controls.Add(this.textEdit1);
            this.panelFiltros.Location = new System.Drawing.Point(6, 48);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(720, 32);
            this.panelFiltros.TabIndex = 1;
            this.panelFiltros.Visible = false;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(433, 6);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(34, 20);
            this.textEdit3.TabIndex = 2;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(61, 6);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(250, 20);
            this.textEdit2.TabIndex = 1;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(11, 6);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(49, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // formClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 849);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formClientes";
            this.Load += new System.EventHandler(this.formClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panelFiltros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn IDIOMA;
        private DevExpress.XtraGrid.Columns.GridColumn CALSSE_DESC;
        private System.Windows.Forms.Panel panelFiltros;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}