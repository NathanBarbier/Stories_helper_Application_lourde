using StoriesHelper.Services;

namespace StoriesHelper.Windows
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Gradient1 = new StoriesHelper.Services.Gradient();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.erreur = new System.Windows.Forms.Label();
            this.connexion = new System.Windows.Forms.Button();
            this.titre = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.Gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Gradient1
            // 
            this.Gradient1.Angle = 90F;
            this.Gradient1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(181)))));
            this.Gradient1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(1)))), ((int)(((byte)(224)))));
            this.Gradient1.Controls.Add(this.pictureBox1);
            this.Gradient1.Controls.Add(this.erreur);
            this.Gradient1.Controls.Add(this.connexion);
            this.Gradient1.Controls.Add(this.titre);
            this.Gradient1.Controls.Add(this.passwordInput);
            this.Gradient1.Controls.Add(this.emailLabel);
            this.Gradient1.Controls.Add(this.passwordLabel);
            this.Gradient1.Controls.Add(this.emailInput);
            this.Gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gradient1.Location = new System.Drawing.Point(0, 0);
            this.Gradient1.Margin = new System.Windows.Forms.Padding(2);
            this.Gradient1.Name = "Gradient1";
            this.Gradient1.Size = new System.Drawing.Size(450, 575);
            this.Gradient1.TabIndex = 7;
            this.Gradient1.TopColor = System.Drawing.Color.Empty;
            this.Gradient1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(400, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.quitter_Click);
            // 
            // erreur
            // 
            this.erreur.AutoSize = true;
            this.erreur.BackColor = System.Drawing.Color.Transparent;
            this.erreur.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erreur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.erreur.Location = new System.Drawing.Point(74, 147);
            this.erreur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erreur.Name = "erreur";
            this.erreur.Size = new System.Drawing.Size(0, 22);
            this.erreur.TabIndex = 8;
            // 
            // connexion
            // 
            this.connexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.connexion.FlatAppearance.BorderSize = 0;
            this.connexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connexion.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connexion.ForeColor = System.Drawing.Color.White;
            this.connexion.Location = new System.Drawing.Point(130, 440);
            this.connexion.Margin = new System.Windows.Forms.Padding(2);
            this.connexion.Name = "connexion";
            this.connexion.Size = new System.Drawing.Size(190, 46);
            this.connexion.TabIndex = 6;
            this.connexion.Text = "Connexion";
            this.connexion.UseVisualStyleBackColor = false;
            this.connexion.Click += new System.EventHandler(this.connexion_Click);
            // 
            // titre
            // 
            this.titre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titre.AutoSize = true;
            this.titre.BackColor = System.Drawing.Color.Transparent;
            this.titre.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.ForeColor = System.Drawing.Color.White;
            this.titre.Location = new System.Drawing.Point(18, 87);
            this.titre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(421, 41);
            this.titre.TabIndex = 0;
            this.titre.Text = "StoriesHelper BackOffice";
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Cambria", 13.8F);
            this.passwordInput.Location = new System.Drawing.Point(60, 326);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(2);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(330, 29);
            this.passwordInput.TabIndex = 4;
            this.passwordInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(70, 181);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(172, 26);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Adresse Email *";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(70, 288);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(159, 26);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Mot de passe *";
            // 
            // emailInput
            // 
            this.emailInput.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailInput.Location = new System.Drawing.Point(60, 222);
            this.emailInput.Margin = new System.Windows.Forms.Padding(2);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(330, 29);
            this.emailInput.TabIndex = 1;
            this.emailInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(450, 575);
            this.Controls.Add(this.Gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pageConnexion";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Gradient1.ResumeLayout(false);
            this.Gradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button connexion;
        private Gradient Gradient1;
        private System.Windows.Forms.Label erreur;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

