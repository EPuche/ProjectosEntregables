using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregable_Esteban_Pucheta
{
    internal class Venta
    {
        private int _id;
        private string _comentarios;
        private int _idUsuario;

        public Venta()
        {
            _id = 0;
            _comentarios = string.Empty; 
            _idUsuario = 0;
        }

        public Venta(int id, string comentarios, int idusuario)
        {
            this._id = id;
            this._comentarios = comentarios;
            this._idUsuario = idusuario;
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

        public string Comentarios
        {
            get 
            { 
            return this._comentarios;
            }
            set
            {
                this._comentarios = value;
            }
        }
    }
}
