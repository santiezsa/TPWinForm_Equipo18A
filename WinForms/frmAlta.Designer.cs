namespace WinForms
{
    partial class frmAlta
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
            this.btnCargarAltaArt = new System.Windows.Forms.Button();
            this.grboxVistaPreviaImg = new System.Windows.Forms.GroupBox();
            this.pbxImagenAltaArt = new System.Windows.Forms.PictureBox();
            this.btnCargaImagen = new System.Windows.Forms.Button();
            this.gbxImagenAltaArt = new System.Windows.Forms.GroupBox();
            this.labAgregarImagen = new System.Windows.Forms.Label();
            this.btnExaminaImagen = new System.Windows.Forms.Button();
            this.cbxCategoriaAltaArt = new System.Windows.Forms.ComboBox();
            this.cbxMarcaAltaArt = new System.Windows.Forms.ComboBox();
            this.labAgregarMarca = new System.Windows.Forms.Label();
            this.labCategoria = new System.Windows.Forms.Label();
            this.grboxMarca_Categoria = new System.Windows.Forms.GroupBox();
            this.gbxDetalleArt = new System.Windows.Forms.GroupBox();
            this.labAltaCodigo = new System.Windows.Forms.Label();
            this.tbxAltaPrecio = new System.Windows.Forms.TextBox();
            this.tbxAltaCodigo = new System.Windows.Forms.TextBox();
            this.lblAltaPrecio = new System.Windows.Forms.Label();
            this.labAltaNombre = new System.Windows.Forms.Label();
            this.tbxAltaDescripcion = new System.Windows.Forms.TextBox();
            this.tbxAltaNombre = new System.Windows.Forms.TextBox();
            this.labAltaDescripcion = new System.Windows.Forms.Label();
            this.btnCancelarAltaArt = new System.Windows.Forms.Button();
            this.grbAltaArt = new System.Windows.Forms.GroupBox();
            this.grboxVistaPreviaImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenAltaArt)).BeginInit();
            this.gbxImagenAltaArt.SuspendLayout();
            this.grboxMarca_Categoria.SuspendLayout();
            this.gbxDetalleArt.SuspendLayout();
            this.grbAltaArt.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCargarAltaArt
            // 
            this.btnCargarAltaArt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarAltaArt.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCargarAltaArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarAltaArt.Location = new System.Drawing.Point(85, 734);
            this.btnCargarAltaArt.Name = "btnCargarAltaArt";
            this.btnCargarAltaArt.Size = new System.Drawing.Size(108, 45);
            this.btnCargarAltaArt.TabIndex = 16;
            this.btnCargarAltaArt.Text = "Cargar artículo";
            this.btnCargarAltaArt.UseVisualStyleBackColor = false;
            // 
            // grboxVistaPreviaImg
            // 
            this.grboxVistaPreviaImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grboxVistaPreviaImg.Controls.Add(this.pbxImagenAltaArt);
            this.grboxVistaPreviaImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxVistaPreviaImg.Location = new System.Drawing.Point(17, 480);
            this.grboxVistaPreviaImg.Name = "grboxVistaPreviaImg";
            this.grboxVistaPreviaImg.Size = new System.Drawing.Size(383, 248);
            this.grboxVistaPreviaImg.TabIndex = 19;
            this.grboxVistaPreviaImg.TabStop = false;
            this.grboxVistaPreviaImg.Text = "Vista previa";
            // 
            // pbxImagenAltaArt
            // 
            this.pbxImagenAltaArt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxImagenAltaArt.BackColor = System.Drawing.Color.Silver;
            this.pbxImagenAltaArt.Location = new System.Drawing.Point(24, 53);
            this.pbxImagenAltaArt.Name = "pbxImagenAltaArt";
            this.pbxImagenAltaArt.Size = new System.Drawing.Size(322, 173);
            this.pbxImagenAltaArt.TabIndex = 12;
            this.pbxImagenAltaArt.TabStop = false;
            // 
            // btnCargaImagen
            // 
            this.btnCargaImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargaImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaImagen.Location = new System.Drawing.Point(126, 33);
            this.btnCargaImagen.Name = "btnCargaImagen";
            this.btnCargaImagen.Size = new System.Drawing.Size(121, 36);
            this.btnCargaImagen.TabIndex = 1;
            this.btnCargaImagen.Text = "Cargar";
            this.btnCargaImagen.UseVisualStyleBackColor = true;
            // 
            // gbxImagenAltaArt
            // 
            this.gbxImagenAltaArt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxImagenAltaArt.Controls.Add(this.btnCargaImagen);
            this.gbxImagenAltaArt.Controls.Add(this.labAgregarImagen);
            this.gbxImagenAltaArt.Controls.Add(this.btnExaminaImagen);
            this.gbxImagenAltaArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxImagenAltaArt.Location = new System.Drawing.Point(0, 377);
            this.gbxImagenAltaArt.Name = "gbxImagenAltaArt";
            this.gbxImagenAltaArt.Size = new System.Drawing.Size(383, 334);
            this.gbxImagenAltaArt.TabIndex = 12;
            this.gbxImagenAltaArt.TabStop = false;
            this.gbxImagenAltaArt.Text = "Imagen del artículo";
            // 
            // labAgregarImagen
            // 
            this.labAgregarImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labAgregarImagen.AutoSize = true;
            this.labAgregarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAgregarImagen.Location = new System.Drawing.Point(23, 34);
            this.labAgregarImagen.Name = "labAgregarImagen";
            this.labAgregarImagen.Size = new System.Drawing.Size(67, 18);
            this.labAgregarImagen.TabIndex = 8;
            this.labAgregarImagen.Text = "Imagen:";
            this.labAgregarImagen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExaminaImagen
            // 
            this.btnExaminaImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExaminaImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminaImagen.Location = new System.Drawing.Point(240, 33);
            this.btnExaminaImagen.Name = "btnExaminaImagen";
            this.btnExaminaImagen.Size = new System.Drawing.Size(121, 36);
            this.btnExaminaImagen.TabIndex = 0;
            this.btnExaminaImagen.Text = "Examinar...";
            this.btnExaminaImagen.UseVisualStyleBackColor = true;
            // 
            // cbxCategoriaAltaArt
            // 
            this.cbxCategoriaAltaArt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCategoriaAltaArt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoriaAltaArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoriaAltaArt.FormattingEnabled = true;
            this.cbxCategoriaAltaArt.Location = new System.Drawing.Point(124, 81);
            this.cbxCategoriaAltaArt.Name = "cbxCategoriaAltaArt";
            this.cbxCategoriaAltaArt.Size = new System.Drawing.Size(237, 21);
            this.cbxCategoriaAltaArt.TabIndex = 1;
            // 
            // cbxMarcaAltaArt
            // 
            this.cbxMarcaAltaArt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMarcaAltaArt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarcaAltaArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMarcaAltaArt.FormattingEnabled = true;
            this.cbxMarcaAltaArt.Location = new System.Drawing.Point(124, 34);
            this.cbxMarcaAltaArt.Name = "cbxMarcaAltaArt";
            this.cbxMarcaAltaArt.Size = new System.Drawing.Size(237, 21);
            this.cbxMarcaAltaArt.TabIndex = 0;
            // 
            // labAgregarMarca
            // 
            this.labAgregarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labAgregarMarca.AutoSize = true;
            this.labAgregarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAgregarMarca.Location = new System.Drawing.Point(21, 38);
            this.labAgregarMarca.Name = "labAgregarMarca";
            this.labAgregarMarca.Size = new System.Drawing.Size(60, 18);
            this.labAgregarMarca.TabIndex = 8;
            this.labAgregarMarca.Text = "Marca:";
            this.labAgregarMarca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labCategoria
            // 
            this.labCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labCategoria.AutoSize = true;
            this.labCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCategoria.Location = new System.Drawing.Point(21, 82);
            this.labCategoria.Name = "labCategoria";
            this.labCategoria.Size = new System.Drawing.Size(86, 18);
            this.labCategoria.TabIndex = 10;
            this.labCategoria.Text = "Categoria:";
            this.labCategoria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grboxMarca_Categoria
            // 
            this.grboxMarca_Categoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grboxMarca_Categoria.Controls.Add(this.cbxCategoriaAltaArt);
            this.grboxMarca_Categoria.Controls.Add(this.cbxMarcaAltaArt);
            this.grboxMarca_Categoria.Controls.Add(this.labAgregarMarca);
            this.grboxMarca_Categoria.Controls.Add(this.labCategoria);
            this.grboxMarca_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxMarca_Categoria.Location = new System.Drawing.Point(0, 260);
            this.grboxMarca_Categoria.Name = "grboxMarca_Categoria";
            this.grboxMarca_Categoria.Size = new System.Drawing.Size(383, 124);
            this.grboxMarca_Categoria.TabIndex = 10;
            this.grboxMarca_Categoria.TabStop = false;
            this.grboxMarca_Categoria.Text = "Marca y Categoría";
            // 
            // gbxDetalleArt
            // 
            this.gbxDetalleArt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDetalleArt.Controls.Add(this.labAltaCodigo);
            this.gbxDetalleArt.Controls.Add(this.tbxAltaPrecio);
            this.gbxDetalleArt.Controls.Add(this.tbxAltaCodigo);
            this.gbxDetalleArt.Controls.Add(this.lblAltaPrecio);
            this.gbxDetalleArt.Controls.Add(this.labAltaNombre);
            this.gbxDetalleArt.Controls.Add(this.tbxAltaDescripcion);
            this.gbxDetalleArt.Controls.Add(this.tbxAltaNombre);
            this.gbxDetalleArt.Controls.Add(this.labAltaDescripcion);
            this.gbxDetalleArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetalleArt.Location = new System.Drawing.Point(0, 28);
            this.gbxDetalleArt.Name = "gbxDetalleArt";
            this.gbxDetalleArt.Size = new System.Drawing.Size(383, 356);
            this.gbxDetalleArt.TabIndex = 8;
            this.gbxDetalleArt.TabStop = false;
            this.gbxDetalleArt.Text = "Detalle del artículo";
            // 
            // labAltaCodigo
            // 
            this.labAltaCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labAltaCodigo.AutoSize = true;
            this.labAltaCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAltaCodigo.Location = new System.Drawing.Point(21, 33);
            this.labAltaCodigo.Name = "labAltaCodigo";
            this.labAltaCodigo.Size = new System.Drawing.Size(67, 18);
            this.labAltaCodigo.TabIndex = 0;
            this.labAltaCodigo.Text = "Código:";
            this.labAltaCodigo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxAltaPrecio
            // 
            this.tbxAltaPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAltaPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAltaPrecio.Location = new System.Drawing.Point(124, 89);
            this.tbxAltaPrecio.Name = "tbxAltaPrecio";
            this.tbxAltaPrecio.Size = new System.Drawing.Size(237, 20);
            this.tbxAltaPrecio.TabIndex = 1;
            // 
            // tbxAltaCodigo
            // 
            this.tbxAltaCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAltaCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAltaCodigo.Location = new System.Drawing.Point(124, 33);
            this.tbxAltaCodigo.Name = "tbxAltaCodigo";
            this.tbxAltaCodigo.Size = new System.Drawing.Size(237, 20);
            this.tbxAltaCodigo.TabIndex = 0;
            // 
            // lblAltaPrecio
            // 
            this.lblAltaPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAltaPrecio.AutoSize = true;
            this.lblAltaPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaPrecio.Location = new System.Drawing.Point(21, 89);
            this.lblAltaPrecio.Name = "lblAltaPrecio";
            this.lblAltaPrecio.Size = new System.Drawing.Size(62, 18);
            this.lblAltaPrecio.TabIndex = 6;
            this.lblAltaPrecio.Text = "Precio:";
            this.lblAltaPrecio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labAltaNombre
            // 
            this.labAltaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labAltaNombre.AutoSize = true;
            this.labAltaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAltaNombre.Location = new System.Drawing.Point(21, 138);
            this.labAltaNombre.Name = "labAltaNombre";
            this.labAltaNombre.Size = new System.Drawing.Size(73, 18);
            this.labAltaNombre.TabIndex = 2;
            this.labAltaNombre.Text = "Nombre:";
            this.labAltaNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxAltaDescripcion
            // 
            this.tbxAltaDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAltaDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAltaDescripcion.Location = new System.Drawing.Point(124, 192);
            this.tbxAltaDescripcion.Name = "tbxAltaDescripcion";
            this.tbxAltaDescripcion.Size = new System.Drawing.Size(237, 20);
            this.tbxAltaDescripcion.TabIndex = 3;
            // 
            // tbxAltaNombre
            // 
            this.tbxAltaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAltaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAltaNombre.Location = new System.Drawing.Point(124, 139);
            this.tbxAltaNombre.Name = "tbxAltaNombre";
            this.tbxAltaNombre.Size = new System.Drawing.Size(237, 20);
            this.tbxAltaNombre.TabIndex = 2;
            // 
            // labAltaDescripcion
            // 
            this.labAltaDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labAltaDescripcion.AutoSize = true;
            this.labAltaDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAltaDescripcion.Location = new System.Drawing.Point(21, 191);
            this.labAltaDescripcion.Name = "labAltaDescripcion";
            this.labAltaDescripcion.Size = new System.Drawing.Size(103, 18);
            this.labAltaDescripcion.TabIndex = 4;
            this.labAltaDescripcion.Text = "Descripción:";
            this.labAltaDescripcion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancelarAltaArt
            // 
            this.btnCancelarAltaArt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarAltaArt.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelarAltaArt.Location = new System.Drawing.Point(210, 734);
            this.btnCancelarAltaArt.Name = "btnCancelarAltaArt";
            this.btnCancelarAltaArt.Size = new System.Drawing.Size(108, 45);
            this.btnCancelarAltaArt.TabIndex = 18;
            this.btnCancelarAltaArt.Text = "Cancelar";
            this.btnCancelarAltaArt.UseVisualStyleBackColor = false;
            // 
            // grbAltaArt
            // 
            this.grbAltaArt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbAltaArt.Controls.Add(this.gbxImagenAltaArt);
            this.grbAltaArt.Controls.Add(this.grboxMarca_Categoria);
            this.grbAltaArt.Controls.Add(this.gbxDetalleArt);
            this.grbAltaArt.Location = new System.Drawing.Point(17, 17);
            this.grbAltaArt.Name = "grbAltaArt";
            this.grbAltaArt.Size = new System.Drawing.Size(383, 711);
            this.grbAltaArt.TabIndex = 17;
            this.grbAltaArt.TabStop = false;
            this.grbAltaArt.Text = "Atributos del artículo";
            // 
            // frmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 796);
            this.Controls.Add(this.btnCargarAltaArt);
            this.Controls.Add(this.grboxVistaPreviaImg);
            this.Controls.Add(this.btnCancelarAltaArt);
            this.Controls.Add(this.grbAltaArt);
            this.MaximumSize = new System.Drawing.Size(432, 835);
            this.MinimumSize = new System.Drawing.Size(432, 835);
            this.Name = "frmAlta";
            this.Text = "frmAlta";
            this.grboxVistaPreviaImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenAltaArt)).EndInit();
            this.gbxImagenAltaArt.ResumeLayout(false);
            this.gbxImagenAltaArt.PerformLayout();
            this.grboxMarca_Categoria.ResumeLayout(false);
            this.grboxMarca_Categoria.PerformLayout();
            this.gbxDetalleArt.ResumeLayout(false);
            this.gbxDetalleArt.PerformLayout();
            this.grbAltaArt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarAltaArt;
        private System.Windows.Forms.GroupBox grboxVistaPreviaImg;
        private System.Windows.Forms.PictureBox pbxImagenAltaArt;
        private System.Windows.Forms.Button btnCargaImagen;
        private System.Windows.Forms.GroupBox gbxImagenAltaArt;
        private System.Windows.Forms.Label labAgregarImagen;
        private System.Windows.Forms.Button btnExaminaImagen;
        private System.Windows.Forms.ComboBox cbxCategoriaAltaArt;
        private System.Windows.Forms.ComboBox cbxMarcaAltaArt;
        private System.Windows.Forms.Label labAgregarMarca;
        private System.Windows.Forms.Label labCategoria;
        private System.Windows.Forms.GroupBox grboxMarca_Categoria;
        private System.Windows.Forms.GroupBox gbxDetalleArt;
        private System.Windows.Forms.Label labAltaCodigo;
        private System.Windows.Forms.TextBox tbxAltaPrecio;
        private System.Windows.Forms.TextBox tbxAltaCodigo;
        private System.Windows.Forms.Label lblAltaPrecio;
        private System.Windows.Forms.Label labAltaNombre;
        private System.Windows.Forms.TextBox tbxAltaDescripcion;
        private System.Windows.Forms.TextBox tbxAltaNombre;
        private System.Windows.Forms.Label labAltaDescripcion;
        private System.Windows.Forms.Button btnCancelarAltaArt;
        private System.Windows.Forms.GroupBox grbAltaArt;
    }
}