using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using EntidadesAbstractas;


namespace ClasesInstanciables
{
    #pragma warning disable CS0660, CS0661, CS0659
    public sealed class Profesor:Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;


        /// <summary>
        /// Reutiliza constructor de la clase padre Universitario.
        /// </summary>
        public Profesor()
            : base()
        {

        }

        /// <summary>
        /// Constructor estatico, instancia el Random.
        /// </summary>
        static Profesor()
        {
            Profesor.random = new Random();
        }

        /// <summary>
        /// Crea un objeto de tipo Profesor.
        /// </summary>
        /// <param name="id">ID del profesor</param>
        /// <param name="nombre">NOMBRE DEL PROFESOR</param>
        /// <param name="apellido">APELLIDO DEL PROFESOR</param>
        /// <param name="dni">DNI DEL PROFESOR</param>
        /// <param name="nacionalidad">NACIONALIDAD DEL PROFESOR</param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            _randomClases();
            _randomClases();
        }

        /// <summary>
        /// Le asigna a la lista clases del dia del profesor una clase a traves del Meotodo random.Next.
        /// </summary>
        void _randomClases()
        {
            int value;
            value = random.Next(0, 4);
            Thread.Sleep(300);
            Universidad.EClases aux = (Universidad.EClases)value;
            clasesDelDia.Enqueue(aux);
        }

        /// <summary>
        /// Compara un profesor con una clase.
        /// </summary>
        /// <param name="i">Profesor recibido</param>
        /// <param name="clase">Clase recibida</param>
        /// <returns>Retorna true si el profesor puede dar la clase.</returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            bool retorno = false;
            if (!(i is null))
            {
                foreach (Universidad.EClases materia in i.clasesDelDia)
                {
                    if (materia == clase)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        /// <summary>
        /// reutiliza operador == y lo niega para obtener su distinto
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }

        /// <summary>
        /// Invoca al metodo MostrarDatos de esta clase.
        /// </summary>
        /// <returns>Devuelve un string.</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        /// <summary>
        /// Implementacion del metodo ParticiparEnClase de la clase base
        /// </summary>
        /// <returns>Retorna las clases del dia que tiene un profesor.</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("CLASES DEL DIA: \r\n");
            foreach (Universidad.EClases materia in this.clasesDelDia)
            {
                cadena.AppendFormat("{0}\r\n", materia.ToString());
            }
            return cadena.ToString();
        }

        /// <summary>
        /// Sobreescritura del metodo MostrarDatos de la clase base, e invoca al metodo ParticiparEnClase de la clase base
        /// </summary>
        /// <returns>Retorna un string con todos los datos del profesor.</returns>
        protected override string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("{0}{1}\r\n", base.MostrarDatos(), this.ParticiparEnClase());
            return cadena.ToString();
        }



    }
}
