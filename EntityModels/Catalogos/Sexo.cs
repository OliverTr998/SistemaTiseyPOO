using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels.Catalogos
{
    public class Sexo
    {
        #region Caracteristicas de la clase

        /// <summary>
        /// Pripiedades de la clase
        /// </summary>
        private string codigo;
        private string descripcion;

        /// <summary>
        /// Constructor vacio
        /// </summary>
        public Sexo() { }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="codigo">del sexo</param>
        /// <param name="descripcion">del sexo</param>
        public Sexo(string codigo, string descripcion)
        {
            Codigo = codigo;
            Descripcion = descripcion;
        }

        /// <summary>
        /// Encapsulacion de propiedades
        /// </summary>
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        #endregion

        #region Funcionalidades de la clase
        public string BuscarSexo(List<Sexo> sexos, string codigo)
        {
            var band = sexos.Any(x => x.Codigo == codigo);
            if (band)
                return "Si existe";
            else
                return "No existe";
        }
        #endregion
    }
}
