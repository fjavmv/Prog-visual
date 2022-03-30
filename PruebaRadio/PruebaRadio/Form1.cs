namespace PruebaRadio
{
    public partial class Form1 : Form
    {
        private MessageBoxIcon icono;
        private MessageBoxButtons buttons;
        public Form1()
        {
            InitializeComponent();
        }

        public MessageBoxIcon Icono
        {
            get { return icono; }
            set { icono = value; }
        }
        public MessageBoxButtons Buttons 
        {
            get { return buttons; } 
            set { buttons = value; }
        }

        private void buttonType_CheckedChanged(object sender,EventArgs e)
        {
            if(sender == radioOk)
            {
               Buttons = MessageBoxButtons.OK;
            }
            else if (sender == radioCancelar)
            {
                Buttons = MessageBoxButtons.OKCancel;
            }
            else if(sender == radioAbortar)
            {
                buttons = MessageBoxButtons.AbortRetryIgnore;
            }
            else if (sender == radioNoCancelar)
            {
                buttons = MessageBoxButtons.YesNoCancel;
            }
            else if(sender == radioSiNo)
            {
                buttons = MessageBoxButtons.YesNo;
            }
            else if(sender == radioReintentar)
            {
                buttons = MessageBoxButtons.RetryCancel;
            }
        }

        private void iconType_CheckedChanged(object sender, EventArgs e)
        {
            if(sender == radioAsterisco)
            {
                Icono = MessageBoxIcon.Asterisk;
            }
            else if(sender == radioError)
            {
                Icono = MessageBoxIcon.Error;
            }
            else if( sender == radioExclamacion)
            {
                Icono = MessageBoxIcon.Exclamation;
            }
            else if(sender == radioMano)
            {
                Icono = MessageBoxIcon.Hand;
            }
            else if (sender == radioInformacion)
            {
                Icono = MessageBoxIcon.Information;
            }
            else if(sender == radioPregunta)
            {
                Icono = MessageBoxIcon.Question;
            }
            else if (sender == radioAlto)
            {
                Icono = MessageBoxIcon.Stop;
            }
            else
            {
                Icono=MessageBoxIcon.Warning;
            }
        }

        private void DisplayButton_Click(object sender,EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cuerpo de mensaje ", "Encabezado", buttons, icono);

            switch (result)
            {
                case DialogResult.OK:
                    lbl.Text = "Ok fue precionado.";
                    break;
                case DialogResult.Cancel:
                    lbl.Text = "Fue cancelado.";
                    break;
                case DialogResult.Abort:
                    lbl.Text = "Abortar procesado.";
                    break;
                case DialogResult.Retry:
                    lbl.Text = "Reintentar.";
                    break;
                case DialogResult.Ignore:
                    lbl.Text = "Ignorar.";
                    break;
                case DialogResult.Yes:
                    lbl.Text = "Sí.";
                   break;
                case DialogResult.No:
                    lbl.Text = "No.";
                    break;
            }
        }



        private void gpBotones_Enter(object sender, EventArgs e)
        {

        }
    }
}