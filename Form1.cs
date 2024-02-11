using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presupuesto_de_un_hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btm_limpiar_Click(object sender, EventArgs e)
        {
            txt_presupuesto.Clear();
            txt_administracion.Clear();
            txt_cirugia.Clear();
            txt_emergencia.Clear();
            txt_imagenes.Clear();
            txt_laboratorio.Clear();
            txt_suministros.Clear();
        }

        private void btn_distribuir_Click(object sender, EventArgs e)
        {
            Double presupuesto, administracion, cirugia, emergencia, imagenes, suministros, laboratorio;
            
            presupuesto = Double.Parse(txt_presupuesto.Text);

            emergencia = (presupuesto * 30) / 100;
             cirugia = (presupuesto * 15) / 100;
             suministros = (presupuesto * 25) / 100;
             administracion= (presupuesto * 18) / 100;
            laboratorio = (presupuesto * 5) / 100;
            imagenes = (presupuesto * 7) / 100;

            txt_administracion.Text = administracion.ToString();
            txt_cirugia.Text = cirugia.ToString();
            txt_emergencia.Text = emergencia.ToString();
            txt_imagenes.Text = imagenes.ToString();
            txt_laboratorio.Text = laboratorio.ToString();
            txt_suministros.Text = suministros.ToString();
        }
    }
}
