using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PoznyakIA.Sprint3.Task5.V19.Lib
{
    public class DataService : ISprint3Task5V19
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumService = 0;
            int i, j;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (i = startValue2; i <= stopValue2; i++)
                {
                    sumService = sumService + (Math.Pow((x) / (Math.Cos(x)), startValue1));
                }
            }
            return Math.Round(sumService, 3);
        }
    }
}
