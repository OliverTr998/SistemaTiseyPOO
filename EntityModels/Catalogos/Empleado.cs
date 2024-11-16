using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels.Catalogos
{
    public class Empleado : Persona
    {
        #region Caracteristicas de la clase

        /// <summary>
        /// Pripiedades de la clase
        /// </summary>
        private string inss;

        /// <summary>
        /// Constructor vacio
        /// </summary>
        public Empleado() { }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="cedula">del Categoria</param>
        /// <param name="descripcion">del Categoria</param>
        public Empleado(string inss)
        {
            INSS = inss;
        }

        /// <summary>
        /// Encapsulacion de propiedades
        /// </summary>
        public string INSS { get => inss; set => inss = value; }

        #endregion
    }
}
