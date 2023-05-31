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
        // Miembros para guardar el dataSet y el dataAdapter de alumnos.
        private DataSet dsAlumnos;
        private SqlDataAdapter daAlumnos;
        // Miembros para guardar el dataSet y el dataAdapter de cursos.
        private DataSet dsCursos;
        private SqlDataAdapter daCursos;

        // Miembro para guardar el número de profesores.
        private int numProfesores;
        private int numAlumnos;
        private int numCursos;

        // Propiedad de solo lectura.
        public int NumProfesores
        {
            get => numProfesores;
        }
        public int NumAlumnos
        {
            get => numAlumnos;
        }
        public int NumCursos
        {
            get => numCursos;
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

            string cadenaSQLProfesores = "SELECT * From Profesores";
            daProfesores = new SqlDataAdapter(cadenaSQLProfesores, con);

            dsProfesores = new DataSet();

            daProfesores.Fill(dsProfesores, "Profesores");

            // Obtenemos el número de profesores
            numProfesores = dsProfesores.Tables["Profesores"].Rows.Count;


            string cadenaSQLAlumnos = "SELECT * From Alumnos";
            daAlumnos = new SqlDataAdapter(cadenaSQLAlumnos, con);

            dsAlumnos = new DataSet();

            daAlumnos.Fill(dsAlumnos, "Alumnos");

            // Obtenemos el número de alumnos
            numAlumnos = dsAlumnos.Tables["Alumnos"].Rows.Count;

            // Cerramos la conexión.
            con.Close();
        }


        // Método que a partir de una posición en la BD
        // Devuelve un objeto alumno.
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
                // y lo creamos el objeto alumno con esos datos.
                profesor = new Profesor(dRegistro[0].ToString(),
                    dRegistro[1].ToString(), dRegistro[2].ToString(),
                    dRegistro[3].ToString(), dRegistro[4].ToString()
                );
            }
            return profesor;
        }

        // Método que a partir de una posición en la BD
        // Devuelve un objeto alumno.
        // Devuelve null si pos está fuera de los límites
        public Alumno devuelveAlumno(int pos)
        {
            Alumno alumno = null;

            if (pos >= 0 && pos < numAlumnos)
            {
                // Objeto que nos permite recoger un registro de la tabla.
                DataRow dRegistro;

                // Cogemos el registro de la posición pos en la tabla Alumnos
                dRegistro = dsAlumnos.Tables["Alumnos"].Rows[pos];

                // Cogemos el valor de cada una de las columnas del registro
                // y lo creamos el objeto alumno con esos datos.
                alumno = new Alumno(dRegistro[0].ToString(),
                    dRegistro[1].ToString(), dRegistro[2].ToString(),
                    dRegistro[3].ToString(), dRegistro[4].ToString(),
                    dRegistro[5].ToString()
                );
            }
            return alumno;
        }

        // Metodos CRUD

        // Método que añade un alumno a nuestra BD
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
            // dRegistro["DNI"] = alumno.Dni;

            // Añadimos el registro al Dataset
            dsProfesores.Tables["Profesores"].Rows.Add(dRegistro);

            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daProfesores);
            daProfesores.Update(dsProfesores, "Profesores");

            // Actualizamos el número de profesores
            numProfesores++;
        }

        public void anyadirAlumno(Alumno alumno)
        {
            // Creamos un nuevo registro.
            DataRow dRegistro = dsProfesores.Tables["Alumnos"].NewRow();

            // Metemos los datos en el nuevo registro
            dRegistro[0] = alumno.Dni;
            dRegistro[1] = alumno.Nombre;
            dRegistro[2] = alumno.Apellidos;
            dRegistro[3] = alumno.Direccion;
            dRegistro[3] = alumno.Tlf;
            dRegistro[4] = alumno.eMail;

            // Si quisieramos hacerlo por nombre de columna en vez de posición
            // dRegistro["DNI"] = alumno.Dni;

            // Añadimos el registro al Dataset
            dsProfesores.Tables["Alumnos"].Rows.Add(dRegistro);

            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daProfesores);
            daProfesores.Update(dsProfesores, "Alumnos");

            // Actualizamos el número de profesores
            numProfesores++;
        }
        // TODO seguir copiando métodos para alumnos
        // Actualizamos los datos del alumno
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
            // dRegistro["DNI"] = alumno.Dni;

            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daProfesores);
            daProfesores.Update(dsProfesores, "Profesores");
        }

        // Actualizamos los datos del alumno
        // situado en la posición pos
        public void actualizarAlumno(Alumno alumno, int pos)
        {
            // Cogemos el registro situado en la posición actual.
            DataRow dRegistro = dsProfesores.Tables["Alumnos"].Rows[pos];

            // Metemos los datos en el registro
            dRegistro[0] = alumno.Dni;
            dRegistro[1] = alumno.Nombre;
            dRegistro[2] = alumno.Apellidos;
            dRegistro[3] = alumno.Direccion;
            dRegistro[4] = alumno.Tlf;
            dRegistro[5] = alumno.eMail;

            // Si quisieramos hacerlo por nombre de columna en vez de posición
            // dRegistro["DNI"] = alumno.Dni;

            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daProfesores);
            daProfesores.Update(dsProfesores, "Alumnos");
        }

        public void eliminarProfesor(int pos)
        {
            if(numProfesores > 0)
            {
                // Eliminamos el registro situado en la posición actual.
                dsProfesores.Tables["Profesores"].Rows[pos].Delete();

                // Tenemos un alumno menos
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
