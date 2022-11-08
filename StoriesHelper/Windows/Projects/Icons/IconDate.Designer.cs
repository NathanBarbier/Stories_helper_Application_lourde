
namespace StoriesHelper.Windows.Projects.Icons
{
    partial class IconDate
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
            this.labelDate = new System.Windows.Forms.Label();
            this.titreDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDate.Location = new System.Drawing.Point(74, 48);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(78, 25);
            this.labelDate.TabIndex = 21;
            this.labelDate.Text = "Date :  ";
            // 
            // titreDate
            // 
            this.titreDate.AutoSize = true;
            this.titreDate.BackColor = System.Drawing.Color.Transparent;
            this.titreDate.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titreDate.Location = new System.Drawing.Point(36, 12);
            this.titreDate.Name = "titreDate";
            this.titreDate.Size = new System.Drawing.Size(163, 22);
            this.titreDate.TabIndex = 22;
            this.titreDate.Text = "date de création : ";
            // 
            // IconDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titreDate);
            this.Controls.Add(this.labelDate);
            this.Name = "IconDate";
            this.Size = new System.Drawing.Size(225, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label titreDate;
    }
}
