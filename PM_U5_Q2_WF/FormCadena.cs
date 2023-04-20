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
    public partial class FormCadena : Form
    {
        [DllImport(@"D:\GitHub\prueba_dll_operaciones\Dll_PM_U5_EQ2\Debug\Dll_PM_U5_Q2.dll")]

        static extern int largo_cadena(string str);

        [DllImport(@"D:\GitHub\prueba_dll_operaciones\Dll_PM_U5_EQ2\Debug\Dll_PM_U5_Q2.dll")]

        static extern int escribir_cadena(StringBuilder str , int len_buffer);

        public FormCadena()
        {
            InitializeComponent();
        }

        private void FormCadena_Load(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder(20);
                int largo = escribir_cadena(sb, sb.Capacity);
                string c = sb.ToString();
                c = c.Substring(0, largo);
                MessageBox.Show(c);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.Close();
        }
    }
}
