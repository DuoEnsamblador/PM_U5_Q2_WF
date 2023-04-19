
namespace PM_U5_Q2_WF
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSumar = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lbA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(216, 126);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(201, 76);
            this.btnSumar.TabIndex = 0;
            this.btnSumar.Text = "SUMAR";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(133, 32);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(137, 45);
            this.txtA.TabIndex = 1;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(394, 32);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(137, 45);
            this.txtB.TabIndex = 2;
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.Location = new System.Drawing.Point(87, 46);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(40, 31);
            this.lbA.TabIndex = 3;
            this.lbA.Text = "A:";
            this.lbA.Click += new System.EventHandler(this.lbA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "B:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 239);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnSumar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label label1;
    }
}

