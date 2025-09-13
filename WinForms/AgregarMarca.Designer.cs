namespace WinForms
{
    partial class frmAgregarMarca
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
            this.lblIdMarca = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbAgregarIdMarca = new System.Windows.Forms.TextBox();
            this.txbAgregarDescricionMarca = new System.Windows.Forms.TextBox();
            this.btnAceptarMarca = new System.Windows.Forms.Button();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdMarca
            // 
            this.lblIdMarca.AutoSize = true;
            this.lblIdMarca.Location = new System.Drawing.Point(59, 41);
            this.lblIdMarca.Name = "lblIdMarca";
            this.lblIdMarca.Size = new System.Drawing.Size(19, 13);
            this.lblIdMarca.TabIndex = 0;
            this.lblIdMarca.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // txbAgregarIdMarca
            // 
            this.txbAgregarIdMarca.Location = new System.Drawing.Point(118, 41);
            this.txbAgregarIdMarca.Name = "txbAgregarIdMarca";
            this.txbAgregarIdMarca.Size = new System.Drawing.Size(139, 20);
            this.txbAgregarIdMarca.TabIndex = 2;
            // 
            // txbAgregarDescricionMarca
            // 
            this.txbAgregarDescricionMarca.Location = new System.Drawing.Point(118, 76);
            this.txbAgregarDescricionMarca.Name = "txbAgregarDescricionMarca";
            this.txbAgregarDescricionMarca.Size = new System.Drawing.Size(139, 20);
            this.txbAgregarDescricionMarca.TabIndex = 3;
            // 
            // btnAceptarMarca
            // 
            this.btnAceptarMarca.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAceptarMarca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAceptarMarca.Location = new System.Drawing.Point(38, 134);
            this.btnAceptarMarca.Name = "btnAceptarMarca";
            this.btnAceptarMarca.Size = new System.Drawing.Size(82, 25);
            this.btnAceptarMarca.TabIndex = 4;
            this.btnAceptarMarca.Text = "Agregar";
            this.btnAceptarMarca.UseVisualStyleBackColor = false;
            this.btnAceptarMarca.Click += new System.EventHandler(this.btnAceptarMarca_Click);
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelarMarca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelarMarca.Location = new System.Drawing.Point(150, 134);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(82, 25);
            this.btnCancelarMarca.TabIndex = 5;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = false;
            this.btnCancelarMarca.Click += new System.EventHandler(this.btnCancelarMarca_Click);
            // 
            // frmAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 171);
            this.Controls.Add(this.btnCancelarMarca);
            this.Controls.Add(this.btnAceptarMarca);
            this.Controls.Add(this.txbAgregarDescricionMarca);
            this.Controls.Add(this.txbAgregarIdMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIdMarca);
            this.MaximizeBox = false;
            this.Name = "frmAgregarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbAgregarIdMarca;
        private System.Windows.Forms.TextBox txbAgregarDescricionMarca;
        private System.Windows.Forms.Button btnAceptarMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
    }
}