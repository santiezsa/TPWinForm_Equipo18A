namespace WinForms
{
    partial class frmAgregarCategoria
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
            this.lblDescripcionAgregarCategoria = new System.Windows.Forms.Label();
            this.txbAgregarCategoria = new System.Windows.Forms.TextBox();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnCancelarCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescripcionAgregarCategoria
            // 
            this.lblDescripcionAgregarCategoria.AutoSize = true;
            this.lblDescripcionAgregarCategoria.Location = new System.Drawing.Point(21, 38);
            this.lblDescripcionAgregarCategoria.Name = "lblDescripcionAgregarCategoria";
            this.lblDescripcionAgregarCategoria.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcionAgregarCategoria.TabIndex = 0;
            this.lblDescripcionAgregarCategoria.Text = "Descripción:";
            this.lblDescripcionAgregarCategoria.Click += new System.EventHandler(this.lblDescripcionAgregarCategoria_Click);
            // 
            // txbAgregarCategoria
            // 
            this.txbAgregarCategoria.Location = new System.Drawing.Point(99, 35);
            this.txbAgregarCategoria.Name = "txbAgregarCategoria";
            this.txbAgregarCategoria.Size = new System.Drawing.Size(148, 20);
            this.txbAgregarCategoria.TabIndex = 1;
            this.txbAgregarCategoria.TextChanged += new System.EventHandler(this.txbAgregarCategoria_TextChanged);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(37, 105);
            this.btnAgregarCategoria.MaximumSize = new System.Drawing.Size(86, 24);
            this.btnAgregarCategoria.MinimumSize = new System.Drawing.Size(86, 24);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(86, 24);
            this.btnAgregarCategoria.TabIndex = 2;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnCancelarCategoria
            // 
            this.btnCancelarCategoria.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelarCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarCategoria.Location = new System.Drawing.Point(148, 105);
            this.btnCancelarCategoria.Name = "btnCancelarCategoria";
            this.btnCancelarCategoria.Size = new System.Drawing.Size(86, 24);
            this.btnCancelarCategoria.TabIndex = 3;
            this.btnCancelarCategoria.Text = "Cancelar";
            this.btnCancelarCategoria.UseVisualStyleBackColor = false;
            this.btnCancelarCategoria.Click += new System.EventHandler(this.btnCancelarCategoria_Click);
            // 
            // frmAgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 146);
            this.Controls.Add(this.btnCancelarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.txbAgregarCategoria);
            this.Controls.Add(this.lblDescripcionAgregarCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(286, 185);
            this.MinimumSize = new System.Drawing.Size(286, 185);
            this.Name = "frmAgregarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcionAgregarCategoria;
        private System.Windows.Forms.TextBox txbAgregarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnCancelarCategoria;
    }
}