namespace CEMEL.Presentacion.Menu
{
    partial class PantallaMenu
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
            this.txtUsername = new System.Windows.Forms.Label();
            this.txtPerfil = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRegistrarPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificarPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultarPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDarDeBajaPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListadoDePacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRegistrarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultarEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDarDeBajaEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEstudios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRegistrarEstudio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificarEstudio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultarEstudios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDarDeBajaEstudio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiServicios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRegistrarServicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificarServicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultarServicios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDarDeBajaServicio = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRegistrarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificarUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultarUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDarDeBajaUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Location = new System.Drawing.Point(12, 9);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(53, 13);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "username";
            // 
            // txtPerfil
            // 
            this.txtPerfil.AutoSize = true;
            this.txtPerfil.Location = new System.Drawing.Point(12, 31);
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.Size = new System.Drawing.Size(29, 13);
            this.txtPerfil.TabIndex = 1;
            this.txtPerfil.Text = "perfil";
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSize = true;
            this.txtFecha.Location = new System.Drawing.Point(12, 53);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(34, 13);
            this.txtFecha.TabIndex = 2;
            this.txtFecha.Text = "fecha";
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPacientes,
            this.tsmiEmpleados,
            this.tsmiEstudios,
            this.tsmiServicios,
            this.usuariosToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(677, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(123, 450);
            this.menuStrip.Stretch = false;
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tsmiPacientes
            // 
            this.tsmiPacientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRegistrarPaciente,
            this.tsmiModificarPaciente,
            this.tsmiConsultarPaciente,
            this.tsmiDarDeBajaPaciente,
            this.tsmiListadoDePacientes});
            this.tsmiPacientes.Name = "tsmiPacientes";
            this.tsmiPacientes.Size = new System.Drawing.Size(116, 19);
            this.tsmiPacientes.Text = "Pacientes";
            // 
            // tsmiRegistrarPaciente
            // 
            this.tsmiRegistrarPaciente.Name = "tsmiRegistrarPaciente";
            this.tsmiRegistrarPaciente.Size = new System.Drawing.Size(181, 22);
            this.tsmiRegistrarPaciente.Text = "Registrar paciente";
            // 
            // tsmiModificarPaciente
            // 
            this.tsmiModificarPaciente.Name = "tsmiModificarPaciente";
            this.tsmiModificarPaciente.Size = new System.Drawing.Size(181, 22);
            this.tsmiModificarPaciente.Text = "Modificar paciente";
            // 
            // tsmiConsultarPaciente
            // 
            this.tsmiConsultarPaciente.Name = "tsmiConsultarPaciente";
            this.tsmiConsultarPaciente.Size = new System.Drawing.Size(181, 22);
            this.tsmiConsultarPaciente.Text = "Consultar paciente";
            // 
            // tsmiDarDeBajaPaciente
            // 
            this.tsmiDarDeBajaPaciente.Name = "tsmiDarDeBajaPaciente";
            this.tsmiDarDeBajaPaciente.Size = new System.Drawing.Size(181, 22);
            this.tsmiDarDeBajaPaciente.Text = "Dar de baja paciente";
            // 
            // tsmiListadoDePacientes
            // 
            this.tsmiListadoDePacientes.Name = "tsmiListadoDePacientes";
            this.tsmiListadoDePacientes.Size = new System.Drawing.Size(181, 22);
            this.tsmiListadoDePacientes.Text = "Listado de pacientes";
            // 
            // tsmiEmpleados
            // 
            this.tsmiEmpleados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRegistrarEmpleado,
            this.tsmiModificarEmpleado,
            this.tsmiConsultarEmpleados,
            this.tsmiDarDeBajaEmpleado});
            this.tsmiEmpleados.Name = "tsmiEmpleados";
            this.tsmiEmpleados.Size = new System.Drawing.Size(116, 19);
            this.tsmiEmpleados.Text = "Empleados";
            // 
            // tsmiRegistrarEmpleado
            // 
            this.tsmiRegistrarEmpleado.Name = "tsmiRegistrarEmpleado";
            this.tsmiRegistrarEmpleado.Size = new System.Drawing.Size(189, 22);
            this.tsmiRegistrarEmpleado.Text = "Registrar empleado";
            // 
            // tsmiModificarEmpleado
            // 
            this.tsmiModificarEmpleado.Name = "tsmiModificarEmpleado";
            this.tsmiModificarEmpleado.Size = new System.Drawing.Size(189, 22);
            this.tsmiModificarEmpleado.Text = "Modificar empleado";
            // 
            // tsmiConsultarEmpleados
            // 
            this.tsmiConsultarEmpleados.Name = "tsmiConsultarEmpleados";
            this.tsmiConsultarEmpleados.Size = new System.Drawing.Size(189, 22);
            this.tsmiConsultarEmpleados.Text = "Consultar empleados";
            // 
            // tsmiDarDeBajaEmpleado
            // 
            this.tsmiDarDeBajaEmpleado.Name = "tsmiDarDeBajaEmpleado";
            this.tsmiDarDeBajaEmpleado.Size = new System.Drawing.Size(189, 22);
            this.tsmiDarDeBajaEmpleado.Text = "Dar de baja empleado";
            // 
            // tsmiEstudios
            // 
            this.tsmiEstudios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRegistrarEstudio,
            this.tsmiModificarEstudio,
            this.tsmiConsultarEstudios,
            this.tsmiDarDeBajaEstudio});
            this.tsmiEstudios.Name = "tsmiEstudios";
            this.tsmiEstudios.Size = new System.Drawing.Size(116, 19);
            this.tsmiEstudios.Text = "Estudios";
            // 
            // tsmiRegistrarEstudio
            // 
            this.tsmiRegistrarEstudio.Name = "tsmiRegistrarEstudio";
            this.tsmiRegistrarEstudio.Size = new System.Drawing.Size(175, 22);
            this.tsmiRegistrarEstudio.Text = "Registrar estudio";
            // 
            // tsmiModificarEstudio
            // 
            this.tsmiModificarEstudio.Name = "tsmiModificarEstudio";
            this.tsmiModificarEstudio.Size = new System.Drawing.Size(175, 22);
            this.tsmiModificarEstudio.Text = "Modificar estudio";
            // 
            // tsmiConsultarEstudios
            // 
            this.tsmiConsultarEstudios.Name = "tsmiConsultarEstudios";
            this.tsmiConsultarEstudios.Size = new System.Drawing.Size(175, 22);
            this.tsmiConsultarEstudios.Text = "Consultar estudios";
            // 
            // tsmiDarDeBajaEstudio
            // 
            this.tsmiDarDeBajaEstudio.Name = "tsmiDarDeBajaEstudio";
            this.tsmiDarDeBajaEstudio.Size = new System.Drawing.Size(175, 22);
            this.tsmiDarDeBajaEstudio.Text = "Dar de baja estudio";
            // 
            // tsmiServicios
            // 
            this.tsmiServicios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRegistrarServicio,
            this.tsmiModificarServicio,
            this.tsmiConsultarServicios,
            this.tsmiDarDeBajaServicio});
            this.tsmiServicios.Name = "tsmiServicios";
            this.tsmiServicios.Size = new System.Drawing.Size(116, 19);
            this.tsmiServicios.Text = "Servicios";
            // 
            // tsmiRegistrarServicio
            // 
            this.tsmiRegistrarServicio.Name = "tsmiRegistrarServicio";
            this.tsmiRegistrarServicio.Size = new System.Drawing.Size(176, 22);
            this.tsmiRegistrarServicio.Text = "Registrar servicio";
            // 
            // tsmiModificarServicio
            // 
            this.tsmiModificarServicio.Name = "tsmiModificarServicio";
            this.tsmiModificarServicio.Size = new System.Drawing.Size(176, 22);
            this.tsmiModificarServicio.Text = "Modificar servicio";
            // 
            // tsmiConsultarServicios
            // 
            this.tsmiConsultarServicios.Name = "tsmiConsultarServicios";
            this.tsmiConsultarServicios.Size = new System.Drawing.Size(176, 22);
            this.tsmiConsultarServicios.Text = "Consultar servicios";
            // 
            // tsmiDarDeBajaServicio
            // 
            this.tsmiDarDeBajaServicio.Name = "tsmiDarDeBajaServicio";
            this.tsmiDarDeBajaServicio.Size = new System.Drawing.Size(176, 22);
            this.tsmiDarDeBajaServicio.Text = "Dar de baja servicio";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRegistrarUsuario,
            this.tsmiModificarUsuarios,
            this.tsmiConsultarUsuarios,
            this.tsmiDarDeBajaUsuarios});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(116, 19);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // tsmiRegistrarUsuario
            // 
            this.tsmiRegistrarUsuario.Name = "tsmiRegistrarUsuario";
            this.tsmiRegistrarUsuario.Size = new System.Drawing.Size(180, 22);
            this.tsmiRegistrarUsuario.Text = "Registrar usuario";
            this.tsmiRegistrarUsuario.Click += new System.EventHandler(this.tsmiRegistrarUsuario_Click);
            // 
            // tsmiModificarUsuarios
            // 
            this.tsmiModificarUsuarios.Name = "tsmiModificarUsuarios";
            this.tsmiModificarUsuarios.Size = new System.Drawing.Size(180, 22);
            this.tsmiModificarUsuarios.Text = "Modificar usuarios";
            this.tsmiModificarUsuarios.Click += new System.EventHandler(this.tsmiModificarUsuarios_Click);
            // 
            // tsmiConsultarUsuarios
            // 
            this.tsmiConsultarUsuarios.Name = "tsmiConsultarUsuarios";
            this.tsmiConsultarUsuarios.Size = new System.Drawing.Size(180, 22);
            this.tsmiConsultarUsuarios.Text = "Consultar usuarios";
            this.tsmiConsultarUsuarios.Click += new System.EventHandler(this.tsmiConsultarUsuarios_Click);
            // 
            // tsmiDarDeBajaUsuarios
            // 
            this.tsmiDarDeBajaUsuarios.Name = "tsmiDarDeBajaUsuarios";
            this.tsmiDarDeBajaUsuarios.Size = new System.Drawing.Size(180, 22);
            this.tsmiDarDeBajaUsuarios.Text = "Dar de baja usuarios";
            this.tsmiDarDeBajaUsuarios.Click += new System.EventHandler(this.tsmiDarDeBajaUsuarios_Click);
            // 
            // PantallaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtPerfil);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "PantallaMenu";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.Label txtPerfil;
        private System.Windows.Forms.Label txtFecha;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiPacientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegistrarPaciente;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificarPaciente;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultarPaciente;
        private System.Windows.Forms.ToolStripMenuItem tsmiDarDeBajaPaciente;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmpleados;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegistrarEmpleado;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificarEmpleado;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultarEmpleados;
        private System.Windows.Forms.ToolStripMenuItem tsmiDarDeBajaEmpleado;
        private System.Windows.Forms.ToolStripMenuItem tsmiEstudios;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegistrarEstudio;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificarEstudio;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultarEstudios;
        private System.Windows.Forms.ToolStripMenuItem tsmiDarDeBajaEstudio;
        private System.Windows.Forms.ToolStripMenuItem tsmiServicios;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegistrarServicio;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificarServicio;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultarServicios;
        private System.Windows.Forms.ToolStripMenuItem tsmiDarDeBajaServicio;
        private System.Windows.Forms.ToolStripMenuItem tsmiListadoDePacientes;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegistrarUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificarUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultarUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmiDarDeBajaUsuarios;
    }
}