using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_conge.Personnel
{
    public partial class Searching : Form
    {
        personne p;
        public Searching()
        {
            this.p = new personne();
            InitializeComponent();
        }

        private void Stext_TextChanged(object sender, EventArgs e)
        {
            if (CINradion.Checked)
            {
                p.cin = Stext.Text;
                var c = (from a in Program.gc.personnes
                         select new
                         {
                             a.cin,
                             a.nom,
                             a.prenom,
                             a.adress,
                             a.tel,
                             a.date_ns,
                             a.situation_fa,
                             a.nbr_enf,
                             a.grade,
                             a.afectation_act,
                             a.fonction_interier,
                             a.fonction_act,
                             a.date_rec,
                             a.niveau_ins,
                             a.diplome,
                             a.code_dip,
                             a.num_service
                         });
                dgv.DataSource = c.ToList();
            }
        }
    }
}
