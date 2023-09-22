using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Operacion
    {
        //Atrubutos
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        //Constructor
        public Operacion() 
        {
            // Inicializamos los valores de sus atributos
            primerOperando = new Numeracion();
            segundoOperando = new Numeracion();
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
    }
}
