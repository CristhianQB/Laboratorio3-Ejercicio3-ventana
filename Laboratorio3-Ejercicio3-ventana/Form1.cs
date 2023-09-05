using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio3_Ejercicio3_ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad1 = int.Parse(txtb1.Text);
            int edad = int.Parse(txtb2.Text);
            int acerto = int.Parse(txtb3.Text);

            switch (edad1)
            {
                case 0:
                    if (acerto < 3)
                    {
                        int extra1 = edad * 5;
                        int extra2 = acerto * 2;
                        int total = extra1 + extra2 + 30;
                        lbl.Text = total.ToString() + " soles";
                    }
                    else if (edad >= 3)
                    {
                        int extra1 = edad * 5;
                        int extra2 = acerto * 2;
                        int total = extra1 + extra2 + 50;
                        lbl.Text = total.ToString() + " soles";
                    }
                    break;

                case 1:
                    if (acerto < 3)
                    {
                        int extra1 = edad * 5;
                        int extra2 = acerto * 2;
                        int total = extra1 + extra2 + 50;
                        lbl.Text = total.ToString() + " soles";
                    }
                    else if (edad >= 3)
                    {
                        int extra1 = edad * 5;
                        int extra2 = acerto * 2;
                        int total = extra1 + extra2 + 80;
                        lbl.Text = total.ToString() + " soles";
                    }
                    break;

            }
        }
    }
}
