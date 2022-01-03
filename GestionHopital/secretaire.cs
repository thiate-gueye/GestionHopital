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
    public partial class secretaire : Form
    {
        List<Metier.Patients> mesPatients;
        public secretaire()
        {
            InitializeComponent();
            constructData();
        }

        private void constructData()
        {
            allpatients.ColumnCount = 7;
            allpatients.Columns[0].Name = "NumTicket";
            allpatients.Columns[1].Name = "Nom";
            allpatients.Columns[2].Name = "Prenom";
            allpatients.Columns[3].Name = "Age";
            allpatients.Columns[4].Name = "Date";
            allpatients.Columns[5].Name = "Poids";
            allpatients.Columns[6].Name = "Temperature";
        }

        private void nouveau_Click(object sender, EventArgs e)
        {
            numticket.ReadOnly = false;
            numticket.Text = null;
            nom.Text = null;
            prenom.Text = null;
            age.Text = null;
            poids.Text = null;
            temperature.Text = null;

        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (nom.Text != "" && numticket.Text != "" && prenom.Text != "" && age.Text != "" && poids.Text != "" && temperature.Text != "")
                {
                    Patients patients = new Patients();
                    patients.numticket = int.Parse(numticket.Text);
                    patients.nom = nom.Text;
                    patients.prenom = prenom.Text;
                    patients.age = int.Parse(age.Text);
                    patients.date = DateTime.Today;
                    patients.poids = int.Parse(poids.Text);
                    patients.temperature = int.Parse(temperature.Text);

                    var reponse = Services.data("8081/patients", patients);

                    if (reponse != null)
                    {
                        MessageBox.Show("Patient ajoutée avec succes", "entry succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        secretaire_Load(sender, e);
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
                if (nom.Text != "" && numticket.Text != "" && prenom.Text != "" && age.Text != "" && poids.Text != "" && temperature.Text != "")
                {
                    Patients patients = new Patients();
                    patients.numticket = int.Parse(numticket.Text);
                    patients.nom = nom.Text;
                    patients.prenom = prenom.Text;
                    patients.age = int.Parse(age.Text);
                    patients.poids = int.Parse(poids.Text);
                    patients.temperature = int.Parse(temperature.Text);

                    var reponse = Services.dataPut("8081/patients/"+patients.numticket, patients);

                    if (reponse != null)
                    {
                        MessageBox.Show("Patient modifié avec succes", "entry succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        secretaire_Load(sender, e);
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
                if(MessageBox.Show("Voulez-vous bien supprimé ce patient !!!", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var reponse = Services.dataDelete("8081/patients/" + numticket.Text);
                     MessageBox.Show("Patient supprimé avec succes", "entry succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        secretaire_Load(sender, e);   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void secretaire_Load(object sender, EventArgs e)
        {
            allpatients.Rows.Clear();
            var reponse = await Services.data("8081/patients");
            mesPatients = JsonConvert.DeserializeObject<List<Metier.Patients>>(reponse);
            formater(mesPatients);
            DataGridViewRow row = this.allpatients.Rows[0];
            remplir(row);
            numticket.ReadOnly = true;
        }

        private void formater(List<Metier.Patients> patients)
        {
            foreach (Metier.Patients patient in patients)
            {
                allpatients.Rows.Add(patient.numticket,patient.nom,patient.prenom,patient.age,
                    patient.date,patient.poids,patient.temperature);
            }
        }

        private void allpatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.allpatients.Rows[e.RowIndex];
            remplir(row);
        }

        private void remplir(DataGridViewRow row)
        {
            nom.Text = row.Cells["nom"].Value.ToString();
            prenom.Text = row.Cells["prenom"].Value.ToString();
            numticket.Text = row.Cells["numticket"].Value.ToString();
            age.Text = row.Cells["age"].Value.ToString();
            poids.Text = row.Cells["poids"].Value.ToString();
            temperature.Text = row.Cells["temperature"].Value.ToString();
        }
    }
}
