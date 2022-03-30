namespace ScrollBarEjemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScroll1_Scroll(object sender, ScrollEventArgs e)
        {
            lblprueba.ForeColor = Color.FromArgb(vScroll1.Value, vScroll2.Value, vScroll3.Value);
            lblr.Text = vScroll1.Value.ToString();
        }
        private void vScroll2_Scroll(object sender, ScrollEventArgs e)
        {
            lblprueba.ForeColor = Color.FromArgb(vScroll1.Value, vScroll2.Value, vScroll3.Value);
            lblg.Text = vScroll2.Value.ToString();
        }
        private void vScroll3_Scroll(object sender, ScrollEventArgs e)
        {
            lblprueba.ForeColor = Color.FromArgb(vScroll1.Value, vScroll2.Value, vScroll3.Value);
            lblb.Text = vScroll3.Value.ToString();



        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           
        }
    }
}