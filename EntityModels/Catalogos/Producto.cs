using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels.Catalogos
{
    public class Producto
    {
        #region Caracteristicas de la clase

        /// <summary>
        /// Pripiedades de la clase
        /// </summary>
        private string codigo;
        private string nombre;
        private CategoriaProducto categoriaProducto;
        private int existencia;
        private double precio;

        /// <summary>
        /// Constructor vacio
        /// </summary>
        public Producto() { }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="codigo">del Categoria</param>
        /// <param name="nombre">del Categoria</param>

        public Producto(string codigo, string nombre, CategoriaProducto categoriaProducto, int existencia, double precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            CategoriaProducto = categoriaProducto;
            Existencia = existencia;
            Precio = precio;
        }

        /// <summary>
        /// Encapsulacion de propiedades
        /// </summary>
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public CategoriaProducto CategoriaProducto { get => categoriaProducto; set => categoriaProducto = value; }
        public int Existencia { get => existencia; set => existencia = value; }
        public double Precio { get => precio; set => precio = value; }

        #endregion
    }
}
