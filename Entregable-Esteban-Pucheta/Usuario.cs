using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregable_Esteban_Pucheta
{
    internal class Usuario
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private string _contraseña;
        private string _email;

        public Usuario ()
        {
            _id = 0;
            _nombre = string.Empty;
            _apellido = string.Empty;
            _nombreUsuario = string.Empty;
            _contraseña = string.Empty;
            _email = string.Empty;
        }

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contraseña, string email)
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._nombreUsuario = nombreUsuario;
            this._contraseña = contraseña;
            this._email = email;
        }

        public int ID
        {
            get 
            { 
                return this._id; 
            }
            set
            {
                this._id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this._apellido;
            }
            set
            {
                this._apellido = value;
            }
        }

        public string NombreUsuario
        {
            get
            {
                return this._nombreUsuario;
            }
            set
            {
                this._nombreUsuario = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return this._contraseña;
            }
            set
            {
                this._contraseña = value;
            }
        }

        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }
    }
}
