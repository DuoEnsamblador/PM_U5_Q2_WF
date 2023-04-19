using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_U5_Q2_WF
{
    public partial class Form2multi : Form
    {
        [DllImport(@"C:\Users\Usuario\Downloads\microooo\unidad 5\Dll_PM_U5_EQ2\Debug\Dll_PM_U5_Q2.dll")]

        static extern int multiplicacion(int x, int y);
        public Form2multi()
        {
            InitializeComponent();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form2multi_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(texto1.Text);
            int b = Convert.ToInt32(texto2.Text); ;

            int r = multiplicacion(a,b);

           Resultado.Text = r.ToString();
        }

        private void Resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void texto2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
