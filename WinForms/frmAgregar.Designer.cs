namespace WinForms
{
    partial class frmAgregar
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
            this.labAgregarCodigo = new System.Windows.Forms.Label();
            this.tbxAgregarCodigo = new System.Windows.Forms.TextBox();
            this.tbxAgregarNombre = new System.Windows.Forms.TextBox();
            this.labAgregarNombre = new System.Windows.Forms.Label();
            this.tbxAgregarDescripcion = new System.Windows.Forms.TextBox();
            this.labAgregarDescripcion = new System.Windows.Forms.Label();
            this.lblAgregarPrecio = new System.Windows.Forms.Label();
            this.tbxAgregarPrecio = new System.Windows.Forms.TextBox();
            this.grboxDetalleArt = new System.Windows.Forms.GroupBox();
            this.labAgregarImagen = new System.Windows.Forms.Label();
            this.btnExaminarImagen = new System.Windows.Forms.Button();
            this.grboxMarca_Categoria = new System.Windows.Forms.GroupBox();
            this.comboBoxAgregarArtCategoria = new System.Windows.Forms.ComboBox();
            this.comboBoxAgregarArtMarca = new System.Windows.Forms.ComboBox();
            this.labAgregarMarca = new System.Windows.Forms.Label();
            this.labCategoria = new System.Windows.Forms.Label();
            this.grbAtributosArt = new System.Windows.Forms.GroupBox();
            this.grboxImagenArt = new System.Windows.Forms.GroupBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.picBoxArt = new System.Windows.Forms.PictureBox();
            this.btnCargarArt = new System.Windows.Forms.Button();
            this.btnCancelarCargaArt = new System.Windows.Forms.Button();
            this.grboxVistaPreviaImg = new System.Windows.Forms.GroupBox();
            this.grboxDetalleArt.SuspendLayout();
            this.grboxMarca_Categoria.SuspendLayout();
            this.grbAtributosArt.SuspendLayout();
            this.grboxImagenArt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArt)).BeginInit();
            this.grboxVistaPreviaImg.SuspendLayout();
            this.SuspendLayout();
            // 
            // labAgregarCodigo
            // 
            this.labAgregarCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labAgregarCodigo.AutoSize = true;
            this.labAgregarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAgregarCodigo.Location = new System.Drawing.Point(21, 33);
            this.labAgregarCodigo.Name = "labAgregarCodigo";
            this.labAgregarCodigo.Size = new System.Drawing.Size(67, 18);
            this.labAgregarCodigo.TabIndex = 0;
            this.labAgregarCodigo.Text = "Código:";
            this.labAgregarCodigo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labAgregarCodigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxAgregarCodigo
            // 
            this.tbxAgregarCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAgregarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAgregarCodigo.Location = new System.Drawing.Point(124, 33);
            this.tbxAgregarCodigo.Name = "tbxAgregarCodigo";
            this.tbxAgregarCodigo.Size = new System.Drawing.Size(237, 20);
            this.tbxAgregarCodigo.TabIndex = 0;
            this.tbxAgregarCodigo.TextChanged += new System.EventHandler(this.tbxAgregarCodigo_TextChanged);
            // 
            // tbxAgregarNombre
            // 
            this.tbxAgregarNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAgregarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAgregarNombre.Location = new System.Drawing.Point(124, 139);
            this.tbxAgregarNombre.Name = "tbxAgregarNombre";
            this.tbxAgregarNombre.Size = new System.Drawing.Size(237, 20);
            this.tbxAgregarNombre.TabIndex = 2;
            this.tbxAgregarNombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labAgregarNombre
            // 
            this.labAgregarNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labAgregarNombre.AutoSize = true;
            this.labAgregarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAgregarNombre.Location = new System.Drawing.Point(21, 138);
            this.labAgregarNombre.Name = "labAgregarNombre";
            this.labAgregarNombre.Size = new System.Drawing.Size(73, 18);
            this.labAgregarNombre.TabIndex = 2;
            this.labAgregarNombre.Text = "Nombre:";
            this.labAgregarNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labAgregarNombre.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tbxAgregarDescripcion
            // 
            this.tbxAgregarDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAgregarDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAgregarDescripcion.Location = new System.Drawing.Point(124, 192);
            this.tbxAgregarDescripcion.Name = "tbxAgregarDescripcion";
            this.tbxAgregarDescripcion.Size = new System.Drawing.Size(237, 20);
            this.tbxAgregarDescripcion.TabIndex = 3;
            this.tbxAgregarDescripcion.TextChanged += new System.EventHandler(this.tbxAgregarDescripcion_TextChanged);
            // 
            // labAgregarDescripcion
            // 
            this.labAgregarDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labAgregarDescripcion.AutoSize = true;
            this.labAgregarDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAgregarDescripcion.Location = new System.Drawing.Point(21, 191);
            this.labAgregarDescripcion.Name = "labAgregarDescripcion";
            this.labAgregarDescripcion.Size = new System.Drawing.Size(103, 18);
            this.labAgregarDescripcion.TabIndex = 4;
            this.labAgregarDescripcion.Text = "Descripción:";
            this.labAgregarDescripcion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labAgregarDescripcion.Click += new System.EventHandler(this.labAgregarDescripcion_Click);
            // 
            // lblAgregarPrecio
            // 
            this.lblAgregarPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAgregarPrecio.AutoSize = true;
            this.lblAgregarPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarPrecio.Location = new System.Drawing.Point(21, 89);
            this.lblAgregarPrecio.Name = "lblAgregarPrecio";
            this.lblAgregarPrecio.Size = new System.Drawing.Size(62, 18);
            this.lblAgregarPrecio.TabIndex = 6;
            this.lblAgregarPrecio.Text = "Precio:";
            this.lblAgregarPrecio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAgregarPrecio.Click += new System.EventHandler(this.lblAgregarPrecio_Click);
            // 
            // tbxAgregarPrecio
            // 
            this.tbxAgregarPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAgregarPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAgregarPrecio.Location = new System.Drawing.Point(124, 89);
            this.tbxAgregarPrecio.Name = "tbxAgregarPrecio";
            this.tbxAgregarPrecio.Size = new System.Drawing.Size(237, 20);
            this.tbxAgregarPrecio.TabIndex = 1;
            this.tbxAgregarPrecio.TextChanged += new System.EventHandler(this.tbxAgregarPrecio_TextChanged);
            // 
            // grboxDetalleArt
            // 
            this.grboxDetalleArt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grboxDetalleArt.Controls.Add(this.labAgregarCodigo);
            this.grboxDetalleArt.Controls.Add(this.tbxAgregarPrecio);
            this.grboxDetalleArt.Controls.Add(this.tbxAgregarCodigo);
            this.grboxDetalleArt.Controls.Add(this.lblAgregarPrecio);
            this.grboxDetalleArt.Controls.Add(this.labAgregarNombre);
            this.grboxDetalleArt.Controls.Add(this.tbxAgregarDescripcion);
            this.grboxDetalleArt.Controls.Add(this.tbxAgregarNombre);
            this.grboxDetalleArt.Controls.Add(this.labAgregarDescripcion);
            this.grboxDetalleArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxDetalleArt.Location = new System.Drawing.Point(0, 28);
            this.grboxDetalleArt.Name = "grboxDetalleArt";
            this.grboxDetalleArt.Size = new System.Drawing.Size(383, 356);
            this.grboxDetalleArt.TabIndex = 8;
            this.grboxDetalleArt.TabStop = false;
            this.grboxDetalleArt.Text = "Detalle del artículo";
            this.grboxDetalleArt.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.labAgregarImagen.Click += new System.EventHandler(this.labAgregarImagen_Click);
            // 
            // btnExaminarImagen
            // 
            this.btnExaminarImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExaminarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminarImagen.Location = new System.Drawing.Point(240, 33);
            this.btnExaminarImagen.Name = "btnExaminarImagen";
            this.btnExaminarImagen.Size = new System.Drawing.Size(121, 36);
            this.btnExaminarImagen.TabIndex = 0;
            this.btnExaminarImagen.Text = "Examinar...";
            this.btnExaminarImagen.UseVisualStyleBackColor = true;
            this.btnExaminarImagen.Click += new System.EventHandler(this.btnExaminarImagen_Click);
            // 
            // grboxMarca_Categoria
            // 
            this.grboxMarca_Categoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grboxMarca_Categoria.Controls.Add(this.comboBoxAgregarArtCategoria);
            this.grboxMarca_Categoria.Controls.Add(this.comboBoxAgregarArtMarca);
            this.grboxMarca_Categoria.Controls.Add(this.labAgregarMarca);
            this.grboxMarca_Categoria.Controls.Add(this.labCategoria);
            this.grboxMarca_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxMarca_Categoria.Location = new System.Drawing.Point(0, 260);
            this.grboxMarca_Categoria.Name = "grboxMarca_Categoria";
            this.grboxMarca_Categoria.Size = new System.Drawing.Size(383, 124);
            this.grboxMarca_Categoria.TabIndex = 10;
            this.grboxMarca_Categoria.TabStop = false;
            this.grboxMarca_Categoria.Text = "Marca y Categoría";
            this.grboxMarca_Categoria.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // comboBoxAgregarArtCategoria
            // 
            this.comboBoxAgregarArtCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAgregarArtCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAgregarArtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAgregarArtCategoria.FormattingEnabled = true;
            this.comboBoxAgregarArtCategoria.Location = new System.Drawing.Point(124, 81);
            this.comboBoxAgregarArtCategoria.Name = "comboBoxAgregarArtCategoria";
            this.comboBoxAgregarArtCategoria.Size = new System.Drawing.Size(237, 21);
            this.comboBoxAgregarArtCategoria.TabIndex = 1;
            // 
            // comboBoxAgregarArtMarca
            // 
            this.comboBoxAgregarArtMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAgregarArtMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAgregarArtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAgregarArtMarca.FormattingEnabled = true;
            this.comboBoxAgregarArtMarca.Location = new System.Drawing.Point(124, 34);
            this.comboBoxAgregarArtMarca.Name = "comboBoxAgregarArtMarca";
            this.comboBoxAgregarArtMarca.Size = new System.Drawing.Size(237, 21);
            this.comboBoxAgregarArtMarca.TabIndex = 0;
            this.comboBoxAgregarArtMarca.SelectedIndexChanged += new System.EventHandler(this.comboBoxAgregarArtMarca_SelectedIndexChanged);
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
            this.labAgregarMarca.Click += new System.EventHandler(this.labAgregarMarca_Click);
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
            this.labCategoria.Click += new System.EventHandler(this.labCategoria_Click);
            // 
            // grbAtributosArt
            // 
            this.grbAtributosArt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbAtributosArt.Controls.Add(this.grboxImagenArt);
            this.grbAtributosArt.Controls.Add(this.grboxMarca_Categoria);
            this.grbAtributosArt.Controls.Add(this.grboxDetalleArt);
            this.grbAtributosArt.Location = new System.Drawing.Point(9, 12);
            this.grbAtributosArt.Name = "grbAtributosArt";
            this.grbAtributosArt.Size = new System.Drawing.Size(383, 711);
            this.grbAtributosArt.TabIndex = 11;
            this.grbAtributosArt.TabStop = false;
            this.grbAtributosArt.Text = "Atributos del artículo";
            this.grbAtributosArt.Enter += new System.EventHandler(this.grbAtributosArt_Enter);
            // 
            // grboxImagenArt
            // 
            this.grboxImagenArt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grboxImagenArt.Controls.Add(this.btnCargarImagen);
            this.grboxImagenArt.Controls.Add(this.labAgregarImagen);
            this.grboxImagenArt.Controls.Add(this.btnExaminarImagen);
            this.grboxImagenArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxImagenArt.Location = new System.Drawing.Point(0, 377);
            this.grboxImagenArt.Name = "grboxImagenArt";
            this.grboxImagenArt.Size = new System.Drawing.Size(383, 334);
            this.grboxImagenArt.TabIndex = 12;
            this.grboxImagenArt.TabStop = false;
            this.grboxImagenArt.Text = "Imagen del artículo";
            this.grboxImagenArt.Enter += new System.EventHandler(this.grboxImagenArt_Enter);
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarImagen.Location = new System.Drawing.Point(126, 33);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(121, 36);
            this.btnCargarImagen.TabIndex = 1;
            this.btnCargarImagen.Text = "Cargar";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // picBoxArt
            // 
            this.picBoxArt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxArt.BackColor = System.Drawing.Color.Silver;
            this.picBoxArt.Location = new System.Drawing.Point(24, 53);
            this.picBoxArt.Name = "picBoxArt";
            this.picBoxArt.Size = new System.Drawing.Size(322, 173);
            this.picBoxArt.TabIndex = 12;
            this.picBoxArt.TabStop = false;
            this.picBoxArt.Click += new System.EventHandler(this.picBoxArt_Click);
            // 
            // btnCargarArt
            // 
            this.btnCargarArt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarArt.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCargarArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarArt.Location = new System.Drawing.Point(77, 729);
            this.btnCargarArt.Name = "btnCargarArt";
            this.btnCargarArt.Size = new System.Drawing.Size(108, 45);
            this.btnCargarArt.TabIndex = 0;
            this.btnCargarArt.Text = "Cargar artículo";
            this.btnCargarArt.UseVisualStyleBackColor = false;
            this.btnCargarArt.Click += new System.EventHandler(this.btnCargarArt_Click);
            // 
            // btnCancelarCargaArt
            // 
            this.btnCancelarCargaArt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarCargaArt.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelarCargaArt.Location = new System.Drawing.Point(202, 729);
            this.btnCancelarCargaArt.Name = "btnCancelarCargaArt";
            this.btnCancelarCargaArt.Size = new System.Drawing.Size(108, 45);
            this.btnCancelarCargaArt.TabIndex = 14;
            this.btnCancelarCargaArt.Text = "Cancelar";
            this.btnCancelarCargaArt.UseVisualStyleBackColor = false;
            this.btnCancelarCargaArt.Click += new System.EventHandler(this.btnCancelarCargaArt_Click);
            // 
            // grboxVistaPreviaImg
            // 
            this.grboxVistaPreviaImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grboxVistaPreviaImg.Controls.Add(this.picBoxArt);
            this.grboxVistaPreviaImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxVistaPreviaImg.Location = new System.Drawing.Point(9, 475);
            this.grboxVistaPreviaImg.Name = "grboxVistaPreviaImg";
            this.grboxVistaPreviaImg.Size = new System.Drawing.Size(383, 248);
            this.grboxVistaPreviaImg.TabIndex = 15;
            this.grboxVistaPreviaImg.TabStop = false;
            this.grboxVistaPreviaImg.Text = "Vista previa";
            this.grboxVistaPreviaImg.Enter += new System.EventHandler(this.grboxVistaPreviaImg_Enter);
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(416, 796);
            this.Controls.Add(this.btnCancelarCargaArt);
            this.Controls.Add(this.btnCargarArt);
            this.Controls.Add(this.grboxVistaPreviaImg);
            this.Controls.Add(this.grbAtributosArt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(432, 835);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(432, 835);
            this.Name = "frmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.grboxDetalleArt.ResumeLayout(false);
            this.grboxDetalleArt.PerformLayout();
            this.grboxMarca_Categoria.ResumeLayout(false);
            this.grboxMarca_Categoria.PerformLayout();
            this.grbAtributosArt.ResumeLayout(false);
            this.grboxImagenArt.ResumeLayout(false);
            this.grboxImagenArt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArt)).EndInit();
            this.grboxVistaPreviaImg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labAgregarCodigo;
        private System.Windows.Forms.TextBox tbxAgregarCodigo;
        private System.Windows.Forms.TextBox tbxAgregarNombre;
        private System.Windows.Forms.Label labAgregarNombre;
        private System.Windows.Forms.TextBox tbxAgregarDescripcion;
        private System.Windows.Forms.Label labAgregarDescripcion;
        private System.Windows.Forms.Label lblAgregarPrecio;
        private System.Windows.Forms.TextBox tbxAgregarPrecio;
        private System.Windows.Forms.GroupBox grboxDetalleArt;
        private System.Windows.Forms.Label labAgregarImagen;
        private System.Windows.Forms.Button btnExaminarImagen;
        private System.Windows.Forms.GroupBox grboxMarca_Categoria;
        private System.Windows.Forms.GroupBox grbAtributosArt;
        private System.Windows.Forms.ComboBox comboBoxAgregarArtCategoria;
        private System.Windows.Forms.ComboBox comboBoxAgregarArtMarca;
        private System.Windows.Forms.Label labAgregarMarca;
        private System.Windows.Forms.Label labCategoria;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.PictureBox picBoxArt;
        private System.Windows.Forms.Button btnCargarArt;
        private System.Windows.Forms.Button btnCancelarCargaArt;
        private System.Windows.Forms.GroupBox grboxVistaPreviaImg;
        private System.Windows.Forms.GroupBox grboxImagenArt;
    }
}