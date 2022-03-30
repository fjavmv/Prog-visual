using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoForm
{
  
    public partial class Form2 : Form
    {
        public String msj;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender,EventArgs e)
        {
            label1.Text = msj;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
