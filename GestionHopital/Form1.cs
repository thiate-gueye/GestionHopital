using GestionHopital.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHopital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void login_Click(object sender, EventArgs e)
        {
            try
            {
                if (fonction.Text == "Admin")
                {
                    administration administration = new administration();
                    administration.ShowDialog();
                }
                else if (fonction.Text == "Medecin")
                {
                    var reponse = await Services.data("8083/connexion/", username.Text + "/", password.Text);
                    if (reponse == "true")
                    {
                        username.Text = null;
                        password.Text = null;
                        fonction.Text = null;

                        medecin medecin = new medecin();
                        medecin.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Username et/ou password incorrect", "entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        username.Text = null;
                        password.Text = null;
                    }
                }
                else if (fonction.Text == "Comptable")
                {
                    var reponse = await Services.data("8082/connexion/", username.Text + "/", password.Text);
                    if (reponse == "true")
                    {
                        username.Text = null;
                        password.Text = null;
                        fonction.Text = null;

                        comptable comptable = new comptable();
                        comptable.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Username et/ou password incorrect", "entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        username.Text = null;
                        password.Text = null;
                    }
                }
                else if (fonction.Text == "Secretaire")
                {
                    var reponse = await Services.data("8081/connexion/", username.Text + "/", password.Text);
                    if (reponse == "true")
                    {
                        username.Text = null;
                        password.Text = null;
                        fonction.Text = null;

                        secretaire secretaire = new secretaire();
                        secretaire.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Username et/ou password incorrect", "entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        username.Text = null;
                        password.Text = null;
                    }

                }
                else
                {
                    MessageBox.Show("La fonction specifiée n'est pas valide", "entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    username.Text = null;
                    password.Text = null;
                    fonction.Text = null;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Erreur 500: probleme de serveur", "entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.Text = null;
                password.Text = null;
                fonction.Text = null;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            username.Text = null;
            password.Text = null;
            fonction.Text = null;
        }

    }
}
