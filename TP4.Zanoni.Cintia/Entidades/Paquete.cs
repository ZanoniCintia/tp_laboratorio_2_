using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Paquete:IMostrar<Paquete>
    {
        public enum EEstado { Ingresado, EnViaje, Entregado }
        public delegate void DelegadoEstado(object sender, EventArgs e);
        public event DelegadoEstado InformaEstado;
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        public string DireccionEntrega
        {
            get { return this.direccionEntrega; }

            set { this.direccionEntrega = value; }
        }
        public EEstado Estado
        {
            get { return this.estado; }

            set { this.estado = value; }

        }
        public string TrackingID
        {
            get { return this.trackingID; }

            set { this.trackingID = value; }
        }

        /// <summary>
        /// Cambia el estado del paquete y guarda los datos del mismo en una base de datos
        /// </summary>
        public void MockCicloDeVida()
        {
            this.estado = EEstado.Ingresado;
            do
            {
                Thread.Sleep(4000);
                this.estado++;
                this.InformaEstado(this, new EventArgs());
            } while (this.estado != EEstado.Entregado);
            try
            {
                PaqueteDAO.Insertar(this);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Muestra la información del paquete
        /// </summary>
        /// <returns>Información del paquete</returns>
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            Paquete p = (Paquete)elemento;
            return string.Format("{0} para {1}", p.trackingID, p.direccionEntrega);
        }
        /// <summary>
        /// Dos paquetes serán iguales siempre y cuando su Tracking ID sea el mismo
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Paquete p1, Paquete p2)
        {
            return (p1.trackingID == p2.trackingID);
        }

        /// <summary>
        /// Dos paquetes serán distintos siempre y cuando su Tracking ID sea distinto
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="direccionEntrega"></param>
        /// <param name="trackingID"></param>
        public Paquete(string direccionEntrega,string trackingID)
        {
            this.direccionEntrega = direccionEntrega;
            this.trackingID = trackingID;
        }

        /// <summary>
        /// Muestra la información del paquete
        /// </summary>
        /// <returns>Información del paquete</returns>
        public override string ToString()
        {
            return this.MostrarDatos(this);
        }
    }

}
