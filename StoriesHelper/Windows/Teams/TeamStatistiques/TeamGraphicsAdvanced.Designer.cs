
namespace StoriesHelper.Windows.Teams.TeamStatistiques
{
    partial class TeamGraphicsAdvanced
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.TeamGraphics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.TeamGraphics)).BeginInit();
            this.SuspendLayout();
            // 
            // TeamGraphics
            // 
            this.TeamGraphics.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.TeamGraphics.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.TeamGraphics.Legends.Add(legend1);
            this.TeamGraphics.Location = new System.Drawing.Point(-24, -16);
            this.TeamGraphics.Name = "TeamGraphics";
            this.TeamGraphics.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.TeamGraphics.Size = new System.Drawing.Size(1098, 466);
            this.TeamGraphics.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Avancé des tâches en pourcentage en 2 semaines";
            title1.Text = "Avancée des tâches en pourcentage des deux dernières semaines";
            this.TeamGraphics.Titles.Add(title1);
            // 
            // TeamGraphicsAdvanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TeamGraphics);
            this.Name = "TeamGraphicsAdvanced";
            this.Size = new System.Drawing.Size(1077, 450);
            ((System.ComponentModel.ISupportInitialize)(this.TeamGraphics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart TeamGraphics;
    }
}
