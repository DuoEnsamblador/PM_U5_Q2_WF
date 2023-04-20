
namespace PM_U5_Q2_WF
{
    partial class Form2multi
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
            this.label1 = new System.Windows.Forms.Label();
            this.texto1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.texto2 = new System.Windows.Forms.TextBox();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(83, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE EL 1 NUMERO: ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // texto1
            // 
            this.texto1.Location = new System.Drawing.Point(381, 100);
            this.texto1.Multiline = true;
            this.texto1.Name = "texto1";
            this.texto1.Size = new System.Drawing.Size(82, 28);
            this.texto1.TabIndex = 1;
            this.texto1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(83, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "INGRESE EL 2 NUMERO: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // texto2
            // 
            this.texto2.Location = new System.Drawing.Point(381, 201);
            this.texto2.Multiline = true;
            this.texto2.Name = "texto2";
            this.texto2.Size = new System.Drawing.Size(82, 28);
            this.texto2.TabIndex = 3;
            this.texto2.TextChanged += new System.EventHandler(this.texto2_TextChanged);
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_multiplicar.Location = new System.Drawing.Point(33, 283);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(137, 48);
            this.btn_multiplicar.TabIndex = 4;
            this.btn_multiplicar.Text = "M U L T I P L I C A R";
            this.btn_multiplicar.UseVisualStyleBackColor = false;
            this.btn_multiplicar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(645, 295);
            this.Resultado.Multiline = true;
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(93, 36);
            this.Resultado.TabIndex = 5;
            this.Resultado.TextChanged += new System.EventHandler(this.Resultado_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(41, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "MULTIPLICACIONES";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(408, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "EL RESULTADO ES:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "R E S T A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(197, 283);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(152, 48);
            this.btnSumar.TabIndex = 9;
            this.btnSumar.Text = "S U M A R";
            this.btnSumar.UseVisualStyleBackColor = true;
            // 
            // Form2multi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.btn_multiplicar);
            this.Controls.Add(this.texto2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texto1);
            this.Controls.Add(this.label1);
            this.Name = "Form2multi";
            this.Text = "Form2multi";
            this.Load += new System.EventHandler(this.Form2multi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texto1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texto2;
        private System.Windows.Forms.Button btn_multiplicar;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSumar;
    }
}