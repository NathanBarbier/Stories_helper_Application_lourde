using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoriesHelper.Repository;
using StoriesHelper.Services;

namespace StoriesHelper.Windows.Logs
{
    public partial class LogStatistique : Form
    {
        public LogStatistique()
        {
            InitializeComponent();

            LogHistoryRepository logHistoryRepository = new LogHistoryRepository();

            // On Récupère les nombres des logs par status de l'organisation
            int countTotal = logHistoryRepository.getCountByStatut(Session.UserId);
            int countInfo = logHistoryRepository.getCountByStatut(Session.UserId, "INFO");
            int countImportant = logHistoryRepository.getCountByStatut(Session.UserId, "IMPORTANT");
            int countWarning = logHistoryRepository.getCountByStatut(Session.UserId, "WARNING");
            int countError = logHistoryRepository.getCountByStatut(Session.UserId, "ERROR");

            // On calcule les pourcentages de chaque logStatus
            double ratioInfo = CalculateRatioLogs(countInfo, countTotal);
            double ratioImportant = CalculateRatioLogs(countImportant, countTotal);
            double ratioWarning = CalculateRatioLogs(countWarning, countTotal);
            double ratioError = CalculateRatioLogs(countError, countTotal);

            // On affiche dans les Label
            TOTAL.Text += countTotal.ToString();
            INFO.Text += countInfo.ToString() + " (" + ratioInfo.ToString() + "%)";
            IMPORTANT.Text += countImportant.ToString() + " (" + ratioImportant.ToString() + "%)";
            WARNING.Text += countWarning.ToString() + " (" + ratioWarning.ToString() + "%)";
            ERROR.Text += countError.ToString() + " (" + ratioError.ToString() + "%)";

            // On affiche les pourcentages dans le graphique
            LogStatistiques.Series["LogStat"].IsValueShownAsLabel = true;
            LogStatistiques.Series["LogStat"].Points.AddXY("INFO", ratioInfo);
            LogStatistiques.Series["LogStat"].Points.AddXY("IMPORTANT", ratioImportant);
            LogStatistiques.Series["LogStat"].Points.AddXY("WARNING", ratioWarning);
            LogStatistiques.Series["LogStat"].Points.AddXY("ERROR", ratioError);
        }

        private double CalculateRatioLogs(int log, int total)
        {
            double ratio = 0;
            if (total != 0)
            {
                double percentage = ((float)log / total) * 100;
                ratio = Math.Round(percentage, 2);
                return ratio;
            }
            return 0;
        }
    }
}
