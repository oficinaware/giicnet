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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formClientes));
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1942, 933);
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
            this.panelFiltros.Location = new System.Drawing.Point(8, 59);
            this.panelFiltros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(960, 39);
            this.panelFiltros.TabIndex = 1;
            this.panelFiltros.Visible = false;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(576, 7);
            this.textEdit3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(45, 22);
            this.textEdit3.TabIndex = 2;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(80, 7);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(333, 22);
            this.textEdit2.TabIndex = 1;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(15, 7);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(64, 22);
            this.textEdit1.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.IsSplitterFixed = true;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.ribbonControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.panelFiltros);
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1942, 1045);
            this.splitContainerControl1.SplitterPosition = 93;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barButtonItem13,
            this.barButtonItem14,
            this.barButtonItem15});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1942, 107);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Adicionar Cliente";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Editar Cliente";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Remover Cliente";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Ficha Cliente";
            this.barButtonItem4.Id = 1;
            this.barButtonItem4.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.LargeGlyph")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Plafonds";
            this.barButtonItem5.Id = 2;
            this.barButtonItem5.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.LargeGlyph")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Registo de Plafonds";
            this.barButtonItem6.Id = 3;
            this.barButtonItem6.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.LargeGlyph")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Imprime Controlo Plafonds";
            this.barButtonItem7.Id = 4;
            this.barButtonItem7.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.LargeGlyph")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Ocorrências";
            this.barButtonItem8.Id = 5;
            this.barButtonItem8.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.LargeGlyph")));
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Print Ocorrências";
            this.barButtonItem9.Id = 6;
            this.barButtonItem9.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.LargeGlyph")));
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Contactos";
            this.barButtonItem10.Id = 7;
            this.barButtonItem10.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.LargeGlyph")));
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Observações Bancos Etiquetas";
            this.barButtonItem11.Id = 8;
            this.barButtonItem11.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.LargeGlyph")));
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Moradas";
            this.barButtonItem12.Id = 9;
            this.barButtonItem12.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem12.LargeGlyph")));
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Marcas Grifos";
            this.barButtonItem13.Id = 10;
            this.barButtonItem13.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.LargeGlyph")));
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "Encomendas Pendentes";
            this.barButtonItem14.Id = 11;
            this.barButtonItem14.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem14.LargeGlyph")));
            this.barButtonItem14.Name = "barButtonItem14";
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.Caption = "Filtros Servidor";
            this.barButtonItem15.Id = 14;
            this.barButtonItem15.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem15.LargeGlyph")));
            this.barButtonItem15.Name = "barButtonItem15";
            this.barButtonItem15.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem15_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Clientes";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem11);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem12);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem13);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem14);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem15);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // formClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1045);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formClientes";
            this.Load += new System.EventHandler(this.formClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panelFiltros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
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
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}