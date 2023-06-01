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
    public partial class GestionProfesoresForm : Form
    {
        // Instancia del objeto que maneja la BD.
        SqlDBHelper sqlDBHelper;

        // Variable que indica en qué registro estamos situados
        private int pos;


        public GestionProfesoresForm()
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
            Profesor profesor;

            profesor = sqlDBHelper.devuelveProfesor(pos);
            
            if(profesor == null)
            {
                txtDni.Text = "Sin datos";
                txtNombre.Text = "Sin datos";
                txtApellidos.Text = "Sin datos";
                txtTelefono.Text = "Sin datos";
                txtEmail.Text = "Sin datos";
            }
            else
            {
                //Cogemos el valor de cada una de las columnas del registro y lo ponemos en el txtBox correspondiente
                txtDni.Text = profesor.Dni;
                txtNombre.Text = profesor.Nombre;
                txtApellidos.Text = profesor.Apellidos;
                txtTelefono.Text = profesor.Tlf;
                txtEmail.Text = profesor.eMail;
            }

            HabilitarDeshabilitarBotones(pos);

            this.lblRegistros.Text = "Registro " + (pos + 1) + " de " + sqlDBHelper.NumProfesores;
        }

        private void HabilitarDeshabilitarBotones(int pos)
        {
            if(pos == 0 && sqlDBHelper.NumProfesores == 0)
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
            else if (pos >= sqlDBHelper.NumProfesores - 1)
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
                pos = sqlDBHelper.NumProfesores - 1;
                mostrarRegistro(pos);
            }
        }


        private bool EsDniValido(string dni)
        {
            bool esDniValido = false;

            if(dni.Length == 9)
            {
                char ultimoCaracter = dni.ElementAt(dni.Length - 1);
                esDniValido = Char.IsLetter(ultimoCaracter);
            }
            return esDniValido;
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

        private bool EsEmailValido(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            return email.Contains("@") && email.Contains(".");
        }

        private bool SePuedeGuardar()
        {
            return EsDniValido(txtDni.Text)
                // El DNI es clave primaria. No puede estar repetido, o lanza excepción.
                && !sqlDBHelper.DniRepetidoProfesor(txtDni.Text)
                && SonTodoLetras(txtNombre.Text)
                && SonTodoLetras(txtApellidos.Text)
                && SonTodoNumeros(txtTelefono.Text)
                && EsEmailValido(txtEmail.Text);
        }
        
        private bool HayCambiosEnRegistroActual()
        {
            Profesor profesor = this.sqlDBHelper.devuelveProfesor(pos);

            bool hayCambios =
                profesor.Dni != txtDni.Text
                || profesor.Nombre != txtNombre.Text
                || profesor.Apellidos != txtApellidos.Text
                || profesor.Tlf != txtTelefono.Text
                || profesor.eMail != txtEmail.Text;

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
            txtDni.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            if(SePuedeGuardar())
            {
                //Creamos el profesor con los datos del formulario
                Profesor profesor = new Profesor(txtDni.Text, txtNombre.Text,
                    txtApellidos.Text, txtTelefono.Text, txtEmail.Text);

                sqlDBHelper.anyadirProfesor(profesor);

                //Actualizamos la posición en la tabla.
                pos = sqlDBHelper.NumProfesores - 1;
            }
            else
            {
                MessageBox.Show(
                    "Hay campos con datos no válidos." +
                    "\nO el DNI ya figura en la base de datos." +
                    "\nRevise los datos introducidos."
                );
            }
        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            //Creamos el profesor con los datos del formulario
            Profesor profesor = new Profesor(txtDni.Text, txtNombre.Text,
                txtApellidos.Text, txtTelefono.Text, txtEmail.Text);

            sqlDBHelper.actualizarProfesor(profesor, pos);
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
                sqlDBHelper.eliminarProfesor(pos);

                // Nos vamos al primer registro y lo mostramos
                pos = 0;
                mostrarRegistro(pos);
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            TextBox txtDni = sender as TextBox;
            if (!EsDniValido(txtDni.Text))
            {
                this.lblValidacionDNI.Text = "DNI inválido. Introduzca un DNI válido.";
                this.lblValidacionDNI.Visible = true;
            }
            else
            {
                this.lblValidacionDNI.Visible = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            TextBox txtNombre = sender as TextBox;
            Console.WriteLine(txtNombre.Text);
            if (!SonTodoLetras(txtNombre.Text))
            {
                this.lblValidacionNombre.Text = "Nombre inválido.\nSolo puede contener letras y espacios.";
                this.lblValidacionNombre.Visible = true;
            }
            else
            {
                this.lblValidacionNombre.Visible = false;
            }
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            TextBox txtApellidos = sender as TextBox;
            if (!SonTodoLetras(txtApellidos.Text))
            {
                this.lblValidacionApellidos.Text = "Apellidos inválidos.\nSolo puede contener letras y espacios.";
                this.lblValidacionApellidos.Visible = true;
            }
            else
            {
                this.lblValidacionApellidos.Visible = false;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            TextBox txtTelefono = sender as TextBox;
            if (!SonTodoNumeros(txtTelefono.Text))
            {
                this.lblValidacionTlfn.Text = "Teléfono inválido.\nSolo puede contener números.";
                this.lblValidacionTlfn.Visible = true;
            }
            else
            {
                this.lblValidacionTlfn.Visible = false;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            TextBox txtEmail = sender as TextBox;
            if (!EsEmailValido(txtEmail.Text))
            {
                this.lblValidacionEmail.Text = "Email inválido.\nDebe contener una \'@\' y un punto.";
                this.lblValidacionEmail.Visible = true;
            }
            else
            {
                this.lblValidacionEmail.Visible = false;
            }
        }
    }
}
