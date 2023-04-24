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
        public PC12023_1_PromUsuario_()
        {
            InitializeComponent();
        }

        private void PC12023_1_PromUsuario__Load(object sender, EventArgs e)
        {
            string nombre;
            int cal1;
            int cal2;
            int cal3;
            string cadenaResultado;

            nombre = "Secuestrador";
            cal1 = 8;
            cal2 = 9;
            cal3 = 10;

            int p = promedioDeUsuario(nombre, cal1, cal2, cal3);

            cadenaResultado = nombre + " El promedio es: " + p.ToString();

            MessageBox.Show(cadenaResultado);

        }
    }
}
