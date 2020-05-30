using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    #pragma warning disable CS0660, CS0661, CS0659
    public abstract class Universitario : Persona
    {
        private int legajo;


        /// <summary>
        /// sobrecarga de Equals, retorna q el objeto ingresado por parametro sea el de la clase
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
          
            return obj is Universitario;
        }

        /// <summary>
        /// muestra los datos de la clase y los de la clase base 
        /// </summary>
        /// <returns></returns>

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ToString()}");
            sb.AppendFormat("Legajo : {0}\n", this.legajo);
            return sb.ToString();
        }

        /// <summary>
        /// operador == dos objetos son iguales si son del mismo tipo, si tienen mismo legajo y mismo dni
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            return (pg1.Equals(pg2) && (pg1.legajo == pg2.legajo || pg1.DNI == pg2.DNI));
        }

        /// <summary>
        /// reutiliza operador == y lo niega para obtener su distinto
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        /// <summary>
        /// metodo abstracto a sobrecargar en clases derivadas
        /// </summary>
        /// <returns></returns>

        protected abstract string ParticiparEnClase();


        /// <summary>
        /// constructor de clase invoca al de la clase base sin parametros
        /// </summary>
        public Universitario() : base()
        {

        }

        /// <summary>
        /// constructor inicializa atributo legajo
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }

    }
}
