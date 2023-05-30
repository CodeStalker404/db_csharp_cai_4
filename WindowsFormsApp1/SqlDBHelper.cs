using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class SqlDBHelper
    {
        // Miembros para guardar el dataSet y el dataAdapter de profesores.
        private DataSet dsProfesores;
        private SqlDataAdapter daProfesores;

        // Miembro para guardar el número de profesores.
        private int numProfesores;
        // Propiedad de solo lectura.
        public int NumProfesores
        {
            get => numProfesores;
        }

        // Constructor del objeto.
        // En el mismo hacemos la conexión y creamos dataSet y dataAdapter
        public SqlDBHelper()
        {
            //string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\JRJ_1\\Projects\\db_csharp_cai\\Instituto.mdf;Integrated Security=True;Connect Timeout=30";
            string cadenaConexion = "data source = (localdb)\\mssqllocaldb;" +
               "attachdbfilename = c:\\users\\cai\\onedrive\\escritorio\\daw\\programación\\tema 9\\ejercicios\\db_csharp_cai_4\\instituto.mdf;" +
               "integrated security = true; connect timeout = 30";

            SqlConnection con = new SqlConnection(cadenaConexion);

            // Abrimos la conexión.
            con.Open();

            string cadenaSQL = "SELECT * From Profesores";
            daProfesores = new SqlDataAdapter(cadenaSQL, con);

            dsProfesores = new DataSet();

            daProfesores.Fill(dsProfesores, "Profesores");

            // Obtenemos el número de profesores
            numProfesores = dsProfesores.Tables["Profesores"].Rows.Count;

            // Cerramos la conexión.
            con.Close();
        }


        // Método que a partir de una posición en la BD
        // Devuelve un objeto profesor.
        // Devuelve null si pos está fuera de los límites
        public Profesor devuelveProfesor(int pos)
        {
            Profesor profesor = null;

            if (pos >= 0 && pos < numProfesores)
            {
                // Objeto que nos permite recoger un registro de la tabla.
                DataRow dRegistro;

                // Cogemos el registro de la posición pos en la tabla Profesores
                dRegistro = dsProfesores.Tables["Profesores"].Rows[pos];

                // Cogemos el valor de cada una de las columnas del registro
                // y lo creamos el objeto profesor con esos datos.
                profesor = new Profesor(dRegistro[0].ToString(),
                    dRegistro[1].ToString(), dRegistro[2].ToString(),
                    dRegistro[3].ToString(), dRegistro[4].ToString()
                );
            }
            return profesor;
        }

        // Metodos CRUD

        // Método que añade un profesor a nuestra BD
        public void anyadirProfesor(Profesor profesor)
        {
            // Creamos un nuevo registro.
            DataRow dRegistro = dsProfesores.Tables["Profesores"].NewRow();

            // Metemos los datos en el nuevo registro
            dRegistro[0] = profesor.Dni;
            dRegistro[1] = profesor.Nombre;
            dRegistro[2] = profesor.Apellidos;
            dRegistro[3] = profesor.Tlf;
            dRegistro[4] = profesor.eMail;

            // Si quisieramos hacerlo por nombre de columna en vez de posición
            // dRegistro["DNI"] = profesor.Dni;

            // Añadimos el registro al Dataset
            dsProfesores.Tables["Profesores"].Rows.Add(dRegistro);

            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daProfesores);
            daProfesores.Update(dsProfesores, "Profesores");

            // Actualizamos el número de profesores
            numProfesores++;
        }

        // Actualizamos los datos del profesor
        // situado en la posición pos
        public void actualizarProfesor(Profesor profesor, int pos)
        {
            // Cogemos el registro situado en la posición actual.
            DataRow dRegistro = dsProfesores.Tables["Profesores"].Rows[pos];

            // Metemos los datos en el registro
            dRegistro[0] = profesor.Dni;
            dRegistro[1] = profesor.Nombre;
            dRegistro[2] = profesor.Apellidos;
            dRegistro[3] = profesor.Tlf;
            dRegistro[4] = profesor.eMail;

            // Si quisieramos hacerlo por nombre de columna en vez de posición
            // dRegistro["DNI"] = profesor.Dni;

            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daProfesores);
            daProfesores.Update(dsProfesores, "Profesores");
        }

        public void eliminarProfesor(int pos)
        {
            if(numProfesores > 0)
            {
                // Eliminamos el registro situado en la posición actual.
                dsProfesores.Tables["Profesores"].Rows[pos].Delete();

                // Tenemos un profesor menos
                numProfesores--;

                // Reconectamos con el dataAdapter y actualizamos la BD
                SqlCommandBuilder cb = new SqlCommandBuilder(daProfesores);
                daProfesores.Update(dsProfesores, "Profesores");
            }
        }

        public bool DniRepetido(string dni)
        {
            bool dniRepetido = false;

            for(int i = 0; i < NumProfesores; i++)
            {
                Profesor profesor = devuelveProfesor(i);
                if (profesor != null && profesor.Dni == dni)
                {
                    dniRepetido = true;
                }
            }
            
            return dniRepetido;
        }
    }
}
