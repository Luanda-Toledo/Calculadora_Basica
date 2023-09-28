using Entidades;
using Microsoft.VisualBasic.Logging;

namespace Calculadora_Basica
{
    // Eventos de los componentes, y especificaciones de lo que ocurre en cada evento 
    public partial class FrmCalculadora : Form // Hereda de form
    {
        // Atributos
        private string primerNumero;
        private string operadorSeleccionado;
        private string segundoNumero;
        private ESistema sistemaSeleccionado;
        private Numeracion? resultadoOperacion;
        private bool actualizoSistema;

        public FrmCalculadora()
        {
            InitializeComponent();
            this.primerNumero = string.Empty;
            this.operadorSeleccionado = "+";
            this.segundoNumero = string.Empty;
            this.sistemaSeleccionado = ESistema.Decimal;
            this.actualizoSistema = false;
        }
        //Los atributos de tipo numeración, almacenaran un objeto en sistema decimal.
        //Cada será una instancia correspondiente a los valores obtenidos desde las cajas de texto.

        private void primerOperador_TextChanged(object sender, EventArgs e)
        {
            primerNumero = primerOperador.Text;
        }

        private void operacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (operacion.SelectedIndex == -1)
            {
                operadorSeleccionado = "+";
            }
            else
            {
                operadorSeleccionado = operacion.SelectedItem.ToString();
            }
        }

        private void segundoOperador_TextChanged(object sender, EventArgs e)
        {
            segundoNumero = segundoOperador.Text;
        }

        private void binario_sist_CheckedChanged(object sender, EventArgs e)
        {
            sistemaSeleccionado = ESistema.Binario;
            setResultado();
        }

        private void decimal_sist_CheckedChanged(object sender, EventArgs e)
        {
            sistemaSeleccionado = ESistema.Decimal;
            setResultado();
        }

        private void operar_Click(object sender, EventArgs e)
        {
            actualizoSistema = true;
            setResultado();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            primerOperador.Text = "";
            segundoOperador.Text = "";
            resultado.Text = "Resultado: ";
            decimal_sist.Checked = true;
            operacion.SelectedIndex = -1;
            resultadoOperacion = null;
            actualizoSistema = false;
        }

        private void setResultado()
        {
            if (actualizoSistema)
            {
                // Crear objetos Numeracion a partir de los valores ingresados en los cuadros de texto
                Numeracion num1 = new Numeracion(primerNumero, ESistema.Decimal);
                Numeracion num2 = new Numeracion(segundoNumero, ESistema.Decimal);

                char operador = operadorSeleccionado[0];

                Operacion calculadora = new Operacion(num1, num2);

                resultadoOperacion = calculadora.Operar(operador);

                resultado.Text = "El resultado es: " + resultadoOperacion.ConvertirA(sistemaSeleccionado);
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cerrar la calculadora?", "Confirmar Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario elige "No", cancelar el cierre del formulario
            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}