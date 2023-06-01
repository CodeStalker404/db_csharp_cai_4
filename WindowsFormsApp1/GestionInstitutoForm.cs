using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GestionInstitutoForm : Form
    {
        public GestionInstitutoForm()
        {
            InitializeComponent();
        }

        private void bGestionCursos_Click(object sender, EventArgs e)
        {
            GestionCursosForm gestionCursosForm = new GestionCursosForm();
            gestionCursosForm.ShowDialog();
        }

        private void bGestionProfesores_MouseClick(object sender, MouseEventArgs e)
        {
            GestionProfesoresForm gestionProfesoresForm = new GestionProfesoresForm();
            gestionProfesoresForm.ShowDialog();
        }

        private void bGestionAlumnos_Click(object sender, EventArgs e)
        {
            GestionAlumnosForm gestionAlumnosForm = new GestionAlumnosForm();
            gestionAlumnosForm.ShowDialog();
        }
    }
}
