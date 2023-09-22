using System;
using System.Drawing;

namespace Entidades
{
    public enum ESistema {Decimal, Binario}; 

    public class Numeracion
    {
        
        private ESistema sistema;
        private double valorNumerico;

        //Constructores
        public Numeracion (ESistema sistema, double valor):this(valor.ToString(), sistema)
        {          
        }

        public Numeracion(string valor, ESistema sistema)
        {
            InicializarValores(valor, sistema); 
        }

        // Getters y setters
        public ESistema Sistema
        {
            get
            {
                return sistema;
            }
        }
        public string ValorNumerico
        {
            get
            {
                if (ESistema.Decimal == this.sistema)
                {
                    return valorNumerico.ToString();
                }
                return DecimalABinario((int)valorNumerico);       
            } 
        }

        /// <summary>
        /// Inicializa los valores de un objeto, asignando un valor numérico y un sistema.
        /// </summary>
        /// <param name="valor">El valor que se va a asignar, que puede ser binario o decimal.</param>
        /// <param name="sistema">El sistema en el que se encuentra el valor (ESistema.Binario o ESistema.Decimal).</param>
        private void InicializarValores(string valor, ESistema sistema)
        {
            // Valor predeterminado en caso de que no se cumplan las condiciones
            double resultado = double.MinValue;

            // Si el sistema es binario intenta convertir el valor a decimal
            if (sistema == ESistema.Binario && EsBinario(valor))
            {
                resultado = BinarioADecimal(valor);
            }
            // Si no es binario intenta convertir el valor a decimal
            else if (double.TryParse(valor, out double numeroDecimal))
            {
                resultado = numeroDecimal;   
            }

            this.valorNumerico = resultado;
            this.sistema = sistema;
        }

        /// <summary>
        /// Verifica si una cadena de caracteres es un número binario válido.
        /// </summary>
        /// <param name="valor">La cadena que se va a verificar.</param>
        /// <returns>
        ///   <c>true</c> si la cadena es un número binario válido; de lo contrario, <c>false</c>.
        /// </returns>
        private bool EsBinario(string valor)
        {
            foreach (char c in valor)
            {
                // Si encuentra un caracter que no es 0 ni 1, entonces no es binario
                if (c != '0' && c !='1')
                {
                    return false;
                }
            }
            // Si todos los caracteres son 0 y 1, entonces es binario.
            return true;
        }

        /// <summary>
        /// Convierte una cadena binaria en su equivalente decimal.
        /// </summary>
        /// <param name="valorBinario">La cadena binaria que se va a convertir en decimal.</param>
        /// <returns>El valor decimal equivalente a la cadena binaria.</returns>
        private double BinarioADecimal(string valorBinario)
        {
            double valorDecimal = 0; // Inicializar el valor decimal resultante en 0

            // Iterar a través de la cadena binaria desde el bit menos significativo al más significativo
            for (int i = valorBinario.Length - 1, j = 0; i >= 0; i--, j++)
            {
                // Si el bit es '1', agregar el valor correspondiente a valorDecimal
                if (valorBinario[i] == '1')
                {
                    valorDecimal += Math.Pow(2, j);
                }
            }

            return valorDecimal;
        }

        /// <summary>
        /// Convierte un valor decimal positivo entero en su representación binaria.
        /// </summary>
        /// <param name="valorDecimal">El valor decimal positivo entero que se va a convertir en binario.</param>
        /// <returns>La representación binaria del valor decimal como una cadena, o "Número inválido" si no es un entero positivo.</returns>
        private string DecimalABinario(string valorDecimal)
        {
            if (double.TryParse(valorDecimal, out double numeroDecimal))
            {
                // Verificar si el número es positivo y un entero
                if (numeroDecimal >= 0 && (int)numeroDecimal == numeroDecimal)
                {
                    // Tomar el valor entero
                    int numeroEntero = (int)numeroDecimal;

                    // Convertir a binario manualmente
                    string binario = string.Empty;
                    while (numeroEntero > 0)
                    {
                        binario = (numeroEntero % 2) + binario;
                        numeroEntero /= 2;
                    }

                    return binario;
                }
                else
                {
                    // Si no es un entero positivo, retornar "Número inválido"
                    return "Número inválido";
                }
            }
            else
            {
                // Si no se pudo convertir a decimal, retornar "Número inválido"
                return "Número inválido";
            }
        }

