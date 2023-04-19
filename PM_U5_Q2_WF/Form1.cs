using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_U5_Q2_WF
{
    public partial class Form1 : Form
    {
        [DllImport(@"C:\Users\EMMANUEL\source\repos\Dll_PM_U5_Q2\Debug\Dll_PM_U5_Q2.dll")]

        static extern int suma(int x, int y);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtA.Text);
            int b = Convert.ToInt32(txtB.Text); ;

            int r = suma(a,b);

            MessageBox.Show(r.ToString());
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
