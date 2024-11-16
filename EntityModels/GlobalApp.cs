using EntityModels.Catalogos;
using EntityModels.Movimientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public static class GlobalApp
    {
        #region Listas De Catalogos
        /// <summary>
        /// Listas Global de sexos
        /// </summary>
        public static List<Sexo> Sexos = new List<Sexo>()
        {
            new Sexo("01-F", "Femenino"),
            new Sexo("02-F", "Masculino"),
        };

        /// <summary>
        /// Lista Global de Categorias
        /// </summary>
        public static List<CategoriaProducto> CategoriaProductos = new List<CategoriaProducto>()
        {
            new CategoriaProducto("01P", "Libreria"),
            new CategoriaProducto("02P", "Chiveria"),
            new CategoriaProducto("03P", "Juguete"),
            new CategoriaProducto("04P", "Bebida"),
            new CategoriaProducto("05P", "Cosmeticos"),
        };

        public static List<Cliente> Clientes = new List<Cliente>();

        public static List<Producto> Productos = new List<Producto>();

        public static List<Empleado> Empleado = new List<Empleado>();
        #endregion

        #region Listas de Movimientos

        public static List<Compra> Compras = new List<Compra>();

        public static List<Factura> Facturas = new List<Factura>();
        #endregion

    }
}
