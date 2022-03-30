namespace SegundoForm
{
    public partial class Form1 : Form
    {
        private double valor_uno;
        private double valor_dos;
        private double resultado;
        public String mensaje;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   valor_uno = Convert.ToInt32(textBox1.Text); // convertimos el texto tomado del textbox a entero
            valor_dos = Convert.ToInt32(textBox2.Text); // convertimos el texto tomado del textbox a entero
            resultado = valor_uno + valor_dos; // realizamos la suma de valor uno y valor dos
            Form2 form2 = new Form2(); // creaamos una instancia del formulario dos
            form2.msj = Convert.ToString(resultado); // mostramos el resultado de la suma en el label del formulario dos
            form2.Show();

        }
    }
}