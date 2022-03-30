namespace Calculadora
{
    public partial class Form1 : Form
    {
       private double valorUno;
       private double valorDos;
       private char operador;

        public Form1()
        {
            InitializeComponent();
        }

        //Método que permite obtener el valor que se tiene en cada botón de número
        private void obtenerNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (txtMostrar.Text == "0")
            {

                txtMostrar.Text = ""; //Pone el campo vacío  en caso que en la pantalla inicial haya un cero

            }
            txtMostrar.Text += boton.Text; // Posteriormente se asigna en valor al textbox

        }

        //permite detectar el la operación seleccionada
        private void obtenerOperacion(object sender, EventArgs e)
        {
            var botonOperador = ((Button)sender);
            //almaceno elvalor actual
            valorUno = Convert.ToDouble(txtMostrar.Text);
            //almaceno el valor del botón
            operador = Convert.ToChar(botonOperador.Text);
            txtMostrar.Text = "0";
        }

        //botón punto decimal
        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtMostrar.Text.Contains("."))
            {
                txtMostrar.Text += ".";
            }
        }

        //realiza la operaciones segun sea la opción
        private void btnIgual_Click(object sender, EventArgs e)
        {
            valorDos = Convert.ToDouble(txtMostrar.Text);

            switch (operador)
            {
                case '+':
                    txtMostrar.Text = (valorUno + valorDos).ToString();
                    label1.Text = (valorUno + valorDos).ToString();
                    //en caso de seguir sumando aplica con lo demas
                    valorUno = Convert.ToDouble(txtMostrar.Text);
                    break;
                case '-':
                    txtMostrar.Text = (valorUno - valorDos).ToString();
                    valorUno = Convert.ToDouble(txtMostrar.Text);
                    break;
                case '*':
                    txtMostrar.Text = (valorUno * valorDos).ToString();
                    valorUno = Convert.ToDouble(txtMostrar.Text);
                    break;
                case '/':
                    if (txtMostrar.Text != "0")
                    {
                        txtMostrar.Text = (valorUno / valorDos).ToString();
                        valorUno = Convert.ToDouble(txtMostrar.Text);
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por cero!!");
                    }
                    break;
                default:
                    if (operador != '+')
                    {
                        txtMostrar.Text = "Opción invalida";
                    }else if (operador != '-')
                    {
                        txtMostrar.Text = "Opción invalida";

                    }
                    else
                    {

                    }
                    break;
            }
        }

       
        private void btnEliminarNumero_Click(object sender, EventArgs e)
        {
            //Eliminamos valores 
            if (txtMostrar.Text.Length > 1)
            {
                txtMostrar.Text = txtMostrar.Text.Substring(0, txtMostrar.Text.Length - 1);
            }
            else
            {
                txtMostrar.Text = "0";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiamos los valores almancenados
            valorUno = 0;
            valorDos = 0;
            operador = '\0'; //
            txtMostrar.Text = "0";
        }


    }
}