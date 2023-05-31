namespace WindowsFormsApp1
{
    partial class GestionProfesoresForm
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
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.DNI = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.Label();
            this.Apellidos = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bActualizar = new System.Windows.Forms.Button();
            this.bguardar = new System.Windows.Forms.Button();
            this.bAnyadir = new System.Windows.Forms.Button();
            this.bUltimo = new System.Windows.Forms.Button();
            this.bSiguiente = new System.Windows.Forms.Button();
            this.bAnterior = new System.Windows.Forms.Button();
            this.bPrimero = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.lblValidacionDNI = new System.Windows.Forms.Label();
            this.lblValidacionNombre = new System.Windows.Forms.Label();
            this.lblValidacionApellidos = new System.Windows.Forms.Label();
            this.lblValidacionTlfn = new System.Windows.Forms.Label();
            this.lblValidacionEmail = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(125, 85);
            this.txtDni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 22);
            this.txtDni.TabIndex = 0;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 174);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(125, 263);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono.TabIndex = 2;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(439, 174);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 22);
            this.txtApellidos.TabIndex = 3;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtApellidos_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(439, 263);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Location = new System.Drawing.Point(37, 85);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(30, 16);
            this.DNI.TabIndex = 5;
            this.DNI.Text = "DNI";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(40, 178);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(56, 16);
            this.Nombre.TabIndex = 6;
            this.Nombre.Text = "Nombre";
            // 
            // telefono
            // 
            this.telefono.AutoSize = true;
            this.telefono.Location = new System.Drawing.Point(40, 270);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(29, 16);
            this.telefono.TabIndex = 7;
            this.telefono.Text = "Tlfn";
            // 
            // Apellidos
            // 
            this.Apellidos.AutoSize = true;
            this.Apellidos.Location = new System.Drawing.Point(357, 174);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(64, 16);
            this.Apellidos.TabIndex = 8;
            this.Apellidos.Text = "Apellidos";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(357, 263);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(40, 16);
            this.email.TabIndex = 9;
            this.email.Text = "email";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bEliminar);
            this.groupBox1.Controls.Add(this.bActualizar);
            this.groupBox1.Controls.Add(this.bguardar);
            this.groupBox1.Controls.Add(this.bAnyadir);
            this.groupBox1.Controls.Add(this.bUltimo);
            this.groupBox1.Controls.Add(this.bSiguiente);
            this.groupBox1.Controls.Add(this.bAnterior);
            this.groupBox1.Controls.Add(this.bPrimero);
            this.groupBox1.Location = new System.Drawing.Point(53, 327);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(523, 162);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navegar";
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(356, 95);
            this.bEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(96, 33);
            this.bEliminar.TabIndex = 7;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bActualizar
            // 
            this.bActualizar.Location = new System.Drawing.Point(247, 95);
            this.bActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(96, 33);
            this.bActualizar.TabIndex = 6;
            this.bActualizar.Text = "Actualizar";
            this.bActualizar.UseVisualStyleBackColor = true;
            this.bActualizar.Click += new System.EventHandler(this.bActualizar_Click);
            // 
            // bguardar
            // 
            this.bguardar.Location = new System.Drawing.Point(131, 95);
            this.bguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(99, 33);
            this.bguardar.TabIndex = 5;
            this.bguardar.Text = "Guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // bAnyadir
            // 
            this.bAnyadir.Location = new System.Drawing.Point(19, 95);
            this.bAnyadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAnyadir.Name = "bAnyadir";
            this.bAnyadir.Size = new System.Drawing.Size(99, 33);
            this.bAnyadir.TabIndex = 4;
            this.bAnyadir.Text = "Añadir";
            this.bAnyadir.UseVisualStyleBackColor = true;
            this.bAnyadir.Click += new System.EventHandler(this.bAnyadir_Click);
            // 
            // bUltimo
            // 
            this.bUltimo.Location = new System.Drawing.Point(356, 39);
            this.bUltimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bUltimo.Name = "bUltimo";
            this.bUltimo.Size = new System.Drawing.Size(96, 39);
            this.bUltimo.TabIndex = 3;
            this.bUltimo.Text = "Último";
            this.bUltimo.UseVisualStyleBackColor = true;
            this.bUltimo.Click += new System.EventHandler(this.bUltimo_Click);
            // 
            // bSiguiente
            // 
            this.bSiguiente.Location = new System.Drawing.Point(247, 39);
            this.bSiguiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSiguiente.Name = "bSiguiente";
            this.bSiguiente.Size = new System.Drawing.Size(96, 39);
            this.bSiguiente.TabIndex = 2;
            this.bSiguiente.Text = "Siguiente";
            this.bSiguiente.UseVisualStyleBackColor = true;
            this.bSiguiente.Click += new System.EventHandler(this.bSiguiente_Click);
            // 
            // bAnterior
            // 
            this.bAnterior.Location = new System.Drawing.Point(136, 39);
            this.bAnterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAnterior.Name = "bAnterior";
            this.bAnterior.Size = new System.Drawing.Size(93, 39);
            this.bAnterior.TabIndex = 1;
            this.bAnterior.Text = "Anterior";
            this.bAnterior.UseVisualStyleBackColor = true;
            this.bAnterior.Click += new System.EventHandler(this.bAnterior_Click);
            // 
            // bPrimero
            // 
            this.bPrimero.Location = new System.Drawing.Point(19, 39);
            this.bPrimero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bPrimero.Name = "bPrimero";
            this.bPrimero.Size = new System.Drawing.Size(99, 39);
            this.bPrimero.TabIndex = 0;
            this.bPrimero.Text = "primero";
            this.bPrimero.UseVisualStyleBackColor = true;
            this.bPrimero.Click += new System.EventHandler(this.bPrimero_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(436, 85);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(65, 16);
            this.lblRegistros.TabIndex = 11;
            this.lblRegistros.Text = "Registros";
            // 
            // lblValidacionDNI
            // 
            this.lblValidacionDNI.AutoSize = true;
            this.lblValidacionDNI.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidacionDNI.ForeColor = System.Drawing.Color.Red;
            this.lblValidacionDNI.Location = new System.Drawing.Point(127, 109);
            this.lblValidacionDNI.Name = "lblValidacionDNI";
            this.lblValidacionDNI.Size = new System.Drawing.Size(67, 16);
            this.lblValidacionDNI.TabIndex = 12;
            this.lblValidacionDNI.Text = "Valid. DNI";
            this.lblValidacionDNI.Visible = false;
            // 
            // lblValidacionNombre
            // 
            this.lblValidacionNombre.AutoSize = true;
            this.lblValidacionNombre.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidacionNombre.ForeColor = System.Drawing.Color.Red;
            this.lblValidacionNombre.Location = new System.Drawing.Point(122, 198);
            this.lblValidacionNombre.Name = "lblValidacionNombre";
            this.lblValidacionNombre.Size = new System.Drawing.Size(90, 16);
            this.lblValidacionNombre.TabIndex = 13;
            this.lblValidacionNombre.Text = "Valid. nombre";
            this.lblValidacionNombre.Visible = false;
            // 
            // lblValidacionApellidos
            // 
            this.lblValidacionApellidos.AutoSize = true;
            this.lblValidacionApellidos.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidacionApellidos.ForeColor = System.Drawing.Color.Red;
            this.lblValidacionApellidos.Location = new System.Drawing.Point(436, 198);
            this.lblValidacionApellidos.Name = "lblValidacionApellidos";
            this.lblValidacionApellidos.Size = new System.Drawing.Size(100, 16);
            this.lblValidacionApellidos.TabIndex = 14;
            this.lblValidacionApellidos.Text = "Valid. apellidos";
            this.lblValidacionApellidos.Visible = false;
            // 
            // lblValidacionTlfn
            // 
            this.lblValidacionTlfn.AutoSize = true;
            this.lblValidacionTlfn.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidacionTlfn.ForeColor = System.Drawing.Color.Red;
            this.lblValidacionTlfn.Location = new System.Drawing.Point(122, 287);
            this.lblValidacionTlfn.Name = "lblValidacionTlfn";
            this.lblValidacionTlfn.Size = new System.Drawing.Size(60, 16);
            this.lblValidacionTlfn.TabIndex = 15;
            this.lblValidacionTlfn.Text = "Valid. tlfn";
            this.lblValidacionTlfn.Visible = false;
            // 
            // lblValidacionEmail
            // 
            this.lblValidacionEmail.AutoSize = true;
            this.lblValidacionEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidacionEmail.ForeColor = System.Drawing.Color.Red;
            this.lblValidacionEmail.Location = new System.Drawing.Point(436, 287);
            this.lblValidacionEmail.Name = "lblValidacionEmail";
            this.lblValidacionEmail.Size = new System.Drawing.Size(77, 16);
            this.lblValidacionEmail.TabIndex = 16;
            this.lblValidacionEmail.Text = "Valid. email";
            this.lblValidacionEmail.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 535);
            this.Controls.Add(this.lblValidacionEmail);
            this.Controls.Add(this.lblValidacionTlfn);
            this.Controls.Add(this.lblValidacionApellidos);
            this.Controls.Add(this.lblValidacionNombre);
            this.Controls.Add(this.lblValidacionDNI);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Gestión Profesores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label telefono;
        private System.Windows.Forms.Label Apellidos;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bUltimo;
        private System.Windows.Forms.Button bSiguiente;
        private System.Windows.Forms.Button bAnterior;
        private System.Windows.Forms.Button bPrimero;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Button bAnyadir;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bActualizar;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label lblValidacionDNI;
        private System.Windows.Forms.Label lblValidacionNombre;
        private System.Windows.Forms.Label lblValidacionApellidos;
        private System.Windows.Forms.Label lblValidacionTlfn;
        private System.Windows.Forms.Label lblValidacionEmail;
    }
}

