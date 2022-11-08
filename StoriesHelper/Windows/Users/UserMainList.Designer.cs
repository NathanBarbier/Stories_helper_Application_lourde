
namespace StoriesHelper.Windows.Users
{
    partial class UserMainList
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
            this.gradient = new StoriesHelper.Services.Gradient();
            panelPagination = new System.Windows.Forms.FlowLayoutPanel();
            this.UserTitre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFilterId = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            panelListUsers = new System.Windows.Forms.Panel();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.labelFilterProject = new System.Windows.Forms.Label();
            this.comboProject = new System.Windows.Forms.ComboBox();
            this.labelFilterTeam = new System.Windows.Forms.Label();
            this.comboTeam = new System.Windows.Forms.ComboBox();
            this.labelFilterFirstName = new System.Windows.Forms.Label();
            this.labelFilterEmail = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textFirstname = new System.Windows.Forms.TextBox();
            this.labelFilterName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.gradient.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradient
            // 
            this.gradient.Angle = 90F;
            this.gradient.BackColor = System.Drawing.Color.Transparent;
            this.gradient.BottomColor = System.Drawing.Color.White;
            this.gradient.Controls.Add(panelPagination);
            this.gradient.Controls.Add(this.UserTitre);
            this.gradient.Controls.Add(this.label6);
            this.gradient.Controls.Add(this.label5);
            this.gradient.Controls.Add(this.label3);
            this.gradient.Controls.Add(this.label2);
            this.gradient.Controls.Add(this.label1);
            this.gradient.Controls.Add(this.label4);
            this.gradient.Controls.Add(this.labelFilterId);
            this.gradient.Controls.Add(this.textId);
            this.gradient.Controls.Add(panelListUsers);
            this.gradient.Controls.Add(this.buttonFilter);
            this.gradient.Controls.Add(this.labelFilterProject);
            this.gradient.Controls.Add(this.comboProject);
            this.gradient.Controls.Add(this.labelFilterTeam);
            this.gradient.Controls.Add(this.comboTeam);
            this.gradient.Controls.Add(this.labelFilterFirstName);
            this.gradient.Controls.Add(this.labelFilterEmail);
            this.gradient.Controls.Add(this.textEmail);
            this.gradient.Controls.Add(this.textFirstname);
            this.gradient.Controls.Add(this.labelFilterName);
            this.gradient.Controls.Add(this.textName);
            this.gradient.Location = new System.Drawing.Point(0, 0);
            this.gradient.Name = "gradient";
            this.gradient.Size = new System.Drawing.Size(1101, 900);
            this.gradient.TabIndex = 5;
            this.gradient.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            // 
            // panelPagination
            // 
            panelPagination.AutoSize = true;
            panelPagination.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panelPagination.Location = new System.Drawing.Point(18, 840);
            panelPagination.MaximumSize = new System.Drawing.Size(1081, 40);
            panelPagination.Name = "panelPagination";
            panelPagination.Size = new System.Drawing.Size(200, 0);
            panelPagination.TabIndex = 28;
            // 
            // UserTitre
            // 
            this.UserTitre.AutoSize = true;
            this.UserTitre.BackColor = System.Drawing.Color.Transparent;
            this.UserTitre.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Bold);
            this.UserTitre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserTitre.Location = new System.Drawing.Point(369, 9);
            this.UserTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserTitre.Name = "UserTitre";
            this.UserTitre.Size = new System.Drawing.Size(358, 41);
            this.UserTitre.TabIndex = 26;
            this.UserTitre.Text = "Liste des Utilisateurs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(790, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Projets";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(620, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Équipes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(370, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(250, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(110, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "NOM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Id";
            // 
            // labelFilterId
            // 
            this.labelFilterId.AutoSize = true;
            this.labelFilterId.BackColor = System.Drawing.Color.Transparent;
            this.labelFilterId.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFilterId.Location = new System.Drawing.Point(731, 155);
            this.labelFilterId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFilterId.Name = "labelFilterId";
            this.labelFilterId.Size = new System.Drawing.Size(43, 25);
            this.labelFilterId.TabIndex = 19;
            this.labelFilterId.Text = "Id :";
            // 
            // textId
            // 
            this.textId.BackColor = System.Drawing.SystemColors.Control;
            this.textId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textId.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textId.Location = new System.Drawing.Point(736, 183);
            this.textId.Margin = new System.Windows.Forms.Padding(2);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(149, 29);
            this.textId.TabIndex = 18;
            // 
            // panelListUsers
            // 
            panelListUsers.AutoScroll = true;
            panelListUsers.Location = new System.Drawing.Point(17, 274);
            panelListUsers.Name = "panelListUsers";
            panelListUsers.Size = new System.Drawing.Size(1081, 560);
            panelListUsers.TabIndex = 17;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilter.Location = new System.Drawing.Point(917, 179);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(149, 38);
            this.buttonFilter.TabIndex = 16;
            this.buttonFilter.Text = "Filtrer";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // labelFilterProject
            // 
            this.labelFilterProject.AutoSize = true;
            this.labelFilterProject.BackColor = System.Drawing.Color.Transparent;
            this.labelFilterProject.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterProject.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFilterProject.Location = new System.Drawing.Point(386, 155);
            this.labelFilterProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFilterProject.Name = "labelFilterProject";
            this.labelFilterProject.Size = new System.Drawing.Size(83, 25);
            this.labelFilterProject.TabIndex = 15;
            this.labelFilterProject.Text = "Projet :";
            // 
            // comboProject
            // 
            this.comboProject.BackColor = System.Drawing.SystemColors.Control;
            this.comboProject.Font = new System.Drawing.Font("Cambria", 13.8F);
            this.comboProject.FormattingEnabled = true;
            this.comboProject.Location = new System.Drawing.Point(391, 183);
            this.comboProject.Name = "comboProject";
            this.comboProject.Size = new System.Drawing.Size(330, 29);
            this.comboProject.TabIndex = 14;
            // 
            // labelFilterTeam
            // 
            this.labelFilterTeam.AutoSize = true;
            this.labelFilterTeam.BackColor = System.Drawing.Color.Transparent;
            this.labelFilterTeam.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterTeam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFilterTeam.Location = new System.Drawing.Point(43, 155);
            this.labelFilterTeam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFilterTeam.Name = "labelFilterTeam";
            this.labelFilterTeam.Size = new System.Drawing.Size(91, 25);
            this.labelFilterTeam.TabIndex = 13;
            this.labelFilterTeam.Text = "Équipe :";
            // 
            // comboTeam
            // 
            this.comboTeam.BackColor = System.Drawing.SystemColors.Control;
            this.comboTeam.Font = new System.Drawing.Font("Cambria", 13.8F);
            this.comboTeam.FormattingEnabled = true;
            this.comboTeam.Location = new System.Drawing.Point(48, 183);
            this.comboTeam.MaxLength = 5;
            this.comboTeam.Name = "comboTeam";
            this.comboTeam.Size = new System.Drawing.Size(330, 29);
            this.comboTeam.TabIndex = 12;
            // 
            // labelFilterFirstName
            // 
            this.labelFilterFirstName.AutoSize = true;
            this.labelFilterFirstName.BackColor = System.Drawing.Color.Transparent;
            this.labelFilterFirstName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterFirstName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFilterFirstName.Location = new System.Drawing.Point(386, 87);
            this.labelFilterFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFilterFirstName.Name = "labelFilterFirstName";
            this.labelFilterFirstName.Size = new System.Drawing.Size(101, 25);
            this.labelFilterFirstName.TabIndex = 10;
            this.labelFilterFirstName.Text = "Prénom :";
            // 
            // labelFilterEmail
            // 
            this.labelFilterEmail.AutoSize = true;
            this.labelFilterEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelFilterEmail.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFilterEmail.Location = new System.Drawing.Point(731, 87);
            this.labelFilterEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFilterEmail.Name = "labelFilterEmail";
            this.labelFilterEmail.Size = new System.Drawing.Size(78, 25);
            this.labelFilterEmail.TabIndex = 9;
            this.labelFilterEmail.Text = "Email :";
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.SystemColors.Control;
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEmail.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(736, 114);
            this.textEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(330, 29);
            this.textEmail.TabIndex = 8;
            // 
            // textFirstname
            // 
            this.textFirstname.BackColor = System.Drawing.SystemColors.Control;
            this.textFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFirstname.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFirstname.Location = new System.Drawing.Point(391, 114);
            this.textFirstname.Margin = new System.Windows.Forms.Padding(2);
            this.textFirstname.Name = "textFirstname";
            this.textFirstname.Size = new System.Drawing.Size(330, 29);
            this.textFirstname.TabIndex = 7;
            // 
            // labelFilterName
            // 
            this.labelFilterName.AutoSize = true;
            this.labelFilterName.BackColor = System.Drawing.Color.Transparent;
            this.labelFilterName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFilterName.Location = new System.Drawing.Point(43, 87);
            this.labelFilterName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFilterName.Name = "labelFilterName";
            this.labelFilterName.Size = new System.Drawing.Size(68, 25);
            this.labelFilterName.TabIndex = 6;
            this.labelFilterName.Text = "Nom :";
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.SystemColors.Control;
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textName.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(48, 114);
            this.textName.Margin = new System.Windows.Forms.Padding(2);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(330, 29);
            this.textName.TabIndex = 2;
            // 
            // UserMainList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gradient);
            this.Name = "UserMainList";
            this.Size = new System.Drawing.Size(1101, 900);
            this.gradient.ResumeLayout(false);
            this.gradient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Services.Gradient gradient;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label labelFilterProject;
        private System.Windows.Forms.ComboBox comboProject;
        private System.Windows.Forms.Label labelFilterTeam;
        private System.Windows.Forms.ComboBox comboTeam;
        private System.Windows.Forms.Label labelFilterFirstName;
        private System.Windows.Forms.Label labelFilterEmail;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textFirstname;
        private System.Windows.Forms.Label labelFilterName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelFilterId;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label UserTitre;
        private static System.Windows.Forms.Panel panelListUsers;
        private static System.Windows.Forms.FlowLayoutPanel panelPagination;
    }
}
