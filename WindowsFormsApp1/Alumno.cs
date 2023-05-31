using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Alumno
    {
        // Miembros
        private string mDni, mNombre, mApellidos, mDireccion, mTlf, meMail;

        // Propiedades
        public string Dni
        {
            get { return mDni; }
            set { mDni = value; }
        }

        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }

        // Otra posible forma de hacer la propiedad
        public string Apellidos
        {
            get => mApellidos;
            set => mApellidos = value;
        }

        public string Direccion
        {
            get => mDireccion;
            set => mDireccion = value;
        }

        public string Tlf
        {
            get => mTlf;
            set => mTlf = value;
        }

        public string eMail
        {
            get => meMail;
            set => meMail = value;
        }

        // Constructor
        public Alumno(string dni, String nombre, String apellidos,
            string direccion, string tlf, string email)
        {
            mDni = dni;
            mNombre = nombre;
            mApellidos = apellidos;
            mDireccion = direccion;
            mTlf = tlf;
            meMail = email;
        }
    }
}
