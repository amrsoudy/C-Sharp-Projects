﻿namespace TestButton
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
            this.userBouton1 = new boutonuser_control.UserBouton();
            this.SuspendLayout();
            // 
            // userBouton1
            // 
            this.userBouton1.dialText = "Click Click";
            this.userBouton1.Location = new System.Drawing.Point(-44, 32);
            this.userBouton1.Name = "userBouton1";
            this.userBouton1.Size = new System.Drawing.Size(864, 610);
            this.userBouton1.TabIndex = 0;
<<<<<<< HEAD
            this.userBouton1.Load += new System.EventHandler(this.userBouton1_Load_2);
=======
>>>>>>> 0d6ae384b6c94762528477d2182263dff752ffff
            this.userBouton1.Click += new System.EventHandler(this.userBouton1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 530);
            this.Controls.Add(this.userBouton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private boutonuser_control.UserBouton userBouton1;
    }
}
