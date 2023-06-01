using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Text.RegularExpressions;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class GestionCursosForm : Form
    {
        // Instancia del objeto que maneja la BD.
        SqlDBHelper sqlDBHelper;

        // Variable que indica en qué registro estamos situados
        private int pos;


        public GestionCursosForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Creamos el objeto BD
            sqlDBHelper = new SqlDBHelper();

            // Situamos la primera posición
            // y mostramos el registro
            pos = 0;
            mostrarRegistro(pos);
        }


        private void mostrarRegistro(int pos)
        {
            Curso curso;

            curso = sqlDBHelper.devuelveCurso(pos);
            
            if(curso == null)
            {
                txtCodigo.Text = "Sin datos";
                txtNombre.Text = "Sin datos";
            }
            else
            {
                //Cogemos el valor de cada una de las columnas del registro y lo ponemos en el txtBox correspondiente
                txtCodigo.Text = curso.Codigo;
                txtNombre.Text = curso.Nombre;
            }

            HabilitarDeshabilitarBotones(pos);

            this.lblRegistros.Text = "Registro " + (pos + 1) + " de " + sqlDBHelper.NumCursos;
        }

        private void HabilitarDeshabilitarBotones(int pos)
        {
            if(pos == 0 && sqlDBHelper.NumCursos == 0)
            { // Si no hay ningún registro se deshabilitan todos
                this.bPrimero.Enabled = false;
                this.bAnterior.Enabled = false;
                this.bUltimo.Enabled = false;
                this.bSiguiente.Enabled = false;
                // También deshabilitar botón Eliminar
                this.bEliminar.Enabled = false;
            }
            else if (pos <= 0)
            { // En la primera posición se deshabilitan los botones Primero y Anterior
                this.bPrimero.Enabled = false;
                this.bAnterior.Enabled = false;
                this.bUltimo.Enabled = true;
                this.bSiguiente.Enabled = true;
            }
            else if (pos >= sqlDBHelper.NumCursos - 1)
            { // En la última posición se deshabilitan los botones Último y Siguiente
                this.bPrimero.Enabled = true;
                this.bAnterior.Enabled = true;
                this.bUltimo.Enabled = false;
                this.bSiguiente.Enabled = false;
            }
        }


        private void bPrimero_Click(object sender, EventArgs e)
        {
            // Si no hay cambios se pasa a mostrar el primer registro
            if (SePuedeCambiarDeRegistro())
            {
                //Para saber qué tipo de objetco es sender
                Console.WriteLine(sender.GetType().Name);

                //He cambiado el tipo del objeto sender a botón (castear)
                Button btn = sender as Button;

                // Ponemos la primera posición
                pos = 0;
                mostrarRegistro(pos);
            }
        }

        private void bAnterior_Click(object sender, EventArgs e)
        {
            // Si no hay cambios se pasa a mostrar el anterior registro
            if (SePuedeCambiarDeRegistro())
            {
                //He cambiado el tipo del objeto sender a botón (castear)
                Button btn = sender as Button;

                // Vamos a la posición anterior.
                pos--;

                //activamos el botón
                this.bSiguiente.Enabled = true;
                this.bUltimo.Enabled = true;
                mostrarRegistro(pos);
            }
        }

        private void bSiguiente_Click(object sender, EventArgs e)
        {
            // Si no hay cambios se pasa a mostrar el siguiente registro
            if (SePuedeCambiarDeRegistro())
            {
                //He cambiado el tipo del objeto sender a botón (castear)
                Button btn = sender as Button;

                // Vamos a la posición siguiente
                pos++;
                Console.WriteLine(pos.ToString());

                this.bAnterior.Enabled = true;
                this.bPrimero.Enabled = true;
                mostrarRegistro(pos);
            }
        }

        private void bUltimo_Click(object sender, EventArgs e)
        {
            // Si no hay cambios se pasa a mostrar el último registro
            if (SePuedeCambiarDeRegistro())
            {
                Button btn = sender as Button;
                // Vamos a la última posición.
                // Los registros van del 0 al numero de registros - 1
                pos = sqlDBHelper.NumCursos - 1;
                mostrarRegistro(pos);
            }
        }

        private bool SonTodoLetras(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            foreach (char c in input)
            {
                if (!Char.IsLetter(c) && c != ' ')
                {
                    Console.WriteLine(c + " apesta");
                    return false;
                }
            }
            return true;
        }

        private bool SonTodoNumeros(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            foreach (char c in input)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool SePuedeGuardar()
        {
            return SonTodoNumeros(txtCodigo.Text)
                // El Codigo es clave primaria. No puede estar repetido, o lanza excepción.
                && !sqlDBHelper.CodigoRepetidoCurso(txtCodigo.Text)
                && !String.IsNullOrEmpty(txtNombre.Text);
        }
        
        private bool HayCambiosEnRegistroActual()
        {
            Curso curso = this.sqlDBHelper.devuelveCurso(pos);

            bool hayCambios =
                curso.Codigo != txtCodigo.Text
                || curso.Nombre != txtNombre.Text;

            return hayCambios;
        }

        private bool SePuedeCambiarDeRegistro()
        {
            bool sePuedeCambiar = true;
            // Si hay cambios en los textbox se pregunta al usuario si está seguro de querer continuar
            if (HayCambiosEnRegistroActual())
            {
                DialogResult result = MessageBox.Show("Hay cambios en el registro actual. Los datos no guardados se perderán.", "¿Desea continuar? ", MessageBoxButtons.YesNo);

                sePuedeCambiar = result.Equals(DialogResult.Yes);
            }

            return sePuedeCambiar;
        }

        private void bAnyadir_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombre.Clear();
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            if(SePuedeGuardar())
            {
                //Creamos el curso con los datos del formulario
                Curso curso = new Curso(txtCodigo.Text, txtNombre.Text);

                sqlDBHelper.anyadirCurso(curso);

                //Actualizamos la posición en la tabla.
                pos = sqlDBHelper.NumCursos - 1;
            }
            else
            {
                MessageBox.Show(
                    "Hay campos con datos no válidos." +
                    "\nO el Código ya figura en la base de datos." +
                    "\nRevise los datos introducidos."
                );
            }
        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            //Creamos el curso con los datos del formulario
            Curso curso = new Curso(txtCodigo.Text, txtNombre.Text);

            sqlDBHelper.actualizarCurso(curso, pos);
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            // Mostramos cuadro de diálogo para pedir confirmación de eliminación al usuario.
            DialogResult result = MessageBox.Show(
                    "Si confirma se eliminará el registro actual. ¿Desea eliminarlo?",
                    "¿Desea eliminar el registro actual? ",
                    MessageBoxButtons.YesNo
                );

            // Respuesta del usuario a eliminar o no el registro.
            bool eliminar = result.Equals(DialogResult.Yes);

            // Se elimina el registro si el usuario ha respondido que Sí.
            if (eliminar)
            {
                sqlDBHelper.eliminarCurso(pos);

                // Nos vamos al primer registro y lo mostramos
                pos = 0;
                mostrarRegistro(pos);
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            TextBox txtCodigo = sender as TextBox;
            if (!SonTodoNumeros(txtCodigo.Text))
            {
                this.lblValidacionCodigo.Text = "Código inválido.\nIntroduzca un Código válido.";
                this.lblValidacionCodigo.Visible = true;
            }
            else
            {
                this.lblValidacionCodigo.Visible = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            TextBox txtNombre = sender as TextBox;
            Console.WriteLine(txtNombre.Text);
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                this.lblValidacionNombre.Text = "Nombre inválido.\nNo puede estar vacío.";
                this.lblValidacionNombre.Visible = true;
            }
            else
            {
                this.lblValidacionNombre.Visible = false;
            }
        }
    }
}