        /// <summary>
        /// Convierte un valor decimal entero en su representación binaria.
        /// </summary>
        /// <param name="valorDecimal">El valor decimal entero que se va a convertir en binario.</param>
        /// <returns>La representación binaria del valor decimal como una cadena, o "Número inválido" si no es un entero positivo.</returns>
        private string DecimalABinario(int valorDecimal)
        {
            string cadenaNumerica = valorDecimal.ToString();
            return DecimalABinario(cadenaNumerica);
        }

        /// <summary>
        /// Convierte el valor numérico de esta instancia en una cadena representada en el sistema de numeración especificado.
        /// </summary>
        /// <param name="sistema">El sistema de numeración al que se va a convertir la cadena (ESistema.Binario o ESistema.Decimal).</param>
        /// <returns>Una cadena que representa el valor numérico en el sistema de numeración especificado.</returns>
        public string ConvertirA(ESistema sistema)
        {
            string resultado = string.Empty; // Cadena vacia

            if (sistema == ESistema.Binario)
            {
                // Convertir el valor numérico a binario
                resultado = DecimalABinario(this.ValorNumerico);
            }
            else if (sistema == ESistema.Decimal)
            {
                // Convertir el valor numérico decimal a string
                resultado = this.ValorNumerico.ToString();
            }
            return resultado;
        }

        //Un Sistema y una Numeración serán iguales, si el sistema es igual a sistema de la numeración
        public static bool operator == (ESistema sistema, Numeracion num)
        {
            return sistema == num.Sistema;
        }

        public static bool operator != (ESistema sistema, Numeracion num)
        {
            return !(sistema == num);
        }

        // Dos numeraciones serán iguales si pertenecen al mismo sistema.
        public static bool operator ==(Numeracion primeraNumeracion, Numeracion segundaNumeracion)
        {
            return primeraNumeracion.Sistema == segundaNumeracion.Sistema;
        }

        public static bool operator !=(Numeracion primeraNumeracion, Numeracion segundaNumeracion)
        {
            return !(primeraNumeracion == segundaNumeracion);
        }

        // Los operadores realizarán las operaciones correspondientes entre dos números. + - * / 
        public static Numeracion operator +(Numeracion primerNumero, Numeracion segundoNumero)
        {
            double resultado = double.MinValue;
            if (primerNumero == segundoNumero)
            {
                resultado = primerNumero.valorNumerico + segundoNumero.valorNumerico;
                return new Numeracion(primerNumero.Sistema, resultado);
            }
            else
            {
                return new Numeracion(primerNumero.Sistema, resultado);
            }
        }

        public static Numeracion operator -(Numeracion primerNumero, Numeracion segundoNumero)
        {
            double resultado = double.MinValue;
            // Que tengan mismo sistema
            // Que no den resultados negativos en los casos de las restas de num binarios
            if (primerNumero == segundoNumero && (segundoNumero.valorNumerico < primerNumero.valorNumerico && primerNumero.sistema != ESistema.Binario))
            {                  
                resultado = primerNumero.valorNumerico - segundoNumero.valorNumerico;
                return new Numeracion(primerNumero.Sistema, resultado);
            }
            else
            {
                return new Numeracion(primerNumero.Sistema, resultado);
            }
        }

        public static Numeracion operator *(Numeracion primerNumero, Numeracion segundoNumero)
        {
            double resultado = double.MinValue;
            if (primerNumero == segundoNumero)
            {
                resultado = primerNumero.valorNumerico * segundoNumero.valorNumerico;
                return new Numeracion(primerNumero.Sistema, resultado);
            }
            else
            {
                return new Numeracion(primerNumero.Sistema, resultado);
            }
        }

        public static Numeracion operator /(Numeracion primerNumero, Numeracion segundoNumero)
        {
            double resultado = double.MinValue;
            if (primerNumero == segundoNumero && segundoNumero.valorNumerico != 0) // Sistemas y division por cero
            {
                resultado = primerNumero.valorNumerico / segundoNumero.valorNumerico;
                return new Numeracion(primerNumero.Sistema, resultado);
            }
            else
            {
                return new Numeracion(primerNumero.Sistema, resultado);
            }
        }




    }
}