namespace appControl2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btLogin = new System.Windows.Forms.Button();
            this.ctPass = new System.Windows.Forms.TextBox();
            this.ctUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ctFahrenheit2 = new System.Windows.Forms.TextBox();
            this.ctCelsius2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btCaF = new System.Windows.Forms.Button();
            this.btFaC = new System.Windows.Forms.Button();
            this.ctCelsius1 = new System.Windows.Forms.TextBox();
            this.ctFahrenheit1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lClicks = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.click_panel = new System.Windows.Forms.Panel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lClasificacion = new System.Windows.Forms.Label();
            this.IMC = new System.Windows.Forms.Label();
            this.BtCalcular = new System.Windows.Forms.Button();
            this.ctAltura = new System.Windows.Forms.TextBox();
            this.ctPeso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 690);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Snow;
            this.tabPage1.Controls.Add(this.btLogin);
            this.tabPage1.Controls.Add(this.ctPass);
            this.tabPage1.Controls.Add(this.ctUsuario);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 632);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(242, 349);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(330, 92);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Iniciar Sesion";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // ctPass
            // 
            this.ctPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctPass.Location = new System.Drawing.Point(388, 219);
            this.ctPass.Name = "ctPass";
            this.ctPass.PasswordChar = '*';
            this.ctPass.Size = new System.Drawing.Size(296, 45);
            this.ctPass.TabIndex = 3;
            // 
            // ctUsuario
            // 
            this.ctUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctUsuario.Location = new System.Drawing.Point(388, 98);
            this.ctUsuario.Name = "ctUsuario";
            this.ctUsuario.Size = new System.Drawing.Size(296, 45);
            this.ctUsuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.ctFahrenheit2);
            this.tabPage2.Controls.Add(this.ctCelsius2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btCaF);
            this.tabPage2.Controls.Add(this.btFaC);
            this.tabPage2.Controls.Add(this.ctCelsius1);
            this.tabPage2.Controls.Add(this.ctFahrenheit1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 632);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Temp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(577, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 32);
            this.label10.TabIndex = 11;
            this.label10.Text = "Celsius";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(534, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 32);
            this.label9.TabIndex = 10;
            this.label9.Text = "Fahrenheit";
            // 
            // ctFahrenheit2
            // 
            this.ctFahrenheit2.Location = new System.Drawing.Point(410, 361);
            this.ctFahrenheit2.Name = "ctFahrenheit2";
            this.ctFahrenheit2.ReadOnly = true;
            this.ctFahrenheit2.Size = new System.Drawing.Size(275, 38);
            this.ctFahrenheit2.TabIndex = 9;
            // 
            // ctCelsius2
            // 
            this.ctCelsius2.Location = new System.Drawing.Point(410, 124);
            this.ctCelsius2.Name = "ctCelsius2";
            this.ctCelsius2.ReadOnly = true;
            this.ctCelsius2.Size = new System.Drawing.Size(275, 38);
            this.ctCelsius2.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = ">>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = ">>";
            // 
            // btCaF
            // 
            this.btCaF.Location = new System.Drawing.Point(227, 424);
            this.btCaF.Name = "btCaF";
            this.btCaF.Size = new System.Drawing.Size(307, 77);
            this.btCaF.TabIndex = 5;
            this.btCaF.Text = "Convertir C a F";
            this.btCaF.UseVisualStyleBackColor = true;
            this.btCaF.Click += new System.EventHandler(this.btCaF_Click);
            // 
            // btFaC
            // 
            this.btFaC.Location = new System.Drawing.Point(227, 184);
            this.btFaC.Name = "btFaC";
            this.btFaC.Size = new System.Drawing.Size(307, 74);
            this.btFaC.TabIndex = 4;
            this.btFaC.Text = "Convertir F a C";
            this.btFaC.UseVisualStyleBackColor = true;
            this.btFaC.Click += new System.EventHandler(this.btFaC_Click);
            // 
            // ctCelsius1
            // 
            this.ctCelsius1.Location = new System.Drawing.Point(77, 361);
            this.ctCelsius1.Name = "ctCelsius1";
            this.ctCelsius1.Size = new System.Drawing.Size(275, 38);
            this.ctCelsius1.TabIndex = 3;
            this.ctCelsius1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctCelsius1_KeyPress);
            // 
            // ctFahrenheit1
            // 
            this.ctFahrenheit1.Location = new System.Drawing.Point(77, 124);
            this.ctFahrenheit1.Name = "ctFahrenheit1";
            this.ctFahrenheit1.Size = new System.Drawing.Size(275, 38);
            this.ctFahrenheit1.TabIndex = 2;
            this.ctFahrenheit1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctFarenheit1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fahrenheit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Celsius";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lClicks);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.click_panel);
            this.tabPage3.Location = new System.Drawing.Point(10, 48);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 632);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Click";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lClicks
            // 
            this.lClicks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lClicks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClicks.Location = new System.Drawing.Point(319, 483);
            this.lClicks.Name = "lClicks";
            this.lClicks.Size = new System.Drawing.Size(138, 38);
            this.lClicks.TabIndex = 2;
            this.lClicks.Text = "_____";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(170, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(434, 50);
            this.label11.TabIndex = 1;
            this.label11.Text = "vv CLICK HERE vv";
            // 
            // click_panel
            // 
            this.click_panel.BackColor = System.Drawing.Color.White;
            this.click_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.click_panel.Location = new System.Drawing.Point(237, 122);
            this.click_panel.Name = "click_panel";
            this.click_panel.Size = new System.Drawing.Size(300, 300);
            this.click_panel.TabIndex = 0;
            this.click_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.click_panel_MouseClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lClasificacion);
            this.tabPage4.Controls.Add(this.IMC);
            this.tabPage4.Controls.Add(this.BtCalcular);
            this.tabPage4.Controls.Add(this.ctAltura);
            this.tabPage4.Controls.Add(this.ctPeso);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(10, 48);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 632);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "IMC";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lClasificacion
            // 
            this.lClasificacion.AutoSize = true;
            this.lClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClasificacion.Location = new System.Drawing.Point(283, 530);
            this.lClasificacion.Name = "lClasificacion";
            this.lClasificacion.Size = new System.Drawing.Size(26, 39);
            this.lClasificacion.TabIndex = 6;
            this.lClasificacion.Text = " ";
            this.lClasificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IMC
            // 
            this.IMC.AutoSize = true;
            this.IMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMC.Location = new System.Drawing.Point(283, 453);
            this.IMC.Name = "IMC";
            this.IMC.Size = new System.Drawing.Size(207, 39);
            this.IMC.TabIndex = 5;
            this.IMC.Text = "__________";
            this.IMC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtCalcular
            // 
            this.BtCalcular.Location = new System.Drawing.Point(235, 280);
            this.BtCalcular.Name = "BtCalcular";
            this.BtCalcular.Size = new System.Drawing.Size(309, 96);
            this.BtCalcular.TabIndex = 4;
            this.BtCalcular.Text = "Calcular IMC";
            this.BtCalcular.UseVisualStyleBackColor = true;
            this.BtCalcular.Click += new System.EventHandler(this.BtCalcular_Click);
            // 
            // ctAltura
            // 
            this.ctAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctAltura.Location = new System.Drawing.Point(443, 183);
            this.ctAltura.Name = "ctAltura";
            this.ctAltura.Size = new System.Drawing.Size(112, 45);
            this.ctAltura.TabIndex = 3;
            this.ctAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctAltura_KeyPress);
            // 
            // ctPeso
            // 
            this.ctPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctPeso.Location = new System.Drawing.Point(443, 91);
            this.ctPeso.Name = "ctPeso";
            this.ctPeso.Size = new System.Drawing.Size(112, 45);
            this.ctPeso.TabIndex = 2;
            this.ctPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctPeso_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Altura (CM)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Peso (LBs)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 687);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox ctPass;
        private System.Windows.Forms.TextBox ctUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox ctPeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtCalcular;
        private System.Windows.Forms.TextBox ctAltura;
        private System.Windows.Forms.Button btCaF;
        private System.Windows.Forms.Button btFaC;
        private System.Windows.Forms.TextBox ctCelsius1;
        private System.Windows.Forms.TextBox ctFahrenheit1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ctFahrenheit2;
        private System.Windows.Forms.TextBox ctCelsius2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel click_panel;
        private System.Windows.Forms.TextBox lClicks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label IMC;
        private System.Windows.Forms.Label lClasificacion;
    }
}

