namespace WinForms
{
    partial class frmMarcas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarcas));
            this.tlsMarca = new System.Windows.Forms.ToolStrip();
            this.btnAgregarMarca = new System.Windows.Forms.ToolStripButton();
            this.btnModificarMarca = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminarMarca = new System.Windows.Forms.ToolStripButton();
            this.grbAdmMarcas = new System.Windows.Forms.GroupBox();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.btnCerrarVentanaMarcas = new System.Windows.Forms.Button();
            this.tlsMarca.SuspendLayout();
            this.grbAdmMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // tlsMarca
            // 
            this.tlsMarca.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarMarca,
            this.btnModificarMarca,
            this.toolStripSeparator1,
            this.btnEliminarMarca});
            this.tlsMarca.Location = new System.Drawing.Point(0, 0);
            this.tlsMarca.Name = "tlsMarca";
            this.tlsMarca.Size = new System.Drawing.Size(304, 25);
            this.tlsMarca.TabIndex = 2;
            this.tlsMarca.Text = "toolStrip1";
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregarMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarMarca.Image")));
            this.btnAgregarMarca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(23, 22);
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModificarMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarMarca.Image")));
            this.btnModificarMarca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(23, 22);
            this.btnModificarMarca.Text = "Modificar";
            this.btnModificarMarca.Click += new System.EventHandler(this.btnModificarMarca_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminarMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarMarca.Image")));
            this.btnEliminarMarca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(23, 22);
            this.btnEliminarMarca.Text = "toolStripButton3";
            this.btnEliminarMarca.ToolTipText = "Eliminar";
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // grbAdmMarcas
            // 
            this.grbAdmMarcas.Controls.Add(this.dgvMarcas);
            this.grbAdmMarcas.Location = new System.Drawing.Point(13, 49);
            this.grbAdmMarcas.Name = "grbAdmMarcas";
            this.grbAdmMarcas.Size = new System.Drawing.Size(279, 381);
            this.grbAdmMarcas.TabIndex = 1;
            this.grbAdmMarcas.TabStop = false;
            this.grbAdmMarcas.Text = "Marcas";
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcas.Location = new System.Drawing.Point(17, 33);
            this.dgvMarcas.MultiSelect = false;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(243, 331);
            this.dgvMarcas.TabIndex = 0;
            this.dgvMarcas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCerrarVentanaMarcas
            // 
            this.btnCerrarVentanaMarcas.Location = new System.Drawing.Point(101, 440);
            this.btnCerrarVentanaMarcas.Name = "btnCerrarVentanaMarcas";
            this.btnCerrarVentanaMarcas.Size = new System.Drawing.Size(93, 26);
            this.btnCerrarVentanaMarcas.TabIndex = 1;
            this.btnCerrarVentanaMarcas.Text = "Cerrar";
            this.btnCerrarVentanaMarcas.UseVisualStyleBackColor = true;
            this.btnCerrarVentanaMarcas.Click += new System.EventHandler(this.btnCerrarVentanaMarcas_Click);
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 478);
            this.Controls.Add(this.btnCerrarVentanaMarcas);
            this.Controls.Add(this.tlsMarca);
            this.Controls.Add(this.grbAdmMarcas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(320, 517);
            this.MinimumSize = new System.Drawing.Size(320, 517);
            this.Name = "frmMarcas";
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.frmMarcas_Load);
            this.tlsMarca.ResumeLayout(false);
            this.tlsMarca.PerformLayout();
            this.grbAdmMarcas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tlsMarca;
        private System.Windows.Forms.ToolStripButton btnAgregarMarca;
        private System.Windows.Forms.ToolStripButton btnModificarMarca;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEliminarMarca;
        private System.Windows.Forms.GroupBox grbAdmMarcas;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Button btnCerrarVentanaMarcas;
    }
}