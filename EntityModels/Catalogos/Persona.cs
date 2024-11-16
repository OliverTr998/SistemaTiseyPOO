using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels.Catalogos
{
    public class Persona
    {
        #region Caracteristicas de la clase

        /// <summary>
        /// Pripiedades de la clase
        /// </summary>
        private string nombres;
        private string apellidos;
        private string direccion;
        private DateTime fechaNacimiento;
        private Sexo sexo;

        /// <summary>
        /// Constructor vacio
        /// </summary>
        public Persona() { }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="cedula">del Categoria</param>
        /// <param name="descripcion">del Categoria</param>
    
        public Persona(string nombres, string apellidos, string direccion, DateTime fechaNacimiento, Sexo sexo)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
            Sexo = sexo;
        }

        /// <summary>
        /// Encapsulacion de propiedades
        /// </summary>
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public Sexo Sexo { get => sexo; set => sexo = value; }

        #endregion

        #region Funcionalidades de clase
        public int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - FechaNacimiento.Year;

            // Ajusta la edad si la fecha de nacimiento aún no ha ocurrido este año
            if (fechaNacimiento > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }
        #endregion
    }
}
