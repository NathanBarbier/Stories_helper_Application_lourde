
namespace StoriesHelper.Windows.Teams.TeamStatistiques
{
    partial class TeamTaskGraphics
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TeamGraphicsStat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PanelTitreStatistique = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TeamGraphicsStat)).BeginInit();
            this.SuspendLayout();
            // 
            // TeamGraphicsStat
            // 
            this.TeamGraphicsStat.BackColor = System.Drawing.Color.Transparent;
            this.TeamGraphicsStat.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.None;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 20;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.AxisX.IsMarksNextToAxis = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.TeamGraphicsStat.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.TeamGraphicsStat.Legends.Add(legend1);
            this.TeamGraphicsStat.Location = new System.Drawing.Point(0, 2);
            this.TeamGraphicsStat.Margin = new System.Windows.Forms.Padding(2);
            this.TeamGraphicsStat.Name = "TeamGraphicsStat";
            this.TeamGraphicsStat.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Nombre de Tâches";
            this.TeamGraphicsStat.Series.Add(series1);
            this.TeamGraphicsStat.Size = new System.Drawing.Size(861, 408);
            this.TeamGraphicsStat.TabIndex = 0;
            this.TeamGraphicsStat.Text = "chart1";
            // 
            // PanelTitreStatistique
            // 
            this.PanelTitreStatistique.Location = new System.Drawing.Point(819, 43);
            this.PanelTitreStatistique.Name = "PanelTitreStatistique";
            this.PanelTitreStatistique.Size = new System.Drawing.Size(256, 367);
            this.PanelTitreStatistique.TabIndex = 1;
            // 
            // TeamTaskGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelTitreStatistique);
            this.Controls.Add(this.TeamGraphicsStat);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TeamTaskGraphics";
            this.Size = new System.Drawing.Size(1075, 408);
            ((System.ComponentModel.ISupportInitialize)(this.TeamGraphicsStat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart TeamGraphicsStat;
        private System.Windows.Forms.Panel PanelTitreStatistique;
    }
}
