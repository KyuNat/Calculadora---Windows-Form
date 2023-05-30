namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIgual = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnponto = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.Gray;
            this.btnIgual.Location = new System.Drawing.Point(348, 241);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(87, 116);
            this.btnIgual.TabIndex = 0;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(12, 12);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(413, 38);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn0.Location = new System.Drawing.Point(12, 302);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(156, 55);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn4.Location = new System.Drawing.Point(12, 180);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 55);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn6.Location = new System.Drawing.Point(174, 180);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 55);
            this.btn6.TabIndex = 4;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn2.Location = new System.Drawing.Point(93, 241);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 55);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCE.Location = new System.Drawing.Point(174, 58);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(75, 55);
            this.btnCE.TabIndex = 6;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn7.Location = new System.Drawing.Point(12, 119);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 55);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn5.Location = new System.Drawing.Point(93, 180);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 55);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn3.Location = new System.Drawing.Point(174, 241);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 55);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn1.Location = new System.Drawing.Point(12, 241);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 55);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnponto
            // 
            this.btnponto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnponto.Location = new System.Drawing.Point(174, 302);
            this.btnponto.Name = "btnponto";
            this.btnponto.Size = new System.Drawing.Size(75, 55);
            this.btnponto.TabIndex = 11;
            this.btnponto.Text = ".";
            this.btnponto.UseVisualStyleBackColor = false;
            this.btnponto.Click += new System.EventHandler(this.btnponto_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn8.Location = new System.Drawing.Point(93, 119);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 55);
            this.btn8.TabIndex = 12;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn9.Location = new System.Drawing.Point(174, 119);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 55);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.Color.White;
            this.btnMenos.Location = new System.Drawing.Point(255, 241);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(87, 55);
            this.btnMenos.TabIndex = 14;
            this.btnMenos.Text = "_";
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.White;
            this.btnDiv.Location = new System.Drawing.Point(255, 180);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(87, 55);
            this.btnDiv.TabIndex = 15;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMais
            // 
            this.btnMais.BackColor = System.Drawing.Color.White;
            this.btnMais.Location = new System.Drawing.Point(255, 302);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(87, 55);
            this.btnMais.TabIndex = 16;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = false;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(348, 180);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(87, 55);
            this.btnX.TabIndex = 17;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnC.Location = new System.Drawing.Point(12, 58);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(156, 55);
            this.BtnC.TabIndex = 18;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Location = new System.Drawing.Point(22, 20);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(0, 13);
            this.lblOperacao.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(348, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 55);
            this.button1.TabIndex = 20;
            this.button1.Text = "√";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(348, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 55);
            this.button2.TabIndex = 21;
            this.button2.Text = "%";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(255, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 55);
            this.button3.TabIndex = 22;
            this.button3.Text = "^";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(255, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 55);
            this.button4.TabIndex = 23;
            this.button4.Text = "PI";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 369);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnponto);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnIgual);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnponto;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

