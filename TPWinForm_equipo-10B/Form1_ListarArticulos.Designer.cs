namespace TPWinForm_equipo_10B
{
    partial class Form5_ListarArticulos
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
            this.pictureBox1Imagen = new System.Windows.Forms.PictureBox();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.button1Aceptar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1Imagen
            // 
            this.pictureBox1Imagen.Location = new System.Drawing.Point(651, 71);
            this.pictureBox1Imagen.Name = "pictureBox1Imagen";
            this.pictureBox1Imagen.Size = new System.Drawing.Size(172, 147);
            this.pictureBox1Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Imagen.TabIndex = 1;
            this.pictureBox1Imagen.TabStop = false;
            // 
            // dgvListar
            // 
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListar.Location = new System.Drawing.Point(12, 40);
            this.dgvListar.MultiSelect = false;
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListar.Size = new System.Drawing.Size(570, 178);
            this.dgvListar.TabIndex = 2;
            this.dgvListar.SelectionChanged += new System.EventHandler(this.dgvListar_SelectionChanged);
            // 
            // button1Aceptar
            // 
            this.button1Aceptar.Location = new System.Drawing.Point(27, 274);
            this.button1Aceptar.Name = "button1Aceptar";
            this.button1Aceptar.Size = new System.Drawing.Size(121, 49);
            this.button1Aceptar.TabIndex = 3;
            this.button1Aceptar.Text = "Aceptar";
            this.button1Aceptar.UseVisualStyleBackColor = true;
            this.button1Aceptar.Click += new System.EventHandler(this.button1Aceptar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(174, 274);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(121, 49);
            this.buttonModificar.TabIndex = 4;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // Form5_ListarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 359);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.button1Aceptar);
            this.Controls.Add(this.dgvListar);
            this.Controls.Add(this.pictureBox1Imagen);
            this.Name = "Form5_ListarArticulos";
            this.Text = "Lista de Articulos";
            this.Load += new System.EventHandler(this.Form5_ListarArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1Imagen;
        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.Button button1Aceptar;
        private System.Windows.Forms.Button buttonModificar;
    }
}