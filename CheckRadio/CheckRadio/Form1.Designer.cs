namespace CheckRadio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTexto = new System.Windows.Forms.Label();
            this.checkBold = new System.Windows.Forms.CheckBox();
            this.checkItalic = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(61, 33);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(175, 20);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Observa el texto cambiar";
            // 
            // checkBold
            // 
            this.checkBold.AutoSize = true;
            this.checkBold.Location = new System.Drawing.Point(35, 97);
            this.checkBold.Name = "checkBold";
            this.checkBold.Size = new System.Drawing.Size(62, 24);
            this.checkBold.TabIndex = 1;
            this.checkBold.Text = "Bold";
            this.checkBold.UseVisualStyleBackColor = true;
            this.checkBold.CheckedChanged += new System.EventHandler(this.checkBold_CheckedChanged);
            // 
            // checkItalic
            // 
            this.checkItalic.AutoSize = true;
            this.checkItalic.Location = new System.Drawing.Point(193, 97);
            this.checkItalic.Name = "checkItalic";
            this.checkItalic.Size = new System.Drawing.Size(63, 24);
            this.checkItalic.TabIndex = 2;
            this.checkItalic.Text = "Italic";
            this.checkItalic.UseVisualStyleBackColor = true;
            this.checkItalic.CheckedChanged += new System.EventHandler(this.checkItalic_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 153);
            this.Controls.Add(this.checkItalic);
            this.Controls.Add(this.checkBold);
            this.Controls.Add(this.lblTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTexto;
        private CheckBox checkBold;
        private CheckBox checkItalic;
    }
}