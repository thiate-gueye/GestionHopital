
namespace GestionHopital
{
    partial class comptable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nouveau = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.montant = new System.Windows.Forms.TextBox();
            this.supprimer = new System.Windows.Forms.Button();
            this.payements = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.modifier = new System.Windows.Forms.Button();
            this.numticket = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.numpayement = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.payements)).BeginInit();
            this.SuspendLayout();
            // 
            // nouveau
            // 
            this.nouveau.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveau.ForeColor = System.Drawing.Color.Lime;
            this.nouveau.Location = new System.Drawing.Point(719, 34);
            this.nouveau.Margin = new System.Windows.Forms.Padding(4);
            this.nouveau.Name = "nouveau";
            this.nouveau.Size = new System.Drawing.Size(91, 55);
            this.nouveau.TabIndex = 73;
            this.nouveau.Text = "Nouveau";
            this.nouveau.UseVisualStyleBackColor = true;
            this.nouveau.Click += new System.EventHandler(this.nouveau_Click);
            // 
            // ajouter
            // 
            this.ajouter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ajouter.Location = new System.Drawing.Point(719, 142);
            this.ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(91, 57);
            this.ajouter.TabIndex = 72;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Montant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "NumPayement";
            // 
            // montant
            // 
            this.montant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montant.Location = new System.Drawing.Point(497, 155);
            this.montant.Margin = new System.Windows.Forms.Padding(4);
            this.montant.Name = "montant";
            this.montant.Size = new System.Drawing.Size(136, 22);
            this.montant.TabIndex = 68;
            // 
            // supprimer
            // 
            this.supprimer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.ForeColor = System.Drawing.Color.Red;
            this.supprimer.Location = new System.Drawing.Point(921, 142);
            this.supprimer.Margin = new System.Windows.Forms.Padding(4);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(91, 57);
            this.supprimer.TabIndex = 66;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // payements
            // 
            this.payements.AllowUserToAddRows = false;
            this.payements.AllowUserToDeleteRows = false;
            this.payements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payements.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.payements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payements.Location = new System.Drawing.Point(48, 258);
            this.payements.Margin = new System.Windows.Forms.Padding(4);
            this.payements.Name = "payements";
            this.payements.ReadOnly = true;
            this.payements.Size = new System.Drawing.Size(941, 303);
            this.payements.TabIndex = 65;
            this.payements.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.payements_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Prenom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "NumTicket";
            // 
            // modifier
            // 
            this.modifier.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.ForeColor = System.Drawing.Color.Yellow;
            this.modifier.Location = new System.Drawing.Point(921, 34);
            this.modifier.Margin = new System.Windows.Forms.Padding(4);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(91, 55);
            this.modifier.TabIndex = 61;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // numticket
            // 
            this.numticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numticket.Location = new System.Drawing.Point(171, 34);
            this.numticket.Margin = new System.Windows.Forms.Padding(4);
            this.numticket.Name = "numticket";
            this.numticket.Size = new System.Drawing.Size(136, 22);
            this.numticket.TabIndex = 60;
            // 
            // nom
            // 
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(171, 107);
            this.nom.Margin = new System.Windows.Forms.Padding(4);
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Size = new System.Drawing.Size(136, 22);
            this.nom.TabIndex = 59;
            // 
            // prenom
            // 
            this.prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom.Location = new System.Drawing.Point(171, 174);
            this.prenom.Margin = new System.Windows.Forms.Padding(4);
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            this.prenom.Size = new System.Drawing.Size(136, 22);
            this.prenom.TabIndex = 58;
            // 
            // numpayement
            // 
            this.numpayement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numpayement.Location = new System.Drawing.Point(497, 47);
            this.numpayement.Margin = new System.Windows.Forms.Padding(4);
            this.numpayement.Name = "numpayement";
            this.numpayement.ReadOnly = true;
            this.numpayement.Size = new System.Drawing.Size(136, 22);
            this.numpayement.TabIndex = 57;
            // 
            // comptable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionHopital.Properties.Resources.Screenshot_20211226_020146;
            this.ClientSize = new System.Drawing.Size(1036, 594);
            this.Controls.Add(this.nouveau);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.montant);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.payements);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.numticket);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.numpayement);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "comptable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "comptable";
            this.Load += new System.EventHandler(this.comptable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nouveau;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox montant;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.DataGridView payements;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button modifier;
        internal System.Windows.Forms.TextBox numticket;
        internal System.Windows.Forms.TextBox nom;
        internal System.Windows.Forms.TextBox prenom;
        internal System.Windows.Forms.TextBox numpayement;
    }
}