
namespace GestionHopital
{
    partial class secretaire
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.modifier = new System.Windows.Forms.Button();
            this.numticket = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.supprimer = new System.Windows.Forms.Button();
            this.allpatients = new System.Windows.Forms.DataGridView();
            this.temperature = new System.Windows.Forms.TextBox();
            this.poids = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ajouter = new System.Windows.Forms.Button();
            this.nouveau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allpatients)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Prenom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "NumTicket";
            // 
            // modifier
            // 
            this.modifier.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.ForeColor = System.Drawing.Color.Yellow;
            this.modifier.Location = new System.Drawing.Point(929, 39);
            this.modifier.Margin = new System.Windows.Forms.Padding(4);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(91, 55);
            this.modifier.TabIndex = 42;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // numticket
            // 
            this.numticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numticket.Location = new System.Drawing.Point(179, 39);
            this.numticket.Margin = new System.Windows.Forms.Padding(4);
            this.numticket.Name = "numticket";
            this.numticket.ReadOnly = true;
            this.numticket.Size = new System.Drawing.Size(136, 22);
            this.numticket.TabIndex = 41;
            // 
            // nom
            // 
            this.nom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(179, 112);
            this.nom.Margin = new System.Windows.Forms.Padding(4);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(136, 22);
            this.nom.TabIndex = 40;
            // 
            // prenom
            // 
            this.prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom.Location = new System.Drawing.Point(179, 179);
            this.prenom.Margin = new System.Windows.Forms.Padding(4);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(136, 22);
            this.prenom.TabIndex = 39;
            // 
            // age
            // 
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(525, 39);
            this.age.Margin = new System.Windows.Forms.Padding(4);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(136, 22);
            this.age.TabIndex = 38;
            // 
            // supprimer
            // 
            this.supprimer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.ForeColor = System.Drawing.Color.Red;
            this.supprimer.Location = new System.Drawing.Point(929, 147);
            this.supprimer.Margin = new System.Windows.Forms.Padding(4);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(91, 57);
            this.supprimer.TabIndex = 48;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // allpatients
            // 
            this.allpatients.AllowUserToAddRows = false;
            this.allpatients.AllowUserToDeleteRows = false;
            this.allpatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allpatients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.allpatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allpatients.Location = new System.Drawing.Point(56, 263);
            this.allpatients.Margin = new System.Windows.Forms.Padding(4);
            this.allpatients.Name = "allpatients";
            this.allpatients.ReadOnly = true;
            this.allpatients.Size = new System.Drawing.Size(941, 303);
            this.allpatients.TabIndex = 47;
            this.allpatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allpatients_CellContentClick);
            // 
            // temperature
            // 
            this.temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperature.Location = new System.Drawing.Point(525, 179);
            this.temperature.Margin = new System.Windows.Forms.Padding(4);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(136, 22);
            this.temperature.TabIndex = 50;
            // 
            // poids
            // 
            this.poids.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poids.Location = new System.Drawing.Point(525, 111);
            this.poids.Margin = new System.Windows.Forms.Padding(4);
            this.poids.Name = "poids";
            this.poids.Size = new System.Drawing.Size(136, 22);
            this.poids.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Temperature";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Poids";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Age";
            // 
            // ajouter
            // 
            this.ajouter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ajouter.Location = new System.Drawing.Point(727, 147);
            this.ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(91, 57);
            this.ajouter.TabIndex = 55;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // nouveau
            // 
            this.nouveau.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveau.ForeColor = System.Drawing.Color.Lime;
            this.nouveau.Location = new System.Drawing.Point(727, 39);
            this.nouveau.Margin = new System.Windows.Forms.Padding(4);
            this.nouveau.Name = "nouveau";
            this.nouveau.Size = new System.Drawing.Size(91, 55);
            this.nouveau.TabIndex = 56;
            this.nouveau.Text = "Nouveau";
            this.nouveau.UseVisualStyleBackColor = true;
            this.nouveau.Click += new System.EventHandler(this.nouveau_Click);
            // 
            // secretaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionHopital.Properties.Resources.Screenshot_20211226_020015;
            this.ClientSize = new System.Drawing.Size(1036, 594);
            this.Controls.Add(this.nouveau);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.poids);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.allpatients);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.numticket);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.age);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "secretaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "secretaire";
            this.Load += new System.EventHandler(this.secretaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allpatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button modifier;
        internal System.Windows.Forms.TextBox numticket;
        internal System.Windows.Forms.TextBox nom;
        internal System.Windows.Forms.TextBox prenom;
        internal System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.DataGridView allpatients;
        internal System.Windows.Forms.TextBox temperature;
        internal System.Windows.Forms.TextBox poids;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button nouveau;
    }
}