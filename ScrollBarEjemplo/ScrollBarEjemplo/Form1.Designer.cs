namespace ScrollBarEjemplo
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
            this.vScroll1 = new System.Windows.Forms.VScrollBar();
            this.vScroll3 = new System.Windows.Forms.VScrollBar();
            this.vScroll2 = new System.Windows.Forms.VScrollBar();
            this.lblprueba = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.lblg = new System.Windows.Forms.Label();
            this.lblr = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.lbltam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vScroll1
            // 
            this.vScroll1.Location = new System.Drawing.Point(67, 267);
            this.vScroll1.Name = "vScroll1";
            this.vScroll1.Size = new System.Drawing.Size(26, 125);
            this.vScroll1.TabIndex = 0;
            this.vScroll1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScroll1_Scroll);
            // 
            // vScroll3
            // 
            this.vScroll3.Location = new System.Drawing.Point(339, 267);
            this.vScroll3.Name = "vScroll3";
            this.vScroll3.Size = new System.Drawing.Size(26, 125);
            this.vScroll3.TabIndex = 1;
            this.vScroll3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScroll3_Scroll);
            // 
            // vScroll2
            // 
            this.vScroll2.Location = new System.Drawing.Point(210, 267);
            this.vScroll2.Name = "vScroll2";
            this.vScroll2.Size = new System.Drawing.Size(26, 125);
            this.vScroll2.TabIndex = 2;
            this.vScroll2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScroll2_Scroll);
            // 
            // lblprueba
            // 
            this.lblprueba.AutoSize = true;
            this.lblprueba.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblprueba.Location = new System.Drawing.Point(35, 88);
            this.lblprueba.Name = "lblprueba";
            this.lblprueba.Size = new System.Drawing.Size(230, 46);
            this.lblprueba.TabIndex = 3;
            this.lblprueba.Text = "Texto prueba";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(322, 403);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(56, 20);
            this.lblb.TabIndex = 4;
            this.lblb.Text = "VALOR:";
            // 
            // lblg
            // 
            this.lblg.AutoSize = true;
            this.lblg.Location = new System.Drawing.Point(171, 394);
            this.lblg.Name = "lblg";
            this.lblg.Size = new System.Drawing.Size(96, 20);
            this.lblg.TabIndex = 5;
            this.lblg.Text = "Texto prueba";
            // 
            // lblr
            // 
            this.lblr.AutoSize = true;
            this.lblr.Location = new System.Drawing.Point(35, 394);
            this.lblr.Name = "lblr";
            this.lblr.Size = new System.Drawing.Size(96, 20);
            this.lblr.TabIndex = 6;
            this.lblr.Text = "Texto prueba";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(35, 197);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(100, 26);
            this.hScrollBar1.TabIndex = 7;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // lbltam
            // 
            this.lbltam.AutoSize = true;
            this.lbltam.Location = new System.Drawing.Point(171, 197);
            this.lbltam.Name = "lbltam";
            this.lbltam.Size = new System.Drawing.Size(96, 20);
            this.lbltam.TabIndex = 8;
            this.lbltam.Text = "Texto prueba";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.lbltam);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.lblr);
            this.Controls.Add(this.lblg);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lblprueba);
            this.Controls.Add(this.vScroll2);
            this.Controls.Add(this.vScroll3);
            this.Controls.Add(this.vScroll1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VScrollBar vScroll1;
        private VScrollBar vScroll3;
        private VScrollBar vScroll2;
        private Label lblprueba;
        private Label lblb;
        private Label lblg;
        private Label lblr;
        private HScrollBar hScrollBar1;
        private Label lbltam;
    }
}