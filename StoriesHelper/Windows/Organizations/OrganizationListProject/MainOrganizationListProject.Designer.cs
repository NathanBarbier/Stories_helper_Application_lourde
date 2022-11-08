
namespace StoriesHelper.Windows.Organizations.OrganizationListProject
{
    partial class MainOrganizationListProject
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
            PanelPagination = new System.Windows.Forms.Panel();
            PanelListProjects = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelPagination
            // 
            PanelPagination.AutoSize = true;
            PanelPagination.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            PanelPagination.BackColor = System.Drawing.Color.Transparent;
            PanelPagination.Location = new System.Drawing.Point(0, 401);
            PanelPagination.MaximumSize = new System.Drawing.Size(520, 38);
            PanelPagination.Name = "PanelPagination";
            PanelPagination.Size = new System.Drawing.Size(0, 0);
            PanelPagination.TabIndex = 0;
            // 
            // PanelListProjects
            // 
            PanelListProjects.AutoScroll = true;
            PanelListProjects.BackColor = System.Drawing.Color.Transparent;
            PanelListProjects.Location = new System.Drawing.Point(0, 0);
            PanelListProjects.Name = "PanelListProjects";
            PanelListProjects.Size = new System.Drawing.Size(520, 403);
            PanelListProjects.TabIndex = 1;
            // 
            // MainOrganizationListProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(PanelListProjects);
            this.Controls.Add(PanelPagination);
            this.Name = "MainOrganizationListProject";
            this.Size = new System.Drawing.Size(520, 440);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private static System.Windows.Forms.Panel PanelPagination;
        private static System.Windows.Forms.Panel PanelListProjects;
    }
}
