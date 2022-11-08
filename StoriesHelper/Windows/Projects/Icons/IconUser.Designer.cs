
namespace StoriesHelper.Windows.Projects.Icons
{
    partial class IconUser
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
            this.labelUser = new System.Windows.Forms.Label();
            this.titreUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelUser.Location = new System.Drawing.Point(92, 48);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(31, 32);
            this.labelUser.TabIndex = 21;
            this.labelUser.Text = "0";
            // 
            // titreUser
            // 
            this.titreUser.AutoSize = true;
            this.titreUser.BackColor = System.Drawing.Color.Transparent;
            this.titreUser.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titreUser.Location = new System.Drawing.Point(11, 12);
            this.titreUser.Name = "titreUser";
            this.titreUser.Size = new System.Drawing.Size(215, 22);
            this.titreUser.TabIndex = 22;
            this.titreUser.Text = "Nombre d\'utilisateurs : ";
            // 
            // IconUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titreUser);
            this.Controls.Add(this.labelUser);
            this.Name = "IconUser";
            this.Size = new System.Drawing.Size(225, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label titreUser;
    }
}
