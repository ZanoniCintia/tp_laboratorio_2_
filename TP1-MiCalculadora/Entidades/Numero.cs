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

      
        public string SetNumero
        {

            set { numero = ValidarNumero(value); }
        }

        #endregion

        #region Metodos
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

        public string DecimalBinario(string numero)
        {

            return DecimalBinario(double.Parse(numero));
        }
        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double numero)
        {
            this.numero = numero;
        }
        public Numero(string strNumero)
        {
            Double.TryParse(strNumero,out numero);
        }


        public static double operator +(Numero n1, Numero n2)
        {
            return (n1.numero + n2.numero);
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return (n1.numero - n2.numero);
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return (n1.numero * n2.numero);
        }

        public static double operator /(Numero n1, Numero n2)
        {
            double retorno = 0;
           
            if (n2.numero != 0)
            {
                
                retorno = n1.numero / n2.numero;
            }
          
            return retorno;
        }



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
