using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Campos
        private double numero;
        #endregion

        #region Propiedades

        /// <summary>
        /// Asigna valor al atributo numero, utiliza el metodo ValidarNumero
        /// </summary>
        public string SetNumero
        {

            set { numero = ValidarNumero(value); }
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Convierte un numero binario en decimal, devuelve un string
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            string resultado = "Valor invalido";
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {
                    return resultado;
                }
            }
            return Convert.ToInt32(binario, 2).ToString();
        }


        /// <summary>
        /// Convierte un numero decimal a binario,recibe un double devuelve un string
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {

            string resultado = "";
            numero = Math.Abs(numero);
            do
            {
                resultado = (numero % 2) + resultado;
                numero = (int)numero / 2;


            } while (numero > 0);

            return resultado;

        }


        /// <summary>
        /// convierte un numero decimal a binario, reutiliza codigo, recibe un string
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {

            return DecimalBinario(double.Parse(numero));
        }


        /// <summary>
        /// Constructor asigna 0 al atributo numero
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }


        /// <summary>
        /// ingresa un numero de tipo 'double' sin validar
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero):this(numero.ToString())
        {
            this.numero = numero;
        }


        /// <summary>
        ///ingresando un 'string' metodo set valida que sea  correcto
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            SetNumero=strNumero;
        }


        /// <summary>
        /// Operador +, suma dos numeros ingresados
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>

        public static double operator +(Numero n1, Numero n2)
        {
            return (n1.numero + n2.numero);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return (n1.numero - n2.numero);
        }

        /// <summary>
        /// Multiplica los dos numeros ingresados 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return (n1.numero * n2.numero);
        }

        /// <summary>
        /// Divide dos numeros,validando el q el numero divisor no sea 0
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>

        public static double operator /(Numero n1, Numero n2)
        {
            double retorno = double.MinValue;
           
            if (n2.numero != 0)
            {
                
                retorno = n1.numero / n2.numero;
            }
          
            return retorno;
        }


        /// <summary>
        /// valida que se ingrese un numero, caso contrario retorna 0
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno;
            if(!Double.TryParse(strNumero,out retorno))
            {
                retorno = 0;
            }
            return retorno;
        }

       

      
        #endregion

    }
}
