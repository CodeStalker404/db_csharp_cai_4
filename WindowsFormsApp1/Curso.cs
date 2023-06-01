using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Curso
    {
        // Miembros
        private string mCodigo, mNombre;

        // Propiedades
        public string Codigo
        {
            get { return mCodigo; }
            set { mCodigo = value; }
        }

        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }

        // Constructor
        public Curso(string codigo, String nombre)
        {
            mCodigo = codigo;
            mNombre = nombre;
        }
    }
}
