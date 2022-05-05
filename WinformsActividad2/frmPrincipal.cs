using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsActividad2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void agregarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregar alta = new frmAgregar();
            alta.ShowDialog();
          

        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void administrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmModificar))
                    return;
            }

            frmModificar ventana = new frmModificar();
            ventana.MdiParent = this;
            ventana.Show();




        }
    }
}
