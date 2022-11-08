
namespace StoriesHelper.Windows.Projects.Icons
{
    partial class IconDescription
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
            this.labelDescription = new System.Windows.Forms.Label();
            this.titreDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDescription
            // 
            this.labelDescription.AutoEllipsis = true;
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDescription.Location = new System.Drawing.Point(3, 46);
            this.labelDescription.MaximumSize = new System.Drawing.Size(900, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(102, 22);
            this.labelDescription.TabIndex = 21;
            this.labelDescription.Text = "description";
            // 
            // titreDescription
            // 
            this.titreDescription.AutoSize = true;
            this.titreDescription.BackColor = System.Drawing.Color.Transparent;
            this.titreDescription.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titreDescription.Location = new System.Drawing.Point(36, 12);
            this.titreDescription.Name = "titreDescription";
            this.titreDescription.Size = new System.Drawing.Size(128, 25);
            this.titreDescription.TabIndex = 22;
            this.titreDescription.Text = "Description";
            // 
            // IconDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.titreDescription);
            this.Controls.Add(this.labelDescription);
            this.MaximumSize = new System.Drawing.Size(918, 15555555);
            this.Name = "IconDescription";
            this.Size = new System.Drawing.Size(918, 155);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label titreDescription;
    }
}
