﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AlumnoRepetidoException : Exception
    {
        /// <summary>
        /// Usa al constructor de la clase base que recibe un mensaje.
        /// </summary>
        public AlumnoRepetidoException()
            : base("Alumno repetido")
        {

        }
    }
}
