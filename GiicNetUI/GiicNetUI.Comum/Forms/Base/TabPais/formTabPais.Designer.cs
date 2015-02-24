namespace GiicNetUI.Comum.Forms.Base.TabPais
{
    partial class formTabPais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTabPais));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpPaises = new DevExpress.XtraEditors.GroupControl();
            this.grpZonas = new DevExpress.XtraEditors.GroupControl();
            this.grpLocais = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpPaises)).BeginInit();
            this.grpPaises.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpZonas)).BeginInit();
            this.grpZonas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpLocais)).BeginInit();
            this.grpLocais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(740, 298);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // grpPaises
            // 
            this.grpPaises.Controls.Add(this.gridControl1);
            this.grpPaises.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPaises.Location = new System.Drawing.Point(0, 0);
            this.grpPaises.Name = "grpPaises";
            this.grpPaises.Size = new System.Drawing.Size(744, 321);
            this.grpPaises.TabIndex = 1;
            this.grpPaises.Text = "Tabela de Países";
            // 
            // grpZonas
            // 
            this.grpZonas.Controls.Add(this.gridControl2);
            this.grpZonas.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpZonas.Location = new System.Drawing.Point(0, 321);
            this.grpZonas.Name = "grpZonas";
            this.grpZonas.Size = new System.Drawing.Size(369, 213);
            this.grpZonas.TabIndex = 2;
            this.grpZonas.Text = "Zonas / Distritos de:";
            // 
            // grpLocais
            // 
            this.grpLocais.Controls.Add(this.gridControl3);
            this.grpLocais.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpLocais.Location = new System.Drawing.Point(375, 321);
            this.grpLocais.Name = "grpLocais";
            this.grpLocais.Size = new System.Drawing.Size(369, 213);
            this.grpLocais.TabIndex = 3;
            this.grpLocais.Text = "Locais de:";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 21);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(365, 190);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // gridControl3
            // 
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(2, 21);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(365, 190);
            this.gridControl3.TabIndex = 0;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            // 
            // formTabPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 534);
            this.Controls.Add(this.grpLocais);
            this.Controls.Add(this.grpZonas);
            this.Controls.Add(this.grpPaises);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formTabPais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Países / Zonas / Locais";
            this.Load += new System.EventHandler(this.formTabPais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpPaises)).EndInit();
            this.grpPaises.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpZonas)).EndInit();
            this.grpZonas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpLocais)).EndInit();
            this.grpLocais.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl grpPaises;
        private DevExpress.XtraEditors.GroupControl grpZonas;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl grpLocais;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
    }
}