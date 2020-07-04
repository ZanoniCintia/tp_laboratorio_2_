using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Correo:IMostrar<List<Paquete>>
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        /// <summary>
        /// Propiedad de lectura y escritura de la lista de paquetes
        /// </summary>
        public List<Paquete> Paquetes
        {
            get { return this.paquetes; }
            set { this.paquetes = value; }
        }

        /// <summary>
        /// constructor publico sin parametros
        /// </summary>
        public Correo()
        {
            mockPaquetes = new List<Thread>();
            paquetes = new List<Paquete>();
        }

        /// <summary>
        /// Cierra todos los hilos activos
        /// </summary>
        public void FinEntrega()
        {
            foreach (Thread hilo in mockPaquetes)
            {
                if (hilo != null && hilo.IsAlive)
                    hilo.Abort();
            }
        }

        /// <summary>
        /// Muestra los datos de la lista de paquetes
        /// </summary>
        /// <param name="elementos"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            string datos = "";
            foreach (Paquete p in ((Correo)elementos).Paquetes)
            {
                datos += string.Format("{0} para {1} ({2})\n", p.TrackingID, p.DireccionEntrega, p.Estado.ToString());
            
            }
            return datos;
        }

        /// <summary>
        /// Agrega un paquete a la lista de paquetes del correo controlando que no exista previamente
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Correo operator +(Correo c, Paquete p)
        {
            foreach (Paquete paquete in c.paquetes)
            {
                if (paquete == p)
                    throw new TrackingIdRepetidoException("El Tracking ID " + p.TrackingID + " ya figura en la lista de envíos");
            }
            c.paquetes.Add(p);
            Thread hilo = new Thread(p.MockCicloDeVida);
            c.mockPaquetes.Add(hilo);
            try
            {
                hilo.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return c;
        }

    }
}
