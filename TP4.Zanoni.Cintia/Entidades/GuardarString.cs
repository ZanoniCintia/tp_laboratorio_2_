using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class GuardarString
    {
        /// <summary>
        /// Guardará en un archivo de texto en el escritorio de la máquina 
        /// </summary>
        /// <param name="texto">Objeto que se guardara</param>
        /// <param name="archivo">Nombre del archivo</param>
        /// <returns></returns>
        public static bool Guardar(this string texto,string archivo)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta + "\\" + archivo, true))
                {
                    sw.WriteLine(texto);
                }
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
