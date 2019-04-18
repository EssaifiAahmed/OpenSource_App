using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_conge
{
    public partial class Accueil : Form
    {
        
        public Accueil()
        {
            InitializeComponent();
            
        }

        private void Acueil_Load(object sender, EventArgs e)
        {
            var a = (from b in Program.gc.personnes select b).ToList();
            foreach (var item in a)
            {
                user.Text = item.nom + " " + item.prenom;
            }
            acueil1.Show();
            personnel1.Hide();
            congé1.Hide();
            historique1.Hide();
            imprimer1.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (DateTime.Now.Minute < 10)
            {
                label2.Text =  DateTime.Now.Hour.ToString() + ":" + "0" + DateTime.Now.Minute.ToString();
            }
            else
            {
                label2.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            if (DateTime.Now.Day < 10)
            {
                label4.Text = "0" + DateTime.Now.Day.ToString() + "/0" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            }
            else
            {
                label4.Text = DateTime.Now.Day.ToString() + "/0" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();

            }
        }

        private void btn_accueil_Click(object sender, EventArgs e)
        {
            acueil1.BringToFront();
            acueil1.Show();
        }

        private void btn_Personnel_Click(object sender, EventArgs e)
        {
            personnel1.BringToFront();
            personnel1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            congé1.BringToFront();
            congé1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            historique1.BringToFront();
            historique1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            imprimer1.BringToFront();
            imprimer1.Show();
        }
    }
}
