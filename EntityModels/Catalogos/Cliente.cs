using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels.Catalogos
{
    public class Cliente : Persona
    {
        #region Caracteristicas de la clase

        /// <summary>
        /// Pripiedades de la clase
        /// </summary>
        private string cedula;

        /// <summary>
        /// Constructor vacio
        /// </summary>
        public Cliente() { }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="cedula">del Categoria</param>
        /// <param name="descripcion">del Categoria</param>
        public Cliente(string cedula)
        {
            Cedula = cedula;
        }

        /// <summary>
        /// Encapsulacion de propiedades
        /// </summary>
        public string Cedula { get => cedula; set => cedula = value; }

        #endregion
    }
}
