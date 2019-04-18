using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_de_conge.Personnel;

namespace Gestion_de_conge.UserControls
{
    public partial class Personnel : UserControl
    {
        public Personnel()
        {
            InitializeComponent();
        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Aqua;
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Aqua;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Aqua;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            update_form uf = new update_form();
            uf.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Searching s = new Searching();
            s.Show();
        }
    }
}
