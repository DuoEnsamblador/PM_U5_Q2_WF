﻿using System;
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
    public partial class PC12023_1variante : Form

    {
        [DllImport(@"C:\Users\Usuario\Downloads\microooo\unidad 5\Dll_PM_U5_EQ2\Debug\Dll_PM_U5_Q2.dll")]

        static extern int Calculartiempo(StringBuilder strRes, int velocidad, int distancia);
        public PC12023_1variante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder(100);
            int largo = Calculartiempo(sb, 90, 500);
            string c = sb.ToString();
            c = c.Substring(0, largo);
            MessageBox.Show(c);
        }
    }
}
