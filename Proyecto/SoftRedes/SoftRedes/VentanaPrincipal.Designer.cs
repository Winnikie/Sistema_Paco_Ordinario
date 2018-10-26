namespace SoftRedes
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.MenuVertical = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDispositivos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.IconoMinimizar = new System.Windows.Forms.PictureBox();
            this.IconoMinimizarTam = new System.Windows.Forms.PictureBox();
            this.IconoMaximizar = new System.Windows.Forms.PictureBox();
            this.IconoCerrar = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.SubMenuDispositivos = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.MenuVertical.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMinimizarTam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoCerrar)).BeginInit();
            this.SubMenuDispositivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(46)))), ((int)(((byte)(129)))));
            this.MenuVertical.Controls.Add(this.btnDispositivos);
            this.MenuVertical.Controls.Add(this.SubMenuDispositivos);
            this.MenuVertical.Controls.Add(this.button2);
            this.MenuVertical.Controls.Add(this.btnUsuarios);
            this.MenuVertical.Controls.Add(this.button3);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(246, 611);
            this.MenuVertical.TabIndex = 0;
            // 
            // btnDispositivos
            // 
            this.btnDispositivos.FlatAppearance.BorderSize = 0;
            this.btnDispositivos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDispositivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDispositivos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispositivos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDispositivos.Location = new System.Drawing.Point(3, 3);
            this.btnDispositivos.Name = "btnDispositivos";
            this.btnDispositivos.Size = new System.Drawing.Size(239, 50);
            this.btnDispositivos.TabIndex = 0;
            this.btnDispositivos.Text = "Dispositivos";
            this.btnDispositivos.UseVisualStyleBackColor = true;
            this.btnDispositivos.Click += new System.EventHandler(this.btnDispositivos_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Edificios";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(3, 292);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(242, 50);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Reportes";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.BarraTitulo.Controls.Add(this.btnMenu);
            this.BarraTitulo.Controls.Add(this.IconoMinimizar);
            this.BarraTitulo.Controls.Add(this.IconoMinimizarTam);
            this.BarraTitulo.Controls.Add(this.IconoMaximizar);
            this.BarraTitulo.Controls.Add(this.IconoCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(246, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1038, 45);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btnMenu
            // 
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(6, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(52, 39);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 4;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // IconoMinimizar
            // 
            this.IconoMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoMinimizar.Image = global::SoftRedes.Properties.Resources.IconoMinimizar;
            this.IconoMinimizar.Location = new System.Drawing.Point(924, 11);
            this.IconoMinimizar.Name = "IconoMinimizar";
            this.IconoMinimizar.Size = new System.Drawing.Size(25, 25);
            this.IconoMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoMinimizar.TabIndex = 3;
            this.IconoMinimizar.TabStop = false;
            this.IconoMinimizar.Click += new System.EventHandler(this.IconoMinimizar_Click);
            // 
            // IconoMinimizarTam
            // 
            this.IconoMinimizarTam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoMinimizarTam.Image = global::SoftRedes.Properties.Resources.IconoMinimizarTam;
            this.IconoMinimizarTam.Location = new System.Drawing.Point(960, 11);
            this.IconoMinimizarTam.Name = "IconoMinimizarTam";
            this.IconoMinimizarTam.Size = new System.Drawing.Size(25, 25);
            this.IconoMinimizarTam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoMinimizarTam.TabIndex = 2;
            this.IconoMinimizarTam.TabStop = false;
            this.IconoMinimizarTam.Visible = false;
            this.IconoMinimizarTam.Click += new System.EventHandler(this.IconoMinimizarTam_Click);
            // 
            // IconoMaximizar
            // 
            this.IconoMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoMaximizar.Image = global::SoftRedes.Properties.Resources.IconoMaximizar;
            this.IconoMaximizar.Location = new System.Drawing.Point(960, 11);
            this.IconoMaximizar.Name = "IconoMaximizar";
            this.IconoMaximizar.Size = new System.Drawing.Size(25, 25);
            this.IconoMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoMaximizar.TabIndex = 1;
            this.IconoMaximizar.TabStop = false;
            this.IconoMaximizar.Click += new System.EventHandler(this.IconoMaximizar_Click);
            // 
            // IconoCerrar
            // 
            this.IconoCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoCerrar.Image = global::SoftRedes.Properties.Resources.IconoCerrar;
            this.IconoCerrar.Location = new System.Drawing.Point(996, 11);
            this.IconoCerrar.Name = "IconoCerrar";
            this.IconoCerrar.Size = new System.Drawing.Size(25, 25);
            this.IconoCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoCerrar.TabIndex = 0;
            this.IconoCerrar.TabStop = false;
            this.IconoCerrar.Click += new System.EventHandler(this.IconoCerrar_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.Lavender;
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(246, 45);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1038, 566);
            this.PanelContenedor.TabIndex = 2;
            // 
            // SubMenuDispositivos
            // 
            this.SubMenuDispositivos.Controls.Add(this.button6);
            this.SubMenuDispositivos.Controls.Add(this.button5);
            this.SubMenuDispositivos.Controls.Add(this.button4);
            this.SubMenuDispositivos.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuDispositivos.Location = new System.Drawing.Point(3, 59);
            this.SubMenuDispositivos.Name = "SubMenuDispositivos";
            this.SubMenuDispositivos.Size = new System.Drawing.Size(239, 171);
            this.SubMenuDispositivos.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DimGray;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(0, 100);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(239, 50);
            this.button6.TabIndex = 3;
            this.button6.Text = "Dispositivos 3";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(0, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(239, 50);
            this.button5.TabIndex = 2;
            this.button5.Text = "Dispositivos 2";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(239, 50);
            this.button4.TabIndex = 1;
            this.button4.Text = "Dispositivos 1";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MenuVertical.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMinimizarTam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoCerrar)).EndInit();
            this.SubMenuDispositivos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MenuVertical;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox IconoMinimizar;
        private System.Windows.Forms.PictureBox IconoMinimizarTam;
        private System.Windows.Forms.PictureBox IconoMaximizar;
        private System.Windows.Forms.PictureBox IconoCerrar;
        private System.Windows.Forms.Button btnDispositivos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel SubMenuDispositivos;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}

