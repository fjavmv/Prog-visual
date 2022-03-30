namespace Calculadora
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
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSus = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnElimiarNumero = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(37, 12);
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(354, 27);
            this.txtMostrar.TabIndex = 0;
            this.txtMostrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(37, 130);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(68, 29);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.obtenerNumero);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(37, 176);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(68, 29);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.obtenerNumero);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(37, 93);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(68, 29);
            this.btn7.TabIndex = 10;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.obtenerNumero);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(134, 93);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(68, 29);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.obtenerNumero);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(134, 176);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(68, 29);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.obtenerNumero);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(134, 130);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(68, 29);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.obtenerNumero);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(323, 47);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(68, 29);
            this.btnSum.TabIndex = 22;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.obtenerOperacion);
            // 
            // btnSus
            // 
            this.btnSus.Location = new System.Drawing.Point(323, 93);
            this.btnSus.Name = "btnSus";
            this.btnSus.Size = new System.Drawing.Size(68, 29);
            this.btnSus.TabIndex = 21;
            this.btnSus.Text = "-";
            this.btnSus.UseVisualStyleBackColor = true;
            this.btnSus.Click += new System.EventHandler(this.obtenerOperacion);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(323, 176);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(68, 29);
            this.btnDiv.TabIndex = 20;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.obtenerOperacion);
            // 
            // btnProd
            // 
            this.btnProd.Location = new System.Drawing.Point(323, 130);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(68, 29);
            this.btnProd.TabIndex = 19;
            this.btnProd.Text = "*";
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.obtenerOperacion);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(230, 93);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(68, 29);
            this.btn9.TabIndex = 18;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.obtenerNumero);
            // 
            // btnElimiarNumero
            // 
            this.btnElimiarNumero.Location = new System.Drawing.Point(230, 47);
            this.btnElimiarNumero.Name = "btnElimiarNumero";
            this.btnElimiarNumero.Size = new System.Drawing.Size(68, 29);
            this.btnElimiarNumero.TabIndex = 17;
            this.btnElimiarNumero.Text = "<--";
            this.btnElimiarNumero.UseVisualStyleBackColor = true;
            this.btnElimiarNumero.Click += new System.EventHandler(this.btnEliminarNumero_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(230, 176);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(68, 29);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.obtenerNumero);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(230, 130);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(68, 29);
            this.btn6.TabIndex = 15;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.obtenerNumero);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(230, 225);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(161, 29);
            this.btnIgual.TabIndex = 23;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(134, 225);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(68, 29);
            this.button18.TabIndex = 24;
            this.button18.Text = "0";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.obtenerNumero);
            // 
            // btnPunto
            // 
            this.btnPunto.Location = new System.Drawing.Point(37, 225);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(68, 29);
            this.btnPunto.TabIndex = 25;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(37, 47);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(165, 29);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.Text = "C";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 340);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnSus);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnProd);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnElimiarNumero);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.txtMostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtMostrar;
        private Button btn4;
        private Button btn1;
        private Button btn7;
        private Button btn8;
        private Button btn2;
        private Button btn5;
        private Button btnSum;
        private Button btnSus;
        private Button btnDiv;
        private Button btnProd;
        private Button btn9;
        private Button btnElimiarNumero;
        private Button btn3;
        private Button btn6;
        private Button btnIgual;
        private Button button18;
        private Button btnPunto;
        private Button btnLimpiar;
        private Label label1;
    }
}