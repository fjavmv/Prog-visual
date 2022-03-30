namespace PruebaRadio
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
            this.gpBotones = new System.Windows.Forms.GroupBox();
            this.gpIconos = new System.Windows.Forms.GroupBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.radioOk = new System.Windows.Forms.RadioButton();
            this.radioCancelar = new System.Windows.Forms.RadioButton();
            this.radioAbortar = new System.Windows.Forms.RadioButton();
            this.radioNoCancelar = new System.Windows.Forms.RadioButton();
            this.radioSiNo = new System.Windows.Forms.RadioButton();
            this.radioReintentar = new System.Windows.Forms.RadioButton();
            this.radioAsterisco = new System.Windows.Forms.RadioButton();
            this.radioError = new System.Windows.Forms.RadioButton();
            this.radioExclamacion = new System.Windows.Forms.RadioButton();
            this.radioMano = new System.Windows.Forms.RadioButton();
            this.radioInformacion = new System.Windows.Forms.RadioButton();
            this.radioPregunta = new System.Windows.Forms.RadioButton();
            this.radioAlto = new System.Windows.Forms.RadioButton();
            this.radioAdvertencia = new System.Windows.Forms.RadioButton();
            this.gpBotones.SuspendLayout();
            this.gpIconos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpBotones
            // 
            this.gpBotones.Controls.Add(this.radioReintentar);
            this.gpBotones.Controls.Add(this.radioSiNo);
            this.gpBotones.Controls.Add(this.radioNoCancelar);
            this.gpBotones.Controls.Add(this.radioAbortar);
            this.gpBotones.Controls.Add(this.radioCancelar);
            this.gpBotones.Controls.Add(this.radioOk);
            this.gpBotones.Location = new System.Drawing.Point(12, 12);
            this.gpBotones.Name = "gpBotones";
            this.gpBotones.Size = new System.Drawing.Size(195, 227);
            this.gpBotones.TabIndex = 0;
            this.gpBotones.TabStop = false;
            this.gpBotones.Text = "Botones";
            this.gpBotones.Enter += new System.EventHandler(this.gpBotones_Enter);
            // 
            // gpIconos
            // 
            this.gpIconos.Controls.Add(this.radioAdvertencia);
            this.gpIconos.Controls.Add(this.radioAlto);
            this.gpIconos.Controls.Add(this.radioPregunta);
            this.gpIconos.Controls.Add(this.radioInformacion);
            this.gpIconos.Controls.Add(this.radioMano);
            this.gpIconos.Controls.Add(this.radioExclamacion);
            this.gpIconos.Controls.Add(this.radioError);
            this.gpIconos.Controls.Add(this.radioAsterisco);
            this.gpIconos.Location = new System.Drawing.Point(213, 22);
            this.gpIconos.Name = "gpIconos";
            this.gpIconos.Size = new System.Drawing.Size(207, 299);
            this.gpIconos.TabIndex = 1;
            this.gpIconos.TabStop = false;
            this.gpIconos.Text = "Iconos";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(12, 268);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(195, 53);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // lbl
            // 
            this.lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl.Location = new System.Drawing.Point(12, 360);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(400, 40);
            this.lbl.TabIndex = 3;
            // 
            // radioOk
            // 
            this.radioOk.AutoSize = true;
            this.radioOk.Location = new System.Drawing.Point(25, 41);
            this.radioOk.Name = "radioOk";
            this.radioOk.Size = new System.Drawing.Size(48, 24);
            this.radioOk.TabIndex = 0;
            this.radioOk.TabStop = true;
            this.radioOk.Text = "Ok";
            this.radioOk.UseVisualStyleBackColor = true;
            this.radioOk.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
            // 
            // radioCancelar
            // 
            this.radioCancelar.AutoSize = true;
            this.radioCancelar.Location = new System.Drawing.Point(25, 71);
            this.radioCancelar.Name = "radioCancelar";
            this.radioCancelar.Size = new System.Drawing.Size(106, 24);
            this.radioCancelar.TabIndex = 1;
            this.radioCancelar.TabStop = true;
            this.radioCancelar.Text = "OKCancelar";
            this.radioCancelar.UseVisualStyleBackColor = true;
            this.radioCancelar.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
            // 
            // radioAbortar
            // 
            this.radioAbortar.AutoSize = true;
            this.radioAbortar.Location = new System.Drawing.Point(25, 101);
            this.radioAbortar.Name = "radioAbortar";
            this.radioAbortar.Size = new System.Drawing.Size(81, 24);
            this.radioAbortar.TabIndex = 2;
            this.radioAbortar.TabStop = true;
            this.radioAbortar.Text = "Abortar";
            this.radioAbortar.UseVisualStyleBackColor = true;
            this.radioAbortar.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
            // 
            // radioNoCancelar
            // 
            this.radioNoCancelar.AutoSize = true;
            this.radioNoCancelar.Location = new System.Drawing.Point(25, 131);
            this.radioNoCancelar.Name = "radioNoCancelar";
            this.radioNoCancelar.Size = new System.Drawing.Size(111, 24);
            this.radioNoCancelar.TabIndex = 3;
            this.radioNoCancelar.TabStop = true;
            this.radioNoCancelar.Text = "No Cancelar";
            this.radioNoCancelar.UseVisualStyleBackColor = true;
            this.radioNoCancelar.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
            // 
            // radioSiNo
            // 
            this.radioSiNo.AutoSize = true;
            this.radioSiNo.Location = new System.Drawing.Point(25, 161);
            this.radioSiNo.Name = "radioSiNo";
            this.radioSiNo.Size = new System.Drawing.Size(62, 24);
            this.radioSiNo.TabIndex = 4;
            this.radioSiNo.TabStop = true;
            this.radioSiNo.Text = "SíNo";
            this.radioSiNo.UseVisualStyleBackColor = true;
            this.radioSiNo.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
            // 
            // radioReintentar
            // 
            this.radioReintentar.AutoSize = true;
            this.radioReintentar.Location = new System.Drawing.Point(25, 191);
            this.radioReintentar.Name = "radioReintentar";
            this.radioReintentar.Size = new System.Drawing.Size(98, 24);
            this.radioReintentar.TabIndex = 5;
            this.radioReintentar.TabStop = true;
            this.radioReintentar.Text = "Reintentar";
            this.radioReintentar.UseVisualStyleBackColor = true;
            this.radioReintentar.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
            // 
            // radioAsterisco
            // 
            this.radioAsterisco.AutoSize = true;
            this.radioAsterisco.Location = new System.Drawing.Point(20, 42);
            this.radioAsterisco.Name = "radioAsterisco";
            this.radioAsterisco.Size = new System.Drawing.Size(90, 24);
            this.radioAsterisco.TabIndex = 6;
            this.radioAsterisco.TabStop = true;
            this.radioAsterisco.Text = "Asterisco";
            this.radioAsterisco.UseVisualStyleBackColor = true;
            this.radioAsterisco.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
            // 
            // radioError
            // 
            this.radioError.AutoSize = true;
            this.radioError.Location = new System.Drawing.Point(20, 72);
            this.radioError.Name = "radioError";
            this.radioError.Size = new System.Drawing.Size(62, 24);
            this.radioError.TabIndex = 7;
            this.radioError.TabStop = true;
            this.radioError.Text = "Error";
            this.radioError.UseVisualStyleBackColor = true;
            this.radioError.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
            // 
            // radioExclamacion
            // 
            this.radioExclamacion.AutoSize = true;
            this.radioExclamacion.Location = new System.Drawing.Point(20, 102);
            this.radioExclamacion.Name = "radioExclamacion";
            this.radioExclamacion.Size = new System.Drawing.Size(113, 24);
            this.radioExclamacion.TabIndex = 8;
            this.radioExclamacion.TabStop = true;
            this.radioExclamacion.Text = "Exclamación";
            this.radioExclamacion.UseVisualStyleBackColor = true;
            this.radioExclamacion.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
            // 
            // radioMano
            // 
            this.radioMano.AutoSize = true;
            this.radioMano.Location = new System.Drawing.Point(20, 132);
            this.radioMano.Name = "radioMano";
            this.radioMano.Size = new System.Drawing.Size(68, 24);
            this.radioMano.TabIndex = 9;
            this.radioMano.TabStop = true;
            this.radioMano.Text = "Mano";
            this.radioMano.UseVisualStyleBackColor = true;
            this.radioMano.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
            // 
            // radioInformacion
            // 
            this.radioInformacion.AutoSize = true;
            this.radioInformacion.Location = new System.Drawing.Point(20, 162);
            this.radioInformacion.Name = "radioInformacion";
            this.radioInformacion.Size = new System.Drawing.Size(110, 24);
            this.radioInformacion.TabIndex = 10;
            this.radioInformacion.TabStop = true;
            this.radioInformacion.Text = "Información";
            this.radioInformacion.UseVisualStyleBackColor = true;
            this.radioInformacion.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
            // 
            // radioPregunta
            // 
            this.radioPregunta.AutoSize = true;
            this.radioPregunta.Location = new System.Drawing.Point(20, 192);
            this.radioPregunta.Name = "radioPregunta";
            this.radioPregunta.Size = new System.Drawing.Size(89, 24);
            this.radioPregunta.TabIndex = 11;
            this.radioPregunta.TabStop = true;
            this.radioPregunta.Text = "Pregunta";
            this.radioPregunta.UseVisualStyleBackColor = true;
            this.radioPregunta.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
            // 
            // radioAlto
            // 
            this.radioAlto.AutoSize = true;
            this.radioAlto.Location = new System.Drawing.Point(20, 222);
            this.radioAlto.Name = "radioAlto";
            this.radioAlto.Size = new System.Drawing.Size(58, 24);
            this.radioAlto.TabIndex = 12;
            this.radioAlto.TabStop = true;
            this.radioAlto.Text = "Alto";
            this.radioAlto.UseVisualStyleBackColor = true;
            this.radioAlto.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
            // 
            // radioAdvertencia
            // 
            this.radioAdvertencia.AutoSize = true;
            this.radioAdvertencia.Location = new System.Drawing.Point(20, 252);
            this.radioAdvertencia.Name = "radioAdvertencia";
            this.radioAdvertencia.Size = new System.Drawing.Size(109, 24);
            this.radioAdvertencia.TabIndex = 13;
            this.radioAdvertencia.TabStop = true;
            this.radioAdvertencia.Text = "Advertencia";
            this.radioAdvertencia.UseVisualStyleBackColor = true;
            this.radioAdvertencia.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 453);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.gpIconos);
            this.Controls.Add(this.gpBotones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpBotones.ResumeLayout(false);
            this.gpBotones.PerformLayout();
            this.gpIconos.ResumeLayout(false);
            this.gpIconos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gpBotones;
        private RadioButton radioReintentar;
        private RadioButton radioSiNo;
        private RadioButton radioNoCancelar;
        private RadioButton radioAbortar;
        private RadioButton radioCancelar;
        private RadioButton radioOk;
        private GroupBox gpIconos;
        private RadioButton radioAdvertencia;
        private RadioButton radioAlto;
        private RadioButton radioPregunta;
        private RadioButton radioInformacion;
        private RadioButton radioMano;
        private RadioButton radioExclamacion;
        private RadioButton radioError;
        private RadioButton radioAsterisco;
        private Button btnMostrar;
        private Label lbl;
    }
}