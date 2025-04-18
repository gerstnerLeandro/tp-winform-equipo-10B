namespace TPWinForm_equipo_10B
{
    partial class Form2AltaArticulo
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
            this.label1CodigoArticulo = new System.Windows.Forms.Label();
            this.label2Nombre = new System.Windows.Forms.Label();
            this.label3IDescripcion = new System.Windows.Forms.Label();
            this.label4Marca = new System.Windows.Forms.Label();
            this.label5Categoria = new System.Windows.Forms.Label();
            this.label6Precio = new System.Windows.Forms.Label();
            this.textBoxCodigoArticulo = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.button1Aceptar = new System.Windows.Forms.Button();
            this.button2Cancelar = new System.Windows.Forms.Button();
            this.comboBoxIDmarca = new System.Windows.Forms.ComboBox();
            this.comboBoxIDcategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1CodigoArticulo
            // 
            this.label1CodigoArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1CodigoArticulo.AutoSize = true;
            this.label1CodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1CodigoArticulo.Location = new System.Drawing.Point(31, 36);
            this.label1CodigoArticulo.Name = "label1CodigoArticulo";
            this.label1CodigoArticulo.Size = new System.Drawing.Size(109, 18);
            this.label1CodigoArticulo.TabIndex = 0;
            this.label1CodigoArticulo.Text = "Codigo Articulo";
            // 
            // label2Nombre
            // 
            this.label2Nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2Nombre.AutoSize = true;
            this.label2Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Nombre.Location = new System.Drawing.Point(31, 75);
            this.label2Nombre.Name = "label2Nombre";
            this.label2Nombre.Size = new System.Drawing.Size(62, 18);
            this.label2Nombre.TabIndex = 1;
            this.label2Nombre.Text = "Nombre";
            // 
            // label3IDescripcion
            // 
            this.label3IDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3IDescripcion.AutoSize = true;
            this.label3IDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3IDescripcion.Location = new System.Drawing.Point(31, 112);
            this.label3IDescripcion.Name = "label3IDescripcion";
            this.label3IDescripcion.Size = new System.Drawing.Size(87, 18);
            this.label3IDescripcion.TabIndex = 2;
            this.label3IDescripcion.Text = "Descripcion";
            // 
            // label4Marca
            // 
            this.label4Marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4Marca.AutoSize = true;
            this.label4Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4Marca.Location = new System.Drawing.Point(31, 148);
            this.label4Marca.Name = "label4Marca";
            this.label4Marca.Size = new System.Drawing.Size(50, 18);
            this.label4Marca.TabIndex = 3;
            this.label4Marca.Text = "Marca";
            // 
            // label5Categoria
            // 
            this.label5Categoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5Categoria.AutoSize = true;
            this.label5Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5Categoria.Location = new System.Drawing.Point(31, 181);
            this.label5Categoria.Name = "label5Categoria";
            this.label5Categoria.Size = new System.Drawing.Size(72, 18);
            this.label5Categoria.TabIndex = 4;
            this.label5Categoria.Text = "Categoria";
            // 
            // label6Precio
            // 
            this.label6Precio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6Precio.AutoSize = true;
            this.label6Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6Precio.Location = new System.Drawing.Point(31, 220);
            this.label6Precio.Name = "label6Precio";
            this.label6Precio.Size = new System.Drawing.Size(51, 18);
            this.label6Precio.TabIndex = 5;
            this.label6Precio.Text = "Precio";
            // 
            // textBoxCodigoArticulo
            // 
            this.textBoxCodigoArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCodigoArticulo.Location = new System.Drawing.Point(146, 34);
            this.textBoxCodigoArticulo.Name = "textBoxCodigoArticulo";
            this.textBoxCodigoArticulo.Size = new System.Drawing.Size(125, 20);
            this.textBoxCodigoArticulo.TabIndex = 6;
            this.textBoxCodigoArticulo.TextChanged += new System.EventHandler(this.textBoxCodigoArticulo_TextChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNombre.Location = new System.Drawing.Point(146, 73);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(125, 20);
            this.textBoxNombre.TabIndex = 8;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDescripcion.Location = new System.Drawing.Point(146, 110);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(125, 20);
            this.textBoxDescripcion.TabIndex = 9;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPrecio.Location = new System.Drawing.Point(146, 218);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(125, 20);
            this.textBoxPrecio.TabIndex = 11;
            // 
            // button1Aceptar
            // 
            this.button1Aceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1Aceptar.Location = new System.Drawing.Point(34, 283);
            this.button1Aceptar.Name = "button1Aceptar";
            this.button1Aceptar.Size = new System.Drawing.Size(106, 48);
            this.button1Aceptar.TabIndex = 12;
            this.button1Aceptar.Text = "Aceptar";
            this.button1Aceptar.UseVisualStyleBackColor = true;
            this.button1Aceptar.Click += new System.EventHandler(this.button1Aceptar_Click);
            // 
            // button2Cancelar
            // 
            this.button2Cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2Cancelar.Location = new System.Drawing.Point(247, 283);
            this.button2Cancelar.Name = "button2Cancelar";
            this.button2Cancelar.Size = new System.Drawing.Size(106, 48);
            this.button2Cancelar.TabIndex = 13;
            this.button2Cancelar.Text = "Cancelar";
            this.button2Cancelar.UseVisualStyleBackColor = true;
            this.button2Cancelar.Click += new System.EventHandler(this.button2Cancelar_Click);
            // 
            // comboBoxIDmarca
            // 
            this.comboBoxIDmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIDmarca.FormattingEnabled = true;
            this.comboBoxIDmarca.Location = new System.Drawing.Point(146, 149);
            this.comboBoxIDmarca.Name = "comboBoxIDmarca";
            this.comboBoxIDmarca.Size = new System.Drawing.Size(125, 21);
            this.comboBoxIDmarca.TabIndex = 14;
            this.comboBoxIDmarca.SelectedIndexChanged += new System.EventHandler(this.comboBoxIDmarca_SelectedIndexChanged);
            // 
            // comboBoxIDcategoria
            // 
            this.comboBoxIDcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIDcategoria.FormattingEnabled = true;
            this.comboBoxIDcategoria.Location = new System.Drawing.Point(146, 182);
            this.comboBoxIDcategoria.Name = "comboBoxIDcategoria";
            this.comboBoxIDcategoria.Size = new System.Drawing.Size(125, 21);
            this.comboBoxIDcategoria.TabIndex = 15;
            this.comboBoxIDcategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxIDcategoria_SelectedIndexChanged);
            // 
            // Form2AltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 363);
            this.Controls.Add(this.comboBoxIDcategoria);
            this.Controls.Add(this.comboBoxIDmarca);
            this.Controls.Add(this.button2Cancelar);
            this.Controls.Add(this.button1Aceptar);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCodigoArticulo);
            this.Controls.Add(this.label6Precio);
            this.Controls.Add(this.label5Categoria);
            this.Controls.Add(this.label4Marca);
            this.Controls.Add(this.label3IDescripcion);
            this.Controls.Add(this.label2Nombre);
            this.Controls.Add(this.label1CodigoArticulo);
            this.Name = "Form2AltaArticulo";
            this.Text = "Form2AltaArticulo";
            this.Load += new System.EventHandler(this.Form2AltaArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1CodigoArticulo;
        private System.Windows.Forms.Label label2Nombre;
        private System.Windows.Forms.Label label3IDescripcion;
        private System.Windows.Forms.Label label4Marca;
        private System.Windows.Forms.Label label5Categoria;
        private System.Windows.Forms.Label label6Precio;
        private System.Windows.Forms.TextBox textBoxCodigoArticulo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Button button1Aceptar;
        private System.Windows.Forms.Button button2Cancelar;
        private System.Windows.Forms.ComboBox comboBoxIDmarca;
        private System.Windows.Forms.ComboBox comboBoxIDcategoria;
    }
}