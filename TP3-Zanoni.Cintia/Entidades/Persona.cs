using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas

{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;


        /// <summary>
        /// propiedad del atributo apellido de lectura y escritura
        /// valida que se ingresen caracteres validos para apellidos
        /// reutilizando el metodo de validacion
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = ValidarNombreApellido(value); }
        }

        /// <summary>
        /// propiedad del atributo dni de lectura y escritura
        /// valida tipo y cantidad de caracteres segun nacionalidad reutilizando metodo de validacion
        /// Nacionalidad Argentina entre 1 y 89999999
        /// Extranjero entre 90000000 y 99999999
        /// </summary>
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = ValidarDni(this.nacionalidad, value); }
        }

        /// <summary>
        /// propiedad del atributo nacionalidad de lectura y escritura
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }

        /// <summary>
        /// propiedad del atributo nombre de lectura y escritura
        /// valida que se ingresen caracteres validos para nombre
        /// reutiliza metodo de validacion
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = ValidarNombreApellido(value); }
        }

        /// <summary>
        /// propiedad stringToDni de solo escritura
        /// valida el dni reutilizando metodo de validacion
        /// </summary>
        public string StringToDni
        {
            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);
            }
        }

        /// <summary>
        /// constructor publico 
        /// </summary>
        public Persona()
        {

        }

        /// <summary>
        /// contructor inicializa atributos de la clase 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        /// <summary>
        /// constructor invoca al constructor de la clase con tres parametros
        /// inicualiza el dni como int 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
             : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }

        /// <summary>
        /// invoca constructor con tres parametros inicializa dni como string con la propiedad
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
             : this(nombre, apellido, nacionalidad)
        {
            this.StringToDni = dni;

        }

        /// <summary>
        /// recibe un tipo enumerado de la clase y un dato tipo int, 
        /// valida el rango numerico segun el tipo de la nacionalidad
        /// en caso contrario se lanza la excepcion de nacionalidad invalida
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>

        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            int retorno = 0;
            if ((dato >= 0 && dato <= 89999999) && (nacionalidad == ENacionalidad.Argentino))
            {
                retorno = dato;

            }
            else if ((dato >= 90000000 && dato <= 99999999) && (nacionalidad == ENacionalidad.Extranjero))
            {
                retorno = dato;
            }
            else
            {
                throw new NacionalidadInvalidaException();
            }

            return retorno;
        }

        /// <summary>
        /// valida el dni ingresado por parametro como tipo string 
        /// reutiliza metodo anterior convirtiendo antes  el tipo de dato
        /// caso contrario lanza la excepcion de dni invalido
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int retorno = 0;
            int datoInt;
            if (int.TryParse(dato, out datoInt) && dato.Length <= 8)
            {
                retorno = ValidarDni(nacionalidad, datoInt);
            }
            else 
            { 
                throw new DniInvalidoException();
            }

            return retorno;
        }

        /// <summary>
        /// valida que el dato ingresado por parametros de entrada sean solo letras y no se ingresen espacios en blanco 
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>

        private string ValidarNombreApellido(string dato)
        {
            string auxiliar = "";
            foreach (char letra in dato)
            {
                if (char.IsLetter(letra) && !char.IsWhiteSpace(letra))
                {
                    auxiliar = dato;
                }
            }
            return auxiliar;
        }

        /// <summary>
        /// sobrecarga de ToString , muestra los datos de la clase
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE COMPLETO: {this.apellido}, {this.nombre}");
            sb.AppendFormat("\r\nNACIONALIDAD: {0} \r\n", this.nacionalidad.ToString());
            return sb.ToString();
        }


        /// <summary>
        /// Enumerado
        /// </summary>
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
    }
}
