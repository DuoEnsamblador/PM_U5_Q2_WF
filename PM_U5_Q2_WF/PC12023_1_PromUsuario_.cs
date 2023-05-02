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
    public partial class PC12023_1_PromUsuario_ : Form
    {
        [DllImport(@"C:\Users\Usuario\Downloads\microooo\unidad 5\Dll_PM_U5_EQ2\Debug\Dll_PM_U5_Q2.dll")]

        static extern int promedioDeUsuario(string str , int cal1,int cal2 , int cal3);

        [DllImport(@"C:\Users\Usuario\Downloads\microooo\unidad 5\Dll_PM_U5_EQ2\Debug\Dll_PM_U5_Q2.dll")]

        static extern int promUsuario(StringBuilder strRes, string str, int cal1, int cal2, int cal3);
       

            public PC12023_1_PromUsuario_()
        {
            InitializeComponent();
        }

        private void PC12023_1_PromUsuario__Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = "Garuco";
            int nota1 = 5;
            int nota2 = 6;
            int nota3 = 9;

            StringBuilder sb = new StringBuilder(100);
            int largo = promUsuario(sb, nombre, nota1, nota2, nota3);
            string mensaje = sb.ToString().Substring(0, largo);

            MessageBox.Show(mensaje);
        }
    }
}
