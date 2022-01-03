using GestionHopital.Metier;
using GestionHopital.Service;
using Newtonsoft.Json;
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
    public partial class comptable : Form
    {
        List<Metier.Payements> mesPayements;
        public comptable()
        {
            InitializeComponent();
            constructData();
        }

        private void constructData()
        {
            payements.ColumnCount = 6;
            payements.Columns[0].Name = "NumTicket";
            payements.Columns[1].Name = "NumPayement";
            payements.Columns[2].Name = "Prenom";
            payements.Columns[3].Name = "Nom";
            payements.Columns[4].Name = "Date";
            payements.Columns[5].Name = "Montant";
        }

        private void nouveau_Click(object sender, EventArgs e)
        {
            numpayement.ReadOnly = false;
            numticket.ReadOnly = false;
            nom.Text = null;
            prenom.Text = null;
            numticket.Text = null;
            numpayement.Text = null;
            montant.Text = null;
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (numticket.Text != "" && numpayement.Text != "" && montant.Text != "")
                {
                    Payements payements = new Payements();
                    payements.numticket = int.Parse(numticket.Text);
                    payements.nom = nom.Text;
                    payements.prenom = prenom.Text;
                    payements.numpayement = int.Parse(numpayement.Text);
                    payements.date = DateTime.Today;
                    payements.montant = int.Parse(montant.Text);

                    var reponse = Services.data("8082/payements", payements);

                    if (reponse != null)
                    {
                        MessageBox.Show("Payement ajoutée avec succes", "entry succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comptable_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error 500 : probleme de serveur!!!", "entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Tous les champs sont obligatoires et doivent etre renseigné",
                        "entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (numticket.Text != "" && numpayement.Text != "" && montant.Text != "")
                {
                    Payements payements = new Payements();
                    payements.numpayement = int.Parse(numpayement.Text);
                    payements.numticket = int.Parse(numticket.Text);
                    payements.nom = nom.Text;
                    payements.prenom = prenom.Text;
                    payements.montant = int.Parse(montant.Text);

                    var reponse = Services.dataPut("8082/payements/"+payements.numpayement, payements);

                    if (reponse != null)
                    {
                        MessageBox.Show("Payement modifié avec succes", "entry succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comptable_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error 500 : probleme de serveur!!!", "entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Tous les champs sont obligatoires et doivent etre renseigné",
                        "entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez-vous bien supprimé ce payement !!!", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var reponse = Services.dataDelete("8082/payements/" + numpayement.Text);
                    MessageBox.Show("Payement supprimé avec succes", "entry succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comptable_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void comptable_Load(object sender, EventArgs e)
        {
            payements.Rows.Clear();
            var reponse = await Services.data("8082/payements");
            mesPayements = JsonConvert.DeserializeObject<List<Metier.Payements>>(reponse);
            formater(mesPayements);
            DataGridViewRow row = this.payements.Rows[0];
            remplir(row);
        }

        private void formater(List<Metier.Payements> mespayements)
        {
            foreach (Metier.Payements payement in mespayements)
            {
                payements.Rows.Add(payement.numticket, payement.numpayement, payement.prenom, payement.nom,
                    payement.date, payement.montant);
            }
        }

        private void payements_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.payements.Rows[e.RowIndex];
            remplir(row);
            numpayement.ReadOnly = true;
        }

        private void remplir(DataGridViewRow row)
        {
            nom.Text = row.Cells["nom"].Value.ToString();
            prenom.Text = row.Cells["prenom"].Value.ToString();
            numticket.Text = row.Cells["numticket"].Value.ToString();
            numpayement.Text = row.Cells["numpayement"].Value.ToString();
            montant.Text = row.Cells["montant"].Value.ToString();
        }
    }
}
