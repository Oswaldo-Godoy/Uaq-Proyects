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
    public partial class Cambios_Bjas : Form
    {
        public Cambios_Bjas()
        {
            InitializeComponent();
        }

        private void btn_MenuP_Click(object sender, EventArgs e)
        {
            Menu_Principal abrir = new Menu_Principal();
            abrir.Show();
            this.Close();
        }
    }
}
