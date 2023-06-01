namespace WindowsFormsApp1
{
    partial class GestionCursosForm
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
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
            this.lblValidacionCodigo = new System.Windows.Forms.Label();
            this.lblValidacionNombre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(129, 169);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(364, 169);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(69, 175);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(51, 16);
            this.Codigo.TabIndex = 5;
            this.Codigo.Text = "Código";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(286, 175);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(56, 16);
            this.Nombre.TabIndex = 6;
            this.Nombre.Text = "Nombre";
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
            this.lblRegistros.Location = new System.Drawing.Point(386, 82);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(65, 16);
            this.lblRegistros.TabIndex = 11;
            this.lblRegistros.Text = "Registros";
            // 
            // lblValidacionCodigo
            // 
            this.lblValidacionCodigo.AutoSize = true;
            this.lblValidacionCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidacionCodigo.ForeColor = System.Drawing.Color.Red;
            this.lblValidacionCodigo.Location = new System.Drawing.Point(126, 193);
            this.lblValidacionCodigo.Name = "lblValidacionCodigo";
            this.lblValidacionCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblValidacionCodigo.Size = new System.Drawing.Size(88, 16);
            this.lblValidacionCodigo.TabIndex = 12;
            this.lblValidacionCodigo.Text = "Valid. Código";
            this.lblValidacionCodigo.Visible = false;
            // 
            // lblValidacionNombre
            // 
            this.lblValidacionNombre.AutoSize = true;
            this.lblValidacionNombre.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidacionNombre.ForeColor = System.Drawing.Color.Red;
            this.lblValidacionNombre.Location = new System.Drawing.Point(361, 193);
            this.lblValidacionNombre.Name = "lblValidacionNombre";
            this.lblValidacionNombre.Size = new System.Drawing.Size(90, 16);
            this.lblValidacionNombre.TabIndex = 13;
            this.lblValidacionNombre.Text = "Valid. nombre";
            this.lblValidacionNombre.Visible = false;
            // 
            // GestionCursosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 535);
            this.Controls.Add(this.lblValidacionNombre);
            this.Controls.Add(this.lblValidacionCodigo);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GestionCursosForm";
            this.Text = "Gestión Cursos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Label Nombre;
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
        private System.Windows.Forms.Label lblValidacionCodigo;
        private System.Windows.Forms.Label lblValidacionNombre;
    }
}

