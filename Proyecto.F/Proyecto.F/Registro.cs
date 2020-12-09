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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            if (tB_Usua.Text != "" && textB_Contra.Text != "")
            {
                btn_RegisGuardar.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            string usuario = tB_Usua.Text;
            string password = textB_Contra.Text;

            string ruta = (@"C:\Users\zkyri\Desktop\Visual S\ProyectoF\Usuarios");
            StreamWriter escritura = File.AppendText(ruta);

            if (usuario != "" && password != "")
            {
                escritura.WriteLine(usuario + "," + password);
                Estado_U.Text = "Usuario Registrado";
                btn_RegisGuardar.Enabled = false;
            }
            else
            {
                Estado_U.Text = "Llene todos los campos";
            }
            escritura.Close();
        }

        private void btn_RegresarL_Click(object sender, EventArgs e)
        {
            Login abrir = new Login();
            abrir.Show();
            this.Close();
        }
    }
}
