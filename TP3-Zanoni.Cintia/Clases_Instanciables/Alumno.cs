using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;


namespace ClasesInstanciables
{
    #pragma warning disable CS0660, CS0661, CS0659
    public sealed class Alumno : Universitario
    {
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;


        /// <summary>
        /// constructor publico sin parametros
        /// </summary>
        public Alumno()
        {

        }

        /// <summary>
        /// constructor invoca al de la clase base , inicializa atributo de la clase que toma
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad,
                     Universidad.EClases claseQueToma) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        /// <summary>
        /// constructor invoca al de la clase con parametros, inicializa atributo estado de cuenta
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        /// <param name="estadoCuenta"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad,
                      Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        /// <summary>
        /// sobreescribe metodo mostrar datos , con los datos de la clase y de la clase base
        /// </summary>
        /// <returns> el stringBuilder</returns>

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.ToString());
            sb.AppendFormat("Clases que toma :{0}\n", this.claseQueToma);
            sb.AppendFormat("Estado de cuenta : {0}\n",this.estadoCuenta);
            return sb.ToString();
        }

        /// <summary>
        /// sobrecarga de ToString 
        /// </summary>
        /// <returns>retorna el metodo mostrar datos</returns>

        public override string ToString()
        {
            return MostrarDatos();
        }

        /// <summary>
        /// un alumno sera igual a una clae si toma la clase y si no es deudor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns>true si son iguales</returns>

        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            bool retorno = false;
            if ((a.claseQueToma == clase) || (a.estadoCuenta == EEstadoCuenta.Deudor))
            {
                retorno = true;
            }
            return retorno;

        }


        /// <summary>
        /// reutiliza el == y lo niega para obtener su distinto
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns>true si son distintos</returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase) 
        {
            return !(a == clase);
        }

        /// <summary>
        /// sobreescribe metodo, muestra la clase q toma
        /// </summary>
        /// <returns>stringBuilder</returns>

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("TOMA CLASE DE :", claseQueToma);
            return sb.ToString();
        }


        /// <summary>
        /// enumerado
        /// </summary>
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
    }
}
