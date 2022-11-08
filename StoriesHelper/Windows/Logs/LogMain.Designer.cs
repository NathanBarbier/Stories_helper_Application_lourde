
namespace StoriesHelper.Windows.Logs
{
    partial class LogMain
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
            this.PanelLogConsole = new System.Windows.Forms.Panel();
            this.actionCombo = new System.Windows.Forms.ComboBox();
            this.statusCombo = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.objetCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pageCombo = new System.Windows.Forms.ComboBox();
            this.filtre = new System.Windows.Forms.Button();
            this.allowDateDebut = new System.Windows.Forms.CheckBox();
            this.allowDateFin = new System.Windows.Forms.CheckBox();
            this.error = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.DisplayLogStatistiques = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelLogConsole
            // 
            this.PanelLogConsole.AutoScroll = true;
            this.PanelLogConsole.BackColor = System.Drawing.Color.Black;
            this.PanelLogConsole.Location = new System.Drawing.Point(0, 0);
            this.PanelLogConsole.Name = "PanelLogConsole";
            this.PanelLogConsole.Size = new System.Drawing.Size(1101, 650);
            this.PanelLogConsole.TabIndex = 0;
            // 
            // actionCombo
            // 
            this.actionCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionCombo.FormattingEnabled = true;
            this.actionCombo.Location = new System.Drawing.Point(665, 723);
            this.actionCombo.Name = "actionCombo";
            this.actionCombo.Size = new System.Drawing.Size(165, 28);
            this.actionCombo.TabIndex = 4;
            // 
            // statusCombo
            // 
            this.statusCombo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCombo.FormattingEnabled = true;
            this.statusCombo.Location = new System.Drawing.Point(437, 724);
            this.statusCombo.Name = "statusCombo";
            this.statusCombo.Size = new System.Drawing.Size(200, 27);
            this.statusCombo.TabIndex = 5;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(433, 702);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(68, 20);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "Status : ";
            // 
            // dateDebut
            // 
            this.dateDebut.Enabled = false;
            this.dateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDebut.Location = new System.Drawing.Point(35, 725);
            this.dateDebut.MaxDate = new System.DateTime(2022, 4, 10, 0, 0, 0, 0);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(177, 26);
            this.dateDebut.TabIndex = 7;
            this.dateDebut.Value = new System.DateTime(2022, 4, 10, 0, 0, 0, 0);
            // 
            // dateFin
            // 
            this.dateFin.Enabled = false;
            this.dateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFin.Location = new System.Drawing.Point(242, 725);
            this.dateFin.MaxDate = new System.DateTime(2022, 4, 10, 0, 0, 0, 0);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(175, 26);
            this.dateFin.TabIndex = 8;
            this.dateFin.Value = new System.DateTime(2022, 4, 10, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 702);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Date Début : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 702);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date Fin : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(661, 701);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Action : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 773);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Objet : ";
            // 
            // objetCombo
            // 
            this.objetCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objetCombo.FormattingEnabled = true;
            this.objetCombo.Location = new System.Drawing.Point(35, 799);
            this.objetCombo.Name = "objetCombo";
            this.objetCombo.Size = new System.Drawing.Size(165, 28);
            this.objetCombo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 773);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Page : ";
            // 
            // pageCombo
            // 
            this.pageCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageCombo.FormattingEnabled = true;
            this.pageCombo.Location = new System.Drawing.Point(228, 799);
            this.pageCombo.Name = "pageCombo";
            this.pageCombo.Size = new System.Drawing.Size(282, 28);
            this.pageCombo.TabIndex = 15;
            // 
            // filtre
            // 
            this.filtre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtre.Location = new System.Drawing.Point(526, 799);
            this.filtre.Name = "filtre";
            this.filtre.Size = new System.Drawing.Size(149, 27);
            this.filtre.TabIndex = 16;
            this.filtre.Text = "Filtrer";
            this.filtre.UseVisualStyleBackColor = true;
            this.filtre.Click += new System.EventHandler(this.filtre_Click);
            // 
            // allowDateDebut
            // 
            this.allowDateDebut.AutoSize = true;
            this.allowDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allowDateDebut.Location = new System.Drawing.Point(141, 707);
            this.allowDateDebut.Name = "allowDateDebut";
            this.allowDateDebut.Size = new System.Drawing.Size(15, 14);
            this.allowDateDebut.TabIndex = 17;
            this.allowDateDebut.UseVisualStyleBackColor = true;
            this.allowDateDebut.CheckedChanged += new System.EventHandler(this.allowDateDebut_CheckedChanged);
            // 
            // allowDateFin
            // 
            this.allowDateFin.AutoSize = true;
            this.allowDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allowDateFin.Location = new System.Drawing.Point(326, 707);
            this.allowDateFin.Name = "allowDateFin";
            this.allowDateFin.Size = new System.Drawing.Size(15, 14);
            this.allowDateFin.TabIndex = 18;
            this.allowDateFin.UseVisualStyleBackColor = true;
            this.allowDateFin.CheckedChanged += new System.EventHandler(this.allowDateFin_CheckedChanged);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(32, 669);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 20);
            this.error.TabIndex = 19;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(681, 799);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(149, 27);
            this.clear.TabIndex = 20;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // DisplayLogStatistiques
            // 
            this.DisplayLogStatistiques.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayLogStatistiques.Location = new System.Drawing.Point(875, 725);
            this.DisplayLogStatistiques.Name = "DisplayLogStatistiques";
            this.DisplayLogStatistiques.Size = new System.Drawing.Size(139, 82);
            this.DisplayLogStatistiques.TabIndex = 21;
            this.DisplayLogStatistiques.Text = "Voir Statistique";
            this.DisplayLogStatistiques.UseVisualStyleBackColor = true;
            this.DisplayLogStatistiques.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DisplayLogStatistiques);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.error);
            this.Controls.Add(this.allowDateFin);
            this.Controls.Add(this.allowDateDebut);
            this.Controls.Add(this.filtre);
            this.Controls.Add(this.pageCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.objetCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateFin);
            this.Controls.Add(this.dateDebut);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.statusCombo);
            this.Controls.Add(this.actionCombo);
            this.Controls.Add(this.PanelLogConsole);
            this.Name = "LogMain";
            this.Size = new System.Drawing.Size(1101, 900);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelLogConsole;
        private System.Windows.Forms.ComboBox statusCombo;
        private System.Windows.Forms.ComboBox actionCombo;
        private System.Windows.Forms.ComboBox objetCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox pageCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button filtre;
        private System.Windows.Forms.CheckBox allowDateFin;
        private System.Windows.Forms.CheckBox allowDateDebut;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button DisplayLogStatistiques;
    }
}
