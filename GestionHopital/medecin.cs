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
    public partial class medecin : Form
    {
        List<Metier.Consultations> mesConsultations;
        public medecin()
        {
            InitializeComponent();
            constructData();
        }

        private void constructData()
        {
            consultations.ColumnCount = 7;
            consultations.Columns[0].Name = "NumConsultation";
            consultations.Columns[1].Name = "NumTicket";
            consultations.Columns[2].Name = "Prenom";
            consultations.Columns[3].Name = "Nom";
            consultations.Columns[4].Name = "Age";
            consultations.Columns[5].Name = "Date";
            consultations.Columns[6].Name = "Montant";
        }

        private void nouveau_Click(object sender, EventArgs e)
        {
            numconsultation.ReadOnly = false;
            numconsultation.Text = null;
            numticket.Text = null;
            nom.Text = null;
            prenom.Text = null;
            age.Text = null;
            montant.Text = null;
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if ( numticket.Text != "" && numconsultation.Text != "" )
                {
                    Consultations consultations = new Consultations();
                    consultations.numticket = int.Parse(numticket.Text);
                    consultations.numconsultation = int.Parse(numconsultation.Text);
                    consultations.date = DateTime.Today;

                    var reponse = Services.data("8083/consultations", consultations);
                    if (reponse != null)
                    {
                        MessageBox.Show("Consultation ajoutée avec succes", "entry succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        medecin_Load(sender, e);
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
                if (numticket.Text != "" && numconsultation.Text != "")
                {
                    Consultations consultations = new Consultations();
                    consultations.numticket = int.Parse(numticket.Text);
                    consultations.nom = nom.Text;
                    consultations.prenom = prenom.Text;
                    consultations.numconsultation = int.Parse(numconsultation.Text);

                    var reponse = Services.dataPut("8083/consultations/"+consultations.numconsultation, consultations);

                    if (reponse != null)
                    {
                        MessageBox.Show("Consultation modifiée avec succes", "entry succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        medecin_Load(sender, e);
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
                if (MessageBox.Show("Voulez-vous bien supprimer cette consultation !!!", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var reponse = Services.dataDelete("8083/consultations/" + numconsultation.Text);
                    MessageBox.Show("Consultation supprimée avec succes", "entry succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        medecin_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void medecin_Load(object sender, EventArgs e)
        {
            consultations.Rows.Clear();
            var reponse = await Services.data("8083/consultations");
            mesConsultations = JsonConvert.DeserializeObject<List<Metier.Consultations>>(reponse);
            formater(mesConsultations);
            DataGridViewRow row = this.consultations.Rows[0];
            remplir(row);
            numconsultation.ReadOnly = true;
        }

        private void formater(List<Metier.Consultations> mesConsultations)
        {
            foreach (Metier.Consultations consult in mesConsultations)
            {
                consultations.Rows.Add(consult.numconsultation, consult.numticket, consult.prenom,
                    consult.nom, consult.age, consult.date, consult.montant);
            }
        }

        private void consultations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.consultations.Rows[e.RowIndex];
            remplir(row);
        }

        private void remplir(DataGridViewRow row)
        {
            nom.Text = row.Cells["nom"].Value.ToString();
            prenom.Text = row.Cells["prenom"].Value.ToString();
            numticket.Text = row.Cells["numticket"].Value.ToString();
            age.Text = row.Cells["age"].Value.ToString();
            numconsultation.Text = row.Cells["numconsultation"].Value.ToString();
            montant.Text = row.Cells["montant"].Value.ToString();
        }
    }
}
