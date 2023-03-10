namespace CEMEL.Presentacion.Usuarios
{
    partial class PantallaRegistrarUsuario
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblRptContrasenia = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtRepetirContra = new System.Windows.Forms.TextBox();
            this.cmbPerfiles = new System.Windows.Forms.ComboBox();
            this.btnCargarUsuario = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(22, 28);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(99, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Nombre de usuario:";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(22, 54);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(64, 13);
            this.lblContrasenia.TabIndex = 1;
            this.lblContrasenia.Text = "Contraseña:";
            // 
            // lblRptContrasenia
            // 
            this.lblRptContrasenia.AutoSize = true;
            this.lblRptContrasenia.Location = new System.Drawing.Point(22, 80);
            this.lblRptContrasenia.Name = "lblRptContrasenia";
            this.lblRptContrasenia.Size = new System.Drawing.Size(103, 13);
            this.lblRptContrasenia.TabIndex = 2;
            this.lblRptContrasenia.Text = "Repetir contraseña: ";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(22, 106);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(33, 13);
            this.lblPerfil.TabIndex = 3;
            this.lblPerfil.Text = "Perfil:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(124, 25);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(138, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(124, 51);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(138, 20);
            this.txtContra.TabIndex = 5;
            // 
            // txtRepetirContra
            // 
            this.txtRepetirContra.Location = new System.Drawing.Point(124, 77);
            this.txtRepetirContra.Name = "txtRepetirContra";
            this.txtRepetirContra.Size = new System.Drawing.Size(138, 20);
            this.txtRepetirContra.TabIndex = 6;
            // 
            // cmbPerfiles
            // 
            this.cmbPerfiles.FormattingEnabled = true;
            this.cmbPerfiles.Location = new System.Drawing.Point(124, 103);
            this.cmbPerfiles.Name = "cmbPerfiles";
            this.cmbPerfiles.Size = new System.Drawing.Size(138, 21);
            this.cmbPerfiles.TabIndex = 7;
            // 
            // btnCargarUsuario
            // 
            this.btnCargarUsuario.Location = new System.Drawing.Point(178, 130);
            this.btnCargarUsuario.Name = "btnCargarUsuario";
            this.btnCargarUsuario.Size = new System.Drawing.Size(84, 24);
            this.btnCargarUsuario.TabIndex = 8;
            this.btnCargarUsuario.Text = "Aceptar";
            this.btnCargarUsuario.UseVisualStyleBackColor = true;
            this.btnCargarUsuario.Click += new System.EventHandler(this.btnCargarUsuario_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(88, 130);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 24);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Location = new System.Drawing.Point(178, 130);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(84, 24);
            this.btnModificarUsuario.TabIndex = 10;
            this.btnModificarUsuario.Text = "Aceptar";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(86, 13);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Registrar usuario";
            // 
            // PantallaRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCargarUsuario);
            this.Controls.Add(this.cmbPerfiles);
            this.Controls.Add(this.txtRepetirContra);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblRptContrasenia);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblUsuario);
            this.Name = "PantallaRegistrarUsuario";
            this.Text = "PantallaRegistrarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblRptContrasenia;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtRepetirContra;
        private System.Windows.Forms.ComboBox cmbPerfiles;
        private System.Windows.Forms.Button btnCargarUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Label lblTitulo;
    }
}