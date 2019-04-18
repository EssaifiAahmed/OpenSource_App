using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_conge
{
    public partial class Login : Form
    {
        gestion_de_congeEntities gc = new gestion_de_congeEntities();
        public Login()
        {
            Thread t = new Thread(new ThreadStart(Start));
            t.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            t.Abort();
        }

        public void Start()
        {
            Application.Run(new SplashScreen());
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (username.Text != "" && password.Text != "")
            {
                
                var a = (from b in gc.logines select b).ToList();
                foreach (var item in a)
                {
                    if (item.username.Equals(username.Text) && item.passworde.Equals(password.Text))
                    {
                        new Accueil().Show();
                        this.Hide();
                        
                    }
                } 
            }
            else
            {
                MessageBox.Show("votre username et mot de passe incorrect",
                    "Erreur d'enthentification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
