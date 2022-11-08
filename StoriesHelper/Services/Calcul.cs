using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoriesHelper.Services
{
    public class Calcul
    {
        public static double CalculateRatioTasks(int open, int total)
        {
            double ratio = 0;
            if (total != 0)
            {
                double percentage = ((float)open / total) * 100;
                ratio = Math.Round(percentage, 2);
                return ratio;
            }
            return 0;
        }
    }
}
