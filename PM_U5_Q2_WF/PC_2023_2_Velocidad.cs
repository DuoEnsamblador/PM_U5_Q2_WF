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
    public partial class PC_2023_2_Velocidad : Form
    {
        [DllImport(@"D:\GitHub\prueba_dll_operaciones\Dll_PM_U5_EQ2\Debug\Dll_PM_U5_Q2.dll")]

        static extern int velocidad(StringBuilder strRes, string str , int distancia , int tiempo);
        public PC_2023_2_Velocidad()
        {
            InitializeComponent();
        }

        StringBuilder sb;

        private void PC_2023_2_Velocidad_Load(object sender, EventArgs e)
        {
            sb = new StringBuilder(100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sb.Clear();
            int largo = velocidad(sb, "Coche Azul",120 ,2);
               string c = sb.ToString();
            c = c.Substring(0, largo);
            MessageBox.Show(c);
        }
    }
}
