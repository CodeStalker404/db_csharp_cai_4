namespace WindowsFormsApp1
{
    partial class GestionInstitutoForm
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
            this.bGestionCursos = new System.Windows.Forms.Button();
            this.bGestionAlumnos = new System.Windows.Forms.Button();
            this.bGestionProfesores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bGestionCursos
            // 
            this.bGestionCursos.Location = new System.Drawing.Point(102, 63);
            this.bGestionCursos.Name = "bGestionCursos";
            this.bGestionCursos.Size = new System.Drawing.Size(177, 42);
            this.bGestionCursos.TabIndex = 0;
            this.bGestionCursos.Text = "Gestión Cursos";
            this.bGestionCursos.UseVisualStyleBackColor = true;
            // 
            // bGestionAlumnos
            // 
            this.bGestionAlumnos.Location = new System.Drawing.Point(102, 158);
            this.bGestionAlumnos.Name = "bGestionAlumnos";
            this.bGestionAlumnos.Size = new System.Drawing.Size(177, 42);
            this.bGestionAlumnos.TabIndex = 1;
            this.bGestionAlumnos.Text = "Gestión Alumnos";
            this.bGestionAlumnos.UseVisualStyleBackColor = true;
            this.bGestionAlumnos.Click += new System.EventHandler(this.bGestionAlumnos_Click);
            // 
            // bGestionProfesores
            // 
            this.bGestionProfesores.Location = new System.Drawing.Point(102, 246);
            this.bGestionProfesores.Name = "bGestionProfesores";
            this.bGestionProfesores.Size = new System.Drawing.Size(177, 42);
            this.bGestionProfesores.TabIndex = 2;
            this.bGestionProfesores.Text = "Gestión Profesores";
            this.bGestionProfesores.UseVisualStyleBackColor = true;
            this.bGestionProfesores.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bGestionProfesores_MouseClick);
            // 
            // GestionInstitutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 381);
            this.Controls.Add(this.bGestionProfesores);
            this.Controls.Add(this.bGestionAlumnos);
            this.Controls.Add(this.bGestionCursos);
            this.Name = "GestionInstitutoForm";
            this.Text = "Gestión Instituto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bGestionCursos;
        private System.Windows.Forms.Button bGestionAlumnos;
        private System.Windows.Forms.Button bGestionProfesores;
    }
}