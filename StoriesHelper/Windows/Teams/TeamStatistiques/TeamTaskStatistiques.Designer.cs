
namespace StoriesHelper.Windows.Teams.TeamStatistiques
{
    partial class TeamTaskStatistiques
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.precedent = new System.Windows.Forms.Button();
            this.jour = new System.Windows.Forms.Button();
            this.mois = new System.Windows.Forms.Button();
            this.annee = new System.Windows.Forms.Button();
            this.suivant = new System.Windows.Forms.Button();
            this.semaine = new System.Windows.Forms.Button();
            this.PanelTeamTaskGraphics = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // precedent
            // 
            this.precedent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.precedent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precedent.Location = new System.Drawing.Point(280, 10);
            this.precedent.Name = "precedent";
            this.precedent.Size = new System.Drawing.Size(100, 30);
            this.precedent.TabIndex = 32;
            this.precedent.Text = "<< précédent";
            this.precedent.UseVisualStyleBackColor = true;
            this.precedent.Click += new System.EventHandler(this.btnDateGraphics);
            // 
            // jour
            // 
            this.jour.BackColor = System.Drawing.Color.Transparent;
            this.jour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jour.FlatAppearance.BorderSize = 0;
            this.jour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.jour.Location = new System.Drawing.Point(410, 10);
            this.jour.Name = "jour";
            this.jour.Size = new System.Drawing.Size(100, 30);
            this.jour.TabIndex = 33;
            this.jour.Text = "Jour";
            this.jour.UseVisualStyleBackColor = false;
            this.jour.Click += new System.EventHandler(this.btnDateGraphics);
            // 
            // mois
            // 
            this.mois.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mois.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.mois.Location = new System.Drawing.Point(670, 10);
            this.mois.Name = "mois";
            this.mois.Size = new System.Drawing.Size(100, 30);
            this.mois.TabIndex = 34;
            this.mois.Text = "Mois";
            this.mois.UseVisualStyleBackColor = true;
            this.mois.Click += new System.EventHandler(this.btnDateGraphics);
            // 
            // annee
            // 
            this.annee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.annee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.annee.Location = new System.Drawing.Point(800, 10);
            this.annee.Name = "annee";
            this.annee.Size = new System.Drawing.Size(100, 30);
            this.annee.TabIndex = 35;
            this.annee.Text = "Année";
            this.annee.UseVisualStyleBackColor = true;
            this.annee.Click += new System.EventHandler(this.btnDateGraphics);
            // 
            // suivant
            // 
            this.suivant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.suivant.Location = new System.Drawing.Point(930, 10);
            this.suivant.Name = "suivant";
            this.suivant.Size = new System.Drawing.Size(100, 30);
            this.suivant.TabIndex = 36;
            this.suivant.Text = "Suivant >>";
            this.suivant.UseVisualStyleBackColor = true;
            this.suivant.Click += new System.EventHandler(this.btnDateGraphics);
            // 
            // semaine
            // 
            this.semaine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.semaine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.semaine.Location = new System.Drawing.Point(540, 10);
            this.semaine.Name = "semaine";
            this.semaine.Size = new System.Drawing.Size(100, 30);
            this.semaine.TabIndex = 37;
            this.semaine.Text = "Semaine";
            this.semaine.UseVisualStyleBackColor = true;
            this.semaine.Click += new System.EventHandler(this.btnDateGraphics);
            // 
            // PanelTeamTaskGraphics
            // 
            this.PanelTeamTaskGraphics.Location = new System.Drawing.Point(0, 40);
            this.PanelTeamTaskGraphics.Margin = new System.Windows.Forms.Padding(2);
            this.PanelTeamTaskGraphics.Name = "PanelTeamTaskGraphics";
            this.PanelTeamTaskGraphics.Size = new System.Drawing.Size(1075, 408);
            this.PanelTeamTaskGraphics.TabIndex = 38;
            // 
            // TeamTaskStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PanelTeamTaskGraphics);
            this.Controls.Add(this.semaine);
            this.Controls.Add(this.mois);
            this.Controls.Add(this.suivant);
            this.Controls.Add(this.annee);
            this.Controls.Add(this.jour);
            this.Controls.Add(this.precedent);
            this.Name = "TeamTaskStatistiques";
            this.Size = new System.Drawing.Size(1077, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button precedent;
        private System.Windows.Forms.Button jour;
        private System.Windows.Forms.Button mois;
        private System.Windows.Forms.Button annee;
        private System.Windows.Forms.Button suivant;
        private System.Windows.Forms.Button semaine;
        private System.Windows.Forms.Panel PanelTeamTaskGraphics;
    }
}
