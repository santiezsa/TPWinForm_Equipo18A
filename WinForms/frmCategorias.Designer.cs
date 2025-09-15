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
            this.btnCerrarCategorias = new System.Windows.Forms.Button();
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
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModificarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarCategoria.Image")));
            this.btnModificarCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(23, 22);
            this.btnModificarCategoria.Text = "Modificar";
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
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
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // grbAdmCategorias
            // 
            this.grbAdmCategorias.Controls.Add(this.dgvCategorias);
            this.grbAdmCategorias.Location = new System.Drawing.Point(12, 39);
            this.grbAdmCategorias.Name = "grbAdmCategorias";
            this.grbAdmCategorias.Size = new System.Drawing.Size(280, 396);
            this.grbAdmCategorias.TabIndex = 1;
            this.grbAdmCategorias.TabStop = false;
            this.grbAdmCategorias.Text = "Categorias";
            this.grbAdmCategorias.Enter += new System.EventHandler(this.grbAdmCategorias_Enter);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategorias.Location = new System.Drawing.Point(18, 36);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(245, 325);
            this.dgvCategorias.TabIndex = 0;
            this.dgvCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellContentClick);
            // 
            // btnCerrarCategorias
            // 
            this.btnCerrarCategorias.Location = new System.Drawing.Point(93, 444);
            this.btnCerrarCategorias.Name = "btnCerrarCategorias";
            this.btnCerrarCategorias.Size = new System.Drawing.Size(106, 22);
            this.btnCerrarCategorias.TabIndex = 2;
            this.btnCerrarCategorias.Text = "Cerrar";
            this.btnCerrarCategorias.UseVisualStyleBackColor = true;
            this.btnCerrarCategorias.Click += new System.EventHandler(this.btnCerrarCategorias_Click);
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 478);
            this.Controls.Add(this.btnCerrarCategorias);
            this.Controls.Add(this.grbAdmCategorias);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(320, 517);
            this.MinimumSize = new System.Drawing.Size(320, 517);
            this.Name = "frmCategorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
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
        private System.Windows.Forms.Button btnCerrarCategorias;
    }
}