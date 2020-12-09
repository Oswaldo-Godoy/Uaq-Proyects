using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.F
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            Alta_D abrir = new Alta_D();
            abrir.Show();
            this.Hide();
        }

        private void btn_Cambios_Click(object sender, EventArgs e)
        {
            Cambios_Bjas abrir = new Cambios_Bjas();
            abrir.Show();
            this.Hide();

        }

        private void btn_Cred_Click(object sender, EventArgs e)
        {
            Creditos abrir = new Creditos();
            abrir.Show();
            this.Hide();
        }

        private void btn_returnLogin_Click(object sender, EventArgs e)
        {
            Login abrir = new Login();
            abrir.Show();
            this.Close();
        }
    }
}
