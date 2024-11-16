using EntityModels.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels.Movimientos
{
    public class Factura
    {
        private string codigo;
        private DateTime fechaCompra;
        private Empleado empleado;
        private Cliente cliente;
        private List<DetalleFactura> detalleFacturas;

        public Factura() { }

        public Factura(string codigo, DateTime fechaCompra, Empleado empleado, Cliente cliente, List<DetalleFactura> detalleFacturas)
        {
            Codigo = codigo;
            FechaCompra = fechaCompra;
            Empleado = empleado;
            Cliente = cliente;
            DetalleFacturas = detalleFacturas;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }
        public Empleado Empleado { get => empleado; set => empleado = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public List<DetalleFactura> DetalleFacturas { get => detalleFacturas; set => detalleFacturas = value; }
    }
}
