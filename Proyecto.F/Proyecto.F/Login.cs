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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Resitro_Click(object sender, EventArgs e)
        {
            Registro abrir = new Registro();
            abrir.Show();
            this.Hide();

        }

        private void btn_Sesion_Click(object sender, EventArgs e)
        {
            StreamReader lectura =File.OpenText(@"C:\Users\zkyri\Desktop\Visual S\ProyectoF\Usuarios");
            string conteni = lectura.ReadToEnd();
            string usuario = text_Usua.Text;
            string password = text_Passw.Text;
            string busca = Console.ReadLine();

            if (usuario != conteni) 
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos");
            }
            else
            {
                if(password != conteni)
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
                lectura.Close();
            }
            
            Menu_Principal abrir = new Menu_Principal();
            abrir.Show();
            this.Hide();


            /*Menu_Principal abrir = new Menu_Principal();
            abrir.Show();
            this.Hide();*/
        }
    }
}
