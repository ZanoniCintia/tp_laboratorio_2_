using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Archivos;

namespace ClasesInstanciables
{
    #pragma warning disable CS0660, CS0661, CS0659
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;

        /// <summary>
        /// propiedad lectura y escritura de la lista 
        /// </summary>
        public List<Alumno> Alumnos
        {
            get { return alumnos; }
            set { this.alumnos = value; }
        }

        /// <summary>
        /// propiedad lectura y escritura de la clase q toma
        /// </summary>
        public Universidad.EClases Clase
        {
            get { return clase; }
            set { clase = value; }
        }

        /// <summary>
        /// propiedad lectura y escritura de atributo tipo profesor
        /// </summary>
        public Profesor Instructor
        {
            get { return instructor; }
            set { this.instructor = value; }
        }

        /// <summary>
        /// constructor instancia la lista 
        /// </summary>
        private Jornada()
        {
            alumnos = new List<Alumno>();
        }

        /// <summary>
        /// constructor que invoca al de instacia e inicializa los atributos de la clase
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="instructor"></param>
        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }

        /// <summary>
        /// metodo estatico para leer un archivo y retornarlo como texto
        /// utiliza una metodo leer de la clas texto
        /// </summary>
        /// <returns>string del archivo de texto</returns>
        public static string Leer()
        {
            
            string auxiliar = "";
            IArchivo<string> archivosTexto = new Texto();
            if (archivosTexto.Leer(AppDomain.CurrentDomain.BaseDirectory + "Jornada.Txt", out auxiliar))
            {
                return auxiliar;
            }
            return auxiliar;
            
        }
        /// <summary>
        /// Invoca al metodo Guardar de la clase Texto. 
        /// </summary>
        /// <param name="jornada">Jornada a guardar.</param>
        /// <returns>Retorna true si logro guardarse la jornada, false si no.</returns>
        public static bool Guardar(Jornada jornada)
        {
            bool retorno = false;
            IArchivo<string> archivosTexto = new Texto();
            if (archivosTexto.Guardar(AppDomain.CurrentDomain.BaseDirectory + "Jornada.Txt", jornada.ToString()))
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// sobrecarga Tostring 
        /// </summary>
        /// <returns>retorna los datos de la lista de alumnos </returns>
        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("CLASE DE: {0} POR {1}ALUMNOS: \r\n", this.clase.ToString(), this.instructor.ToString());
            foreach (Alumno alumno in this.alumnos)
            {
                cadena.AppendFormat("{0}\r\n", alumno.ToString());
            }
            return cadena.ToString();
        }

        /// <summary>
        /// Compara una jornada con un alumno, devuelve true si ese alumno toma la clase de esa jornada.
        /// </summary>
        /// <param name="j">Jornada a comparar</param>
        /// <param name="a">alumno a comparar</param>
        /// <returns>true si son distintos</returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            return !(a != j.clase);
        }
        /// <summary>
        ///Compara una jornada con un alumno
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns>retorna true si ese alumno NO toma la clase de esa jornada.</returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }
        /// <summary>
        /// Retorna una jornada con el alumno agregado a la lista de alumnos de una jornada.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns>jornada </returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (!(j is null) && !(a is null))
            {
                if (j != a)
                {
                    j.Alumnos.Add(a);
                }
            }
            return j;
        }


    }
}
