using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto.F
{
    public partial class Alta_D : Form
    {
        public Alta_D()
        {
            InitializeComponent();
        }

        private void btn_MenP_Click(object sender, EventArgs e)
        {
            Menu_Principal abrir = new Menu_Principal();
            abrir.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ruta = (@"C:\Users\zkyri\Desktop\Visual S\ProyectoF\Registro.txt");
            StreamWriter escritura = File.AppendText(ruta);

            string ID = text_ID.Text;
            string fecha = text_Fecha.Text;
            string precipitación = text_Prep.Text;
            string evaporacion = text_Evap.Text;
            string tempMax = text_TempMax.Text;
            string tempMin = text_TempMin.Text;

            


            


        }
    }
}
