namespace TPWinForm_equipo_10B
{
    partial class VntanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1Bienvenida = new System.Windows.Forms.Label();
            this.label1Selecion = new System.Windows.Forms.Label();
            this.button1Alta = new System.Windows.Forms.Button();
            this.button2Modificar = new System.Windows.Forms.Button();
            this.button3Eliminar = new System.Windows.Forms.Button();
            this.button4Listar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1Bienvenida
            // 
            this.label1Bienvenida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1Bienvenida.AutoSize = true;
            this.label1Bienvenida.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Bienvenida.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1Bienvenida.Location = new System.Drawing.Point(13, 55);
            this.label1Bienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1Bienvenida.Name = "label1Bienvenida";
            this.label1Bienvenida.Size = new System.Drawing.Size(450, 30);
            this.label1Bienvenida.TabIndex = 1;
            this.label1Bienvenida.Text = "Bienvenido a tu Administrador de Articulos";
            // 
            // label1Selecion
            // 
            this.label1Selecion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1Selecion.AutoSize = true;
            this.label1Selecion.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Selecion.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1Selecion.Location = new System.Drawing.Point(126, 109);
            this.label1Selecion.Name = "label1Selecion";
            this.label1Selecion.Size = new System.Drawing.Size(199, 29);
            this.label1Selecion.TabIndex = 2;
            this.label1Selecion.Text = "Selecione su opción";
            // 
            // button1Alta
            // 
            this.button1Alta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1Alta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1Alta.Location = new System.Drawing.Point(172, 155);
            this.button1Alta.Name = "button1Alta";
            this.button1Alta.Size = new System.Drawing.Size(106, 40);
            this.button1Alta.TabIndex = 3;
            this.button1Alta.Text = "Alta Articulo";
            this.button1Alta.UseVisualStyleBackColor = false;
            this.button1Alta.Click += new System.EventHandler(this.button1Alta_Click);
            // 
            // button2Modificar
            // 
            this.button2Modificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2Modificar.Location = new System.Drawing.Point(172, 214);
            this.button2Modificar.Name = "button2Modificar";
            this.button2Modificar.Size = new System.Drawing.Size(106, 40);
            this.button2Modificar.TabIndex = 4;
            this.button2Modificar.Text = "Modificar Articulo";
            this.button2Modificar.UseVisualStyleBackColor = false;
            this.button2Modificar.Click += new System.EventHandler(this.button2Modificar_Click);
            // 
            // button3Eliminar
            // 
            this.button3Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3Eliminar.Location = new System.Drawing.Point(172, 276);
            this.button3Eliminar.Name = "button3Eliminar";
            this.button3Eliminar.Size = new System.Drawing.Size(106, 40);
            this.button3Eliminar.TabIndex = 5;
            this.button3Eliminar.Text = "Eliminar Articulo";
            this.button3Eliminar.UseVisualStyleBackColor = false;
            this.button3Eliminar.Click += new System.EventHandler(this.button3Eliminar_Click);
            // 
            // button4Listar
            // 
            this.button4Listar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4Listar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4Listar.Location = new System.Drawing.Point(172, 339);
            this.button4Listar.Name = "button4Listar";
            this.button4Listar.Size = new System.Drawing.Size(106, 40);
            this.button4Listar.TabIndex = 6;
            this.button4Listar.Text = "Listar Articulos";
            this.button4Listar.UseVisualStyleBackColor = false;
            this.button4Listar.Click += new System.EventHandler(this.button4Listar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionToolStripMenuItem
            // 
            this.opcionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaArticuloToolStripMenuItem,
            this.modificarArticuloToolStripMenuItem,
            this.eliminarArticuloToolStripMenuItem,
            this.listarArticulosToolStripMenuItem});
            this.opcionToolStripMenuItem.Name = "opcionToolStripMenuItem";
            this.opcionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.opcionToolStripMenuItem.Text = "Opción";
            this.opcionToolStripMenuItem.Click += new System.EventHandler(this.opcionToolStripMenuItem_Click);
            // 
            // altaArticuloToolStripMenuItem
            // 
            this.altaArticuloToolStripMenuItem.Name = "altaArticuloToolStripMenuItem";
            this.altaArticuloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaArticuloToolStripMenuItem.Text = "Alta Articulo";
            this.altaArticuloToolStripMenuItem.Click += new System.EventHandler(this.altaArticuloToolStripMenuItem_Click);
            // 
            // modificarArticuloToolStripMenuItem
            // 
            this.modificarArticuloToolStripMenuItem.Name = "modificarArticuloToolStripMenuItem";
            this.modificarArticuloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarArticuloToolStripMenuItem.Text = "Modificar Articulo";
            this.modificarArticuloToolStripMenuItem.Click += new System.EventHandler(this.modificarArticuloToolStripMenuItem_Click);
            // 
            // eliminarArticuloToolStripMenuItem
            // 
            this.eliminarArticuloToolStripMenuItem.Name = "eliminarArticuloToolStripMenuItem";
            this.eliminarArticuloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarArticuloToolStripMenuItem.Text = "Eliminar Articulo";
            this.eliminarArticuloToolStripMenuItem.Click += new System.EventHandler(this.eliminarArticuloToolStripMenuItem_Click);
            // 
            // listarArticulosToolStripMenuItem
            // 
            this.listarArticulosToolStripMenuItem.Name = "listarArticulosToolStripMenuItem";
            this.listarArticulosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarArticulosToolStripMenuItem.Text = "Listar Articulos";
            this.listarArticulosToolStripMenuItem.Click += new System.EventHandler(this.listarArticulosToolStripMenuItem_Click);
            // 
            // VntanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(484, 403);
            this.Controls.Add(this.button4Listar);
            this.Controls.Add(this.button3Eliminar);
            this.Controls.Add(this.button2Modificar);
            this.Controls.Add(this.button1Alta);
            this.Controls.Add(this.label1Selecion);
            this.Controls.Add(this.label1Bienvenida);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(500, 39);
            this.Name = "VntanaPrincipal";
            this.Text = "Administrador de Articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1Bienvenida;
        private System.Windows.Forms.Label label1Selecion;
        private System.Windows.Forms.Button button1Alta;
        private System.Windows.Forms.Button button2Modificar;
        private System.Windows.Forms.Button button3Eliminar;
        private System.Windows.Forms.Button button4Listar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarArticulosToolStripMenuItem;
    }
}

