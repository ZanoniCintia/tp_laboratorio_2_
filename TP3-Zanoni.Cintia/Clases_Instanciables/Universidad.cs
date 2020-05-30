using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Excepciones;
using Archivos;

namespace ClasesInstanciables
{
    #pragma warning disable CS0660, CS0661, CS0659
    public class Universidad
    {
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

       
        /// <summary>
        /// propiedad de lectura y escritura de la lista de alumnos
        /// </summary>
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }
        /// <summary>
        /// propiedad de lectura y escritura de la lista de profesores
        /// </summary>
        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }
        /// <summary>
        ///  propiedad de lectura y escritura de la lista de jornada
        /// </summary>
        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }
        }
        
        /// <summary>
        /// Indexador retorna la jornada en el indice indicado.
        /// </summary>
        /// <param name="i">int indice</param>
        /// <returns></returns>
        public Jornada this[int i]
        {
            get
            {

                return jornada[i];

            }
            set
            {
                this.jornada[i] = value;
            }
        }
       

        /// <summary>
        /// Constructor que instancia la lista de alumnos, de jornada y de profesores.
        /// </summary>
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornada = new List<Jornada>();
            this.Instructores = new List<Profesor>();
        }


        /// <summary>
        /// una universidad y un alumno son iguales si el alumno pertenece a la universidad
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns>true si son iguales</returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool retorno = false;
            if (!(g is null) && !(a is null))
            {
                foreach (Alumno alumno in g.alumnos)
                {
                    if (alumno == a)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        /// <summary>
        /// reutiliza el == y lo niega para obtener su distinto
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns>true si son distintos</returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        /// una universidad y un profesor son iguales si el mismo da clases en ella
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns>true si son iguales</returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            bool retorno = false;
            if (!(g is null) && !(i is null))
            {
                foreach (Profesor prof in g.profesores)
                {
                    if (prof == i)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }
        

        /// <summary>
        /// reutiliza el == y lo niega para obtener su distinto
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns>true si son distintos</returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }


        /// <summary>
        /// Compara una universidad con una clase.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns>Retorna el primer profesor en la lista de profesores de esa universidad que pueda dar la clase,
        /// de lo contrario lanza la exception SinProfesorException</returns>
        public static Profesor operator ==(Universidad g, EClases clase)
        {
            Profesor retorno = null;
            foreach (Profesor auxProf in g.profesores)
            {
                if (auxProf == clase)
                {
                    retorno = auxProf;
                }
            }
            if (retorno is null)
            {
                throw new SinProfesorException();
            }
            return retorno;
        }



        /// <summary>
        /// Compara una universidad con una clase.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns>Retorna el primer profesor que no pueda dar la clase en la lista de profesores de la universidad.</returns>
        public static Profesor operator !=(Universidad g, EClases clase)
        {

            Profesor profesor = null;
            if (!(g is null))
            {
                foreach (Profesor profe in g.profesores)
                {
                    if (profe != clase)
                    {
                        profesor = profe;
                    }
                }
            }
            return profesor;
        }

        /// <summary>
        /// Agrega un alumno a la lista de alumnos de la universidad.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns>Retorna la universidad con el alumno agregado en caso de ser posible.</returns>
        public static Universidad operator +(Universidad u, Alumno a)
        {
            Universidad uni = null;
            if (!(u is null) && !(a is null))
            {
                if (u != a)
                {
                    u.alumnos.Add(a);
                    uni = u;
                }
                else
                {
                    throw new AlumnoRepetidoException();
                }
            }
            return uni;
        }
        /// <summary>
        /// Agrega una nueva jornada a la universidad con un nuevo profesor y añade los alumnos que toman esa clase.
        /// </summary>
        /// <param name="g">universidad recibida</param>
        /// <param name="clase">clase recibida</param>
        /// <returns>Retorna la universidad.</returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            if (!(g is null))
            {
                Profesor profe = (g == clase);
                Jornada jornada = new Jornada(clase, profe);

                foreach (Alumno alumno in g.alumnos)
                {
                    if (alumno == clase)
                    {
                        jornada.Alumnos.Add(alumno);
                    }
                }
                g.jornada.Add(jornada);

            }
            return g;
        }
        /// <summary>
        /// Agrega un profesor a la lista de profesores de la universidad.
        /// </summary>
        /// <param name="u">universidad recibida</param>
        /// <param name="i">profesor recibido</param>
        /// <returns>retorna la universidad.</returns>
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (!(u is null) && !(i is null))
            {
                if (u != i)
                {
                    u.profesores.Add(i);
                }
            }
            return u;
        }

        /// <summary>
        /// Invoca al metodo Guardar de la clase XML, serializa una universidad en un xml.
        /// </summary>
        /// <param name="uni">Universidad que recibe.</param>
        /// <returns>Retorna la universidad.</returns>
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            return xml.Guardar(AppDomain.CurrentDomain.BaseDirectory + "Universidad.Xml", uni);
        }


        /// <summary>
        /// Lee un archivo serializado xml.
        /// </summary>
        /// <returns>Retorna la universidad leida.</returns>
        public static Universidad Leer()
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            Universidad universidad = new Universidad();
            if (xml.Leer(AppDomain.CurrentDomain.BaseDirectory + "Universidad.Xml", out universidad))
            {
                return universidad;
            }
            return universidad;

        }


        /// <summary>
        /// Muestra todos los datos de la universidad.
        /// </summary>
        /// <param name="uni">Universidad recibida.</param>
        /// <returns>Retorna un string con todos los datos de la universidad.</returns>
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("JORNADA:");
            foreach (Jornada jornada in uni.Jornadas)
            {
                cadena.AppendFormat("{0}", jornada.ToString());
                cadena.AppendLine("<---------------------------------------------------->");
            }
            return cadena.ToString();
        }



        /// <summary>
        /// Sobrescritura del metodo ToString, invoca al metodo MostrarDatos.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }

        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }
    }
}
