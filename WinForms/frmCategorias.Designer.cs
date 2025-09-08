namespace WinForms
{
    partial class frmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregarCategoria = new System.Windows.Forms.ToolStripButton();
            this.btnModificarCategoria = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminarCategoria = new System.Windows.Forms.ToolStripButton();
            this.grbAdmCategorias = new System.Windows.Forms.GroupBox();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.grbAdmCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarCategoria,
            this.btnModificarCategoria,
            this.toolStripSeparator1,
            this.btnEliminarCategoria});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(304, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCategoria.Image")));
            this.btnAgregarCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(23, 22);
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModificarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarCategoria.Image")));
            this.btnModificarCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(23, 22);
            this.btnModificarCategoria.Text = "Modificar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarCategoria.Image")));
            this.btnEliminarCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(23, 22);
            this.btnEliminarCategoria.Text = "Eliminar";
            // 
            // grbAdmCategorias
            // 
            this.grbAdmCategorias.Controls.Add(this.dgvCategorias);
            this.grbAdmCategorias.Location = new System.Drawing.Point(12, 39);
            this.grbAdmCategorias.Name = "grbAdmCategorias";
            this.grbAdmCategorias.Size = new System.Drawing.Size(267, 415);
            this.grbAdmCategorias.TabIndex = 1;
            this.grbAdmCategorias.TabStop = false;
            this.grbAdmCategorias.Text = "Categorias";
            this.grbAdmCategorias.Enter += new System.EventHandler(this.grbAdmCategorias_Enter);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(6, 36);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.Size = new System.Drawing.Size(254, 189);
            this.dgvCategorias.TabIndex = 0;
            this.dgvCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellContentClick);
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 478);
            this.Controls.Add(this.grbAdmCategorias);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCategorias";
            this.Text = "Categorias";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grbAdmCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregarCategoria;
        private System.Windows.Forms.ToolStripButton btnModificarCategoria;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEliminarCategoria;
        private System.Windows.Forms.GroupBox grbAdmCategorias;
        private System.Windows.Forms.DataGridView dgvCategorias;
    }
}