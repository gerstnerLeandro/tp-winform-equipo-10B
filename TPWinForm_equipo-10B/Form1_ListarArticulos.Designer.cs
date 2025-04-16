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
            this.Articulos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // Articulos
            // 
            this.Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Articulos.Location = new System.Drawing.Point(47, 48);
            this.Articulos.Name = "Articulos";
            this.Articulos.Size = new System.Drawing.Size(372, 210);
            this.Articulos.TabIndex = 0;
            this.Articulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Articulos_CellContentClick);
            // 
            // Form5_ListarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 359);
            this.Controls.Add(this.Articulos);
            this.Name = "Form5_ListarArticulos";
            this.Text = "Listar Articulos";
            this.Load += new System.EventHandler(this.Form5_ListarArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Articulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Articulos;
    }
}