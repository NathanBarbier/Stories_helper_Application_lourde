
namespace StoriesHelper.Windows.Projects.Icons
{
    partial class IconType
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
            this.labelType = new System.Windows.Forms.Label();
            this.titreType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.Color.Transparent;
            this.labelType.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelType.Location = new System.Drawing.Point(74, 48);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(80, 25);
            this.labelType.TabIndex = 21;
            this.labelType.Text = "Type :  ";
            // 
            // titreType
            // 
            this.titreType.AutoSize = true;
            this.titreType.BackColor = System.Drawing.Color.Transparent;
            this.titreType.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titreType.Location = new System.Drawing.Point(73, 12);
            this.titreType.Name = "titreType";
            this.titreType.Size = new System.Drawing.Size(66, 22);
            this.titreType.TabIndex = 22;
            this.titreType.Text = "Type : ";
            // 
            // IconType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titreType);
            this.Controls.Add(this.labelType);
            this.Name = "IconType";
            this.Size = new System.Drawing.Size(225, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label titreType;
    }
}
