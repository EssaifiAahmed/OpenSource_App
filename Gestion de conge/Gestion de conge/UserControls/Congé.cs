using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_conge.UserControls
{
    public partial class Congé : UserControl
    {
        public Congé()
        {
            InitializeComponent();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Aqua;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
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

        private void panel4_MouseEnter_1(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Aqua;
        }

        private void panel4_MouseLeave_1(object sender, EventArgs e)
        {
            panel4.BackColor = Color.White;
        }

        private void panel3_MouseEnter_1(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Aqua;
        }

        private void panel3_MouseLeave_1(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
        }
    }
}
