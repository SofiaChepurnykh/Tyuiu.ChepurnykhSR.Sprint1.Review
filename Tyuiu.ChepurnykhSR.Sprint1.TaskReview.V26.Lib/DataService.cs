using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ChepurnykhSR.Sprint1.TaskReview.V26.Lib
{
    public class DataService : ISprint1Task7V26
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Round((((Math.Sin(x * x) + y) / (y + 1)) - (((x * y) - 12) / (34 + (x * x)))),3);
            return res;
        }
    }
}
