using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregable_Esteban_Pucheta
{
    internal class ProductoVendido
    {
        private int _id;
        private int _idProducto;
        private int _stock;
        private int _idVenta;
        
        public ProductoVendido()
        {
            _id = 0;
            _idProducto = 0;
            _stock = 0;
            _idVenta = 0;
        }

        public ProductoVendido(int id, int idproducto, int stock, int idventa)
        {
            this._id = id;
            this._idProducto = idproducto;
            this._stock = stock;
            this._idVenta = idventa;
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

       
    }
}
