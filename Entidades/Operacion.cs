using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operacion
    {
        //Atributos
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        //Constructor
        public Operacion(Numeracion primer, Numeracion segundo) 
        {
            // Inicializamos los valores de sus atributos
            this.primerOperando = primer;
            this.segundoOperando = segundo;
        }  

        //Getters y Setters
        public Numeracion PrimerOperando
        {
            get
            {
                return primerOperando;
            }
            set
            {
                primerOperando = value;
            }
        }

        public Numeracion SegundoOperando
        {
            get
            {
                return segundoOperando;
            }
            set
            {
                segundoOperando = value;
            }
        }

        // (Numeracion? = Es numeracion o null. Le agrega la posibilidad de que su valor sea null)

        /// <summary>
        /// Realiza una operación matemática en función del operador especificado.
        /// </summary>
        /// <param name="operador">El operador matemático a aplicar ('+', '-', '*', '/').</param>
        /// <returns>El resultado de la operación.</returns>
        public Numeracion Operar(char operador)
        {
            Numeracion resultado; 
            switch (operador)
            {
                case '-':
                    resultado = this.primerOperando - this.segundoOperando;
                    break;

                case '/':
                    resultado = this.primerOperando / this.segundoOperando;
                    break;

                case '*':
                    resultado = this.primerOperando * this.segundoOperando;
                    break;

                default:
                    resultado = this.primerOperando + this.segundoOperando;
                    break;
            }
            return resultado;
        } 
    }
}
