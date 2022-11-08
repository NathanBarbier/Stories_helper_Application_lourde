
namespace StoriesHelper.Windows.Projects.ProjectListTeam
{
    partial class MainProjectListTeam
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
            PanelListTeams = new System.Windows.Forms.Panel();
            PanelPagination = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelListTeams
            // 
            PanelListTeams.Location = new System.Drawing.Point(0, 0);
            PanelListTeams.Name = "PanelListTeams";
            PanelListTeams.Size = new System.Drawing.Size(625, 250);
            PanelListTeams.TabIndex = 0;
            // 
            // PanelPagination
            // 
            PanelPagination.AutoSize = true;
            PanelPagination.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            PanelPagination.Location = new System.Drawing.Point(0, 250);
            PanelPagination.MaximumSize = new System.Drawing.Size(625, 250);
            PanelPagination.Name = "PanelPagination";
            PanelPagination.Size = new System.Drawing.Size(0, 0);
            PanelPagination.TabIndex = 1;
            // 
            // MainProjectListTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(PanelPagination);
            this.Controls.Add(PanelListTeams);
            this.Name = "MainProjectListTeam";
            this.Size = new System.Drawing.Size(625, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private static System.Windows.Forms.Panel PanelListTeams;
        private static System.Windows.Forms.Panel PanelPagination;
    }
}
