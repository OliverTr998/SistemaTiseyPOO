using EntityModels.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels.Movimientos
{
    public class DetalleCompra
    {
        private int catidad;
        private Producto producto;

        public DetalleCompra(){}

        public DetalleCompra(int catidad, Producto producto)
        {
            Catidad = catidad;
            Producto = producto;
        }

        public int Catidad { get => catidad; set => catidad = value; }
        public Producto Producto { get => producto; set => producto = value; }
    }
}
