using EntityModels.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels.Movimientos
{
    public class Compra
    {
        private string codigo;
        private DateTime fechaCompra;
        private Empleado empleado;
        private List<DetalleCompra> detalleCompras;

        public Compra() { }

        public Compra(string codigo, DateTime fechaCompra, Empleado empleado, List<DetalleCompra> detalleCompras)
        {
            Codigo = codigo;
            FechaCompra = fechaCompra;
            Empleado = empleado;
            DetalleCompras = detalleCompras;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }
        public Empleado Empleado { get => empleado; set => empleado = value; }
        public List<DetalleCompra> DetalleCompras { get => detalleCompras; set => detalleCompras = value; }
    }
}
