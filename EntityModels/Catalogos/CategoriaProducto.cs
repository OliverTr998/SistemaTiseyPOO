using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels.Catalogos
{
    public class CategoriaProducto
    {
        #region Caracteristicas de la clase

        /// <summary>
        /// Pripiedades de la clase
        /// </summary>
        private string codigo;
        private string nombre;

        /// <summary>
        /// Constructor vacio
        /// </summary>
        public CategoriaProducto() { }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="codigo">del Categoria</param>
        /// <param name="nombre">del Categoria</param>
        public CategoriaProducto(string codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }

        /// <summary>
        /// Encapsulacion de propiedades
        /// </summary>
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        #endregion

        #region Funcionalidades de la clase
        public string BuscarCategoria(List<CategoriaProducto> Categorias, string codigo)
        {
            var band = Categorias.Any(x => x.Codigo == codigo);
            if (band)
                return "Si existe";
            else
                return "No existe";
        }
        #endregion
    }
}
