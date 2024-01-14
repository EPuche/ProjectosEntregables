using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregable_Esteban_Pucheta
{
    internal class Producto
    {
        private int _id;
        private string _descripcion;
        private double _costo;
        private double _precioVenta;
        private int _stock;
        private int _idUsuario;

        public Producto()
        {
            _id = 0;
            _descripcion = string.Empty;
            _costo = 0;
            _precioVenta = 0;
            _stock = 0;
            _idUsuario = 0;
        }

        public Producto(int id, string descripcion,double costo, double precioventa, int stock, int idusuario)
        {
            _id=id;
            _descripcion=descripcion;
            _costo=costo;
            _precioVenta=precioventa;
            _stock=stock;
            _idUsuario=idusuario;
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

        public string Descripcion
        {
            get
            {
                return this._descripcion;
            }
            set
            {
                this._descripcion = value;
            }
        }

        public double Costo
        {
            get
            {
                return this._costo;
            }
            set
            {
                this._costo = value;
            }
        }

        public double PrecioVenta
        {
            get
            {
                return this._precioVenta;
            }
            set
            {
                this._precioVenta = value;
            }
        }

        public int Stock
        {
            get
            {
                return this._stock;
            }
            set
            {
                this._stock = value;
            }
        }

    }
}
