
namespace StoriesHelper.Windows.Projects.Icons
{
    partial class IconTeam
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
            this.labelTeam = new System.Windows.Forms.Label();
            this.titreTeam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.BackColor = System.Drawing.Color.Transparent;
            this.labelTeam.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeam.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelTeam.Location = new System.Drawing.Point(86, 48);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(37, 32);
            this.labelTeam.TabIndex = 21;
            this.labelTeam.Text = "0 ";
            // 
            // titreTeam
            // 
            this.titreTeam.AutoSize = true;
            this.titreTeam.BackColor = System.Drawing.Color.Transparent;
            this.titreTeam.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreTeam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titreTeam.Location = new System.Drawing.Point(20, 12);
            this.titreTeam.Name = "titreTeam";
            this.titreTeam.Size = new System.Drawing.Size(182, 22);
            this.titreTeam.TabIndex = 22;
            this.titreTeam.Text = "Nombre d\'équipes : ";
            // 
            // IconTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titreTeam);
            this.Controls.Add(this.labelTeam);
            this.Name = "IconTeam";
            this.Size = new System.Drawing.Size(225, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.Label titreTeam;
    }
}
