﻿namespace test_bouton_2015
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bouton1 = new boutonuser_control_2015.UserBouton();
            this.TxtMesure = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Afficher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bouton1
            // 
            this.Bouton1.Location = new System.Drawing.Point(59, 52);
            this.Bouton1.Mesure = 0;
            this.Bouton1.Name = "Bouton1";
            this.Bouton1.Size = new System.Drawing.Size(301, 170);
            this.Bouton1.TabIndex = 0;
            // 
            // TxtMesure
            // 
            this.TxtMesure.Location = new System.Drawing.Point(198, 261);
            this.TxtMesure.Name = "TxtMesure";
            this.TxtMesure.Size = new System.Drawing.Size(100, 20);
            this.TxtMesure.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valeur";
            // 
            // Afficher
            // 
            this.Afficher.Location = new System.Drawing.Point(323, 261);
            this.Afficher.Name = "Afficher";
            this.Afficher.Size = new System.Drawing.Size(75, 23);
            this.Afficher.TabIndex = 3;
            this.Afficher.Text = "Afficher";
            this.Afficher.UseVisualStyleBackColor = true;
            this.Afficher.Click += new System.EventHandler(this.Afficher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 330);
            this.Controls.Add(this.Afficher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtMesure);
            this.Controls.Add(this.Bouton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private boutonuser_control_2015.UserBouton Bouton1;
        private System.Windows.Forms.TextBox TxtMesure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Afficher;
    }
}

