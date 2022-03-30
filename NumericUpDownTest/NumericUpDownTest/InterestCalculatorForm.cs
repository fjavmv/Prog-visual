
using System;
using System.Windows.Forms;

namespace NumericUpDownTest
{
   public partial class InterestCalculatorForm : Form
   {
      // constructor por defecto
      public InterestCalculatorForm()
      {
         InitializeComponent();
      }

      private void calculateButton_Click(object sender, EventArgs e)
      {
         // Retorna el valor de entrada del usuario
         decimal principal = decimal.Parse(principalTextBox.Text);
         double tasaInteres = double.Parse(interestTextBox.Text);
         int year = (int) yearUpDown.Value;

         // salida
         string salida = "Deposito\ttotal por año\r\n";

         // se calcula el monto  despues de cada año y se concatena con la salida
         for (int yearCounter = 1; yearCounter <= year; ++yearCounter)
         {
            decimal monto = principal *
              ((decimal)Math.Pow((1 + tasaInteres / 100), yearCounter));
            salida += $"{yearCounter}\t{monto:C}\r\n";
         }

         displayTextBox.Text = salida; // muestra el resultado
      }

        private void InterestCalculatorForm_Load(object sender, EventArgs e)
        {

        }
    }
}


