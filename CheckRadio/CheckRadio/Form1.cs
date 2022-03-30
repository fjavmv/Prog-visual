namespace CheckRadio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBold_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBold.Checked)
            {
                checkItalic.Checked = false;
                lblTexto.Font = new Font(lblTexto.Font, FontStyle.Bold);
            }
        }
            

        private void checkItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (checkItalic.Checked)
            {
                checkBold.Checked = false;
                lblTexto.Font = new Font(lblTexto.Font, FontStyle.Italic);

            }
        }
    }
}