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
    public partial class update_form : Form
    {
        personne cn;
        public update_form()
        {
            this.cn = new personne();
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            txtcin.Text = string.Empty;
            txtnom.Text = string.Empty;
            txtprn.Text = string.Empty;
            txtadress.Text = string.Empty;
            txttel.Text = string.Empty;
            txtdate1.Text = string.Empty;
            cmbSF.Text = string.Empty;
            cmbNE.Text = string.Empty;
            txtgrade.Text = string.Empty;
            txtAA.Text = string.Empty;
            txtFI.Text = string.Empty;
            txtFA.Text = string.Empty;
            txtdate2.Text = string.Empty;
            txtNI.Text = string.Empty;
            txtDiplome.Text = string.Empty;
            txtCD.Text = string.Empty;
            txtNS.Text = string.Empty;
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                personne p = new personne();
                p.cin = txtcin.Text;
                p.nom = txtnom.Text;
                p.prenom = txtprn.Text;
                p.adress = txtadress.Text;
                p.tel = txttel.Text;
                p.date_ns = DateTime.Parse(txtdate1.Text);
                p.situation_fa = cmbSF.Text;
                p.nbr_enf = int.Parse(cmbNE.Text);
                p.grade = txtgrade.Text;
                p.afectation_act = txtAA.Text;
                p.fonction_interier = txtFI.Text;
                p.fonction_act = txtFA.Text;
                p.date_rec = DateTime.Parse(txtdate2.Text);
                p.niveau_ins = txtNI.Text;
                p.diplome = txtDiplome.Text;
                p.code_dip = int.Parse(txtCD.Text);
                p.num_service = int.Parse(txtNS.Text);
                Program.gc.personnes.Add(p);
                Program.gc.SaveChanges();
                MessageBox.Show("Ce personne a ete bien ajouter", "Ajouter", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            cn.cin = textBox13.Text;
            var result = (from b in Program.gc.personnes
                     where b.cin == cn.cin
                     select new
                     {
                         b.cin,
                         b.nom,
                         b.prenom,
                         b.adress,
                         b.tel,
                         b.date_ns,
                         b.situation_fa,
                         b.nbr_enf,
                         b.grade,
                         b.afectation_act,
                         b.fonction_interier,
                         b.fonction_act,
                         b.date_rec,
                         b.niveau_ins,
                         b.diplome,
                         b.code_dip,
                         b.num_service
                     });
            foreach (var item in result)
            {
                textBox11.Text = item.nom.ToString();
                textBox10.Text = item.prenom.ToString();
                textBox9.Text = item.adress.ToString();
                textBox8.Text = item.tel.ToString();
                dateTimePicker1.Text = item.date_ns.ToString();
                comboBox2.Text = item.situation_fa.ToString();
                comboBox1.Text = item.nbr_enf.ToString();
                textBox12.Text = item.grade.ToString();
                textBox7.Text = item.afectation_act.ToString();
                textBox6.Text = item.fonction_interier.ToString();
                textBox5.Text = item.fonction_act.ToString();
                dateTimePicker2.Text = item.date_rec.ToString();
                textBox4.Text = item.niveau_ins.ToString();
                textBox3.Text = item.diplome.ToString();
                textBox2.Text = item.code_dip.ToString();
                textBox1.Text = item.num_service.ToString();
            }
            result.ToList();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            cn.cin = textBox13.Text;
            var s = (from a in Program.gc.personnes where a.cin == cn.cin select a).SingleOrDefault();
            s.nom = textBox11.Text;
            s.prenom = textBox10.Text;
            s.adress = textBox9.Text;
            s.tel = textBox8.Text;
            s.date_ns = DateTime.Parse(dateTimePicker1.Text);
            s.situation_fa = comboBox2.Text;
            s.nbr_enf = int.Parse(comboBox1.Text);
            s.grade = textBox12.Text;
            s.afectation_act = textBox7.Text;
            s.fonction_interier = textBox6.Text;
            s.fonction_act = textBox5.Text;
            s.date_rec= DateTime.Parse(dateTimePicker2.Text);
            s.niveau_ins = textBox4.Text;
            s.diplome = textBox3.Text;
            s.code_dip = int.Parse(textBox2.Text);
            s.num_service = int.Parse(textBox1.Text);
            Program.gc.SaveChanges();
            MessageBox.Show("Personel is updated", "Update", MessageBoxButtons.OK,
                icon: MessageBoxIcon.Information);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            cin.Text = string.Empty;
            nom.Text = string.Empty;
            prenom.Text = string.Empty;
            adresse.Text = string.Empty;
            telephone.Text = string.Empty;
            datte1.Text = string.Empty;
            SFamiliale.Text = string.Empty;
            Nenfent.Text = string.Empty;
            grade.Text = string.Empty;
            Aactuel.Text = string.Empty;
            Factuel.Text = string.Empty;
            Fint.Text = string.Empty;
            datte2.Text = string.Empty;
            Ninst.Text = string.Empty;
            diplome.Text = string.Empty;
            Cdip.Text = string.Empty;
            Nservice.Text = string.Empty;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            cn.cin = cin.Text;
            var f = (from j in Program.gc.personnes where j.cin == cn.cin select j).FirstOrDefault();
            Program.gc.personnes.Remove(f);
            Program.gc.SaveChanges();
            MessageBox.Show("Personel is deleted", "Delet", MessageBoxButtons.OK,
                icon: MessageBoxIcon.Information);
        }

        private void searchForDelete_btn_Click(object sender, EventArgs e)
        {
            cn.cin = cin.Text;
            var result = (from b in Program.gc.personnes
                          where b.cin == cn.cin
                          select new
                          {
                              b.cin,
                              b.nom,
                              b.prenom,
                              b.adress,
                              b.tel,
                              b.date_ns,
                              b.situation_fa,
                              b.nbr_enf,
                              b.grade,
                              b.afectation_act,
                              b.fonction_interier,
                              b.fonction_act,
                              b.date_rec,
                              b.niveau_ins,
                              b.diplome,
                              b.code_dip,
                              b.num_service
                          });
            foreach (var item in result)
            {
                nom.Text = item.nom.ToString();
                prenom.Text = item.prenom.ToString();
                adresse.Text = item.adress.ToString();
                telephone.Text = item.tel.ToString();
                datte1.Text = item.date_ns.ToString();
                SFamiliale.Text = item.situation_fa.ToString();
                Nenfent.Text = item.nbr_enf.ToString();
                grade.Text = item.grade.ToString();
                Aactuel.Text = item.afectation_act.ToString();
                Factuel.Text = item.fonction_interier.ToString();
                Fint.Text = item.fonction_act.ToString();
                datte2.Text = item.date_rec.ToString();
                Ninst.Text = item.niveau_ins.ToString();
                diplome.Text = item.diplome.ToString();
                Cdip.Text = item.code_dip.ToString();
                Nservice.Text = item.num_service.ToString();
            }
            result.ToList();
        }

        private void clear1_btn_Click(object sender, EventArgs e)
        {
            textBox11.Text = string.Empty;
            textBox10.Text = string.Empty;
            textBox9.Text = string.Empty;
            textBox8.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox1.Text = string.Empty;
            textBox12.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox5.Text = string.Empty;
            dateTimePicker2.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox1.Text = string.Empty;
        }
    }
}
