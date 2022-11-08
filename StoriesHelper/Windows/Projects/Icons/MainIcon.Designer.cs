
namespace StoriesHelper.Windows.Projects.Icons
{
    partial class MainIcon
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
            this.panelDate = new System.Windows.Forms.Panel();
            this.panelUser = new System.Windows.Forms.Panel();
            this.panelTeam = new System.Windows.Forms.Panel();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.panelType = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelDate
            // 
            this.panelDate.Location = new System.Drawing.Point(273, 42);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(225, 110);
            this.panelDate.TabIndex = 1;
            // 
            // panelUser
            // 
            this.panelUser.Location = new System.Drawing.Point(504, 42);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(225, 110);
            this.panelUser.TabIndex = 2;
            // 
            // panelTeam
            // 
            this.panelTeam.Location = new System.Drawing.Point(735, 42);
            this.panelTeam.Name = "panelTeam";
            this.panelTeam.Size = new System.Drawing.Size(225, 110);
            this.panelTeam.TabIndex = 3;
            // 
            // panelDescription
            // 
            this.panelDescription.AutoScroll = true;
            this.panelDescription.Location = new System.Drawing.Point(42, 158);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(918, 155);
            this.panelDescription.TabIndex = 1;
            // 
            // panelType
            // 
            this.panelType.Location = new System.Drawing.Point(42, 42);
            this.panelType.Name = "panelType";
            this.panelType.Size = new System.Drawing.Size(225, 110);
            this.panelType.TabIndex = 2;
            // 
            // MainIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelType);
            this.Controls.Add(this.panelDescription);
            this.Controls.Add(this.panelTeam);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.panelDate);
            this.Name = "MainIcon";
            this.Size = new System.Drawing.Size(1000, 350);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panelTeam;
        private System.Windows.Forms.Panel panelDescription;
        private System.Windows.Forms.Panel panelType;
    }
}
