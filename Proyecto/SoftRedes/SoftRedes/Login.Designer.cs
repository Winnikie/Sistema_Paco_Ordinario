namespace SoftRedes
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.IconoMinimizar = new System.Windows.Forms.PictureBox();
            this.IconoCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(780, 330);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Black;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 312;
            this.lineShape1.X2 = 655;
            this.lineShape1.Y1 = 105;
            this.lineShape1.Y2 = 105;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Silver;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(311, 85);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(272, 16);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.Silver;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.Black;
            this.txtContraseña.Location = new System.Drawing.Point(312, 150);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(272, 16);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Text = "CONTRASEÑA";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Black;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 312;
            this.lineShape2.X2 = 655;
            this.lineShape2.Y1 = 169;
            this.lineShape2.Y2 = 169;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(456, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(312, 197);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(344, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "ACCEDER";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // IconoMinimizar
            // 
            this.IconoMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoMinimizar.Image = global::SoftRedes.Properties.Resources.IconoMinimizar;
            this.IconoMinimizar.Location = new System.Drawing.Point(712, 12);
            this.IconoMinimizar.Name = "IconoMinimizar";
            this.IconoMinimizar.Size = new System.Drawing.Size(25, 25);
            this.IconoMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoMinimizar.TabIndex = 7;
            this.IconoMinimizar.TabStop = false;
            this.IconoMinimizar.Click += new System.EventHandler(this.IconoMinimizar_Click);
            // 
            // IconoCerrar
            // 
            this.IconoCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoCerrar.Image = global::SoftRedes.Properties.Resources.IconoCerrar;
            this.IconoCerrar.Location = new System.Drawing.Point(743, 12);
            this.IconoCerrar.Name = "IconoCerrar";
            this.IconoCerrar.Size = new System.Drawing.Size(25, 25);
            this.IconoCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoCerrar.TabIndex = 6;
            this.IconoCerrar.TabStop = false;
            this.IconoCerrar.Click += new System.EventHandler(this.IconoCerrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.IconoMinimizar);
            this.Controls.Add(this.IconoCerrar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.IconoMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox IconoMinimizar;
        private System.Windows.Forms.PictureBox IconoCerrar;
    }
}