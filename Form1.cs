using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Aisgnatura_profesor_que_imparte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_asignatura.Clear();
            txt_profesor.Clear();
            txt_informacion.Clear();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string profesor, asignatura, modalidad = " ";

            asignatura = txt_asignatura.Text;
            profesor = txt_profesor.Text;

            if (rb_presencial.Checked)
            {
                modalidad = "Presencial";
            }
            else if (rb_virtual.Checked)
            {
                modalidad = "Virtual";
            }

            txt_informacion.Text = profesor + (" imparte la asignatura ") + asignatura + " en la modalidad " + modalidad;


        }
    }
}
