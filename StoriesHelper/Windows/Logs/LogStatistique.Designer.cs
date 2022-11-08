
namespace StoriesHelper.Windows.Logs
{
    partial class LogStatistique
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.LogStatistiques = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.TOTAL = new System.Windows.Forms.Label();
            this.INFO = new System.Windows.Forms.Label();
            this.IMPORTANT = new System.Windows.Forms.Label();
            this.WARNING = new System.Windows.Forms.Label();
            this.ERROR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogStatistiques)).BeginInit();
            this.SuspendLayout();
            // 
            // LogStatistiques
            // 
            this.LogStatistiques.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.LogStatistiques.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.LogStatistiques.Legends.Add(legend1);
            this.LogStatistiques.Location = new System.Drawing.Point(12, 180);
            this.LogStatistiques.Name = "LogStatistiques";
            this.LogStatistiques.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "LogStat";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.LogStatistiques.Series.Add(series1);
            this.LogStatistiques.Size = new System.Drawing.Size(469, 280);
            this.LogStatistiques.TabIndex = 0;
            this.LogStatistiques.Text = "Stats Des Tâches de l\'Organisation en cours";
            title1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Pourcentage des Logs par Status";
            this.LogStatistiques.Titles.Add(title1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pourcentage des Logs par Statut";
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSize = true;
            this.TOTAL.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTAL.Location = new System.Drawing.Point(197, 77);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(67, 19);
            this.TOTAL.TabIndex = 2;
            this.TOTAL.Text = "TOTAL : ";
            // 
            // INFO
            // 
            this.INFO.AutoSize = true;
            this.INFO.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INFO.Location = new System.Drawing.Point(39, 112);
            this.INFO.Name = "INFO";
            this.INFO.Size = new System.Drawing.Size(56, 19);
            this.INFO.TabIndex = 3;
            this.INFO.Text = "INFO : ";
            // 
            // IMPORTANT
            // 
            this.IMPORTANT.AutoSize = true;
            this.IMPORTANT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMPORTANT.Location = new System.Drawing.Point(39, 158);
            this.IMPORTANT.Name = "IMPORTANT";
            this.IMPORTANT.Size = new System.Drawing.Size(106, 19);
            this.IMPORTANT.TabIndex = 4;
            this.IMPORTANT.Text = "IMPORTANT : ";
            // 
            // WARNING
            // 
            this.WARNING.AutoSize = true;
            this.WARNING.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WARNING.Location = new System.Drawing.Point(306, 112);
            this.WARNING.Name = "WARNING";
            this.WARNING.Size = new System.Drawing.Size(92, 19);
            this.WARNING.TabIndex = 5;
            this.WARNING.Text = "WARNING : ";
            // 
            // ERROR
            // 
            this.ERROR.AutoSize = true;
            this.ERROR.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ERROR.Location = new System.Drawing.Point(306, 158);
            this.ERROR.Name = "ERROR";
            this.ERROR.Size = new System.Drawing.Size(70, 19);
            this.ERROR.TabIndex = 6;
            this.ERROR.Text = "ERROR : ";
            // 
            // LogStatistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 472);
            this.Controls.Add(this.ERROR);
            this.Controls.Add(this.WARNING);
            this.Controls.Add(this.IMPORTANT);
            this.Controls.Add(this.INFO);
            this.Controls.Add(this.TOTAL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogStatistiques);
            this.Name = "LogStatistique";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogStatistique";
            ((System.ComponentModel.ISupportInitialize)(this.LogStatistiques)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart LogStatistiques;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TOTAL;
        private System.Windows.Forms.Label INFO;
        private System.Windows.Forms.Label IMPORTANT;
        private System.Windows.Forms.Label WARNING;
        private System.Windows.Forms.Label ERROR;
    }
}