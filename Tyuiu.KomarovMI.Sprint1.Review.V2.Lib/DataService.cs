using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tyuiu.KomarovMI.Sprint1.Review.V2.Lib
{
    public class DataService 
    {
        public double Calculate(double x, double y)
        {
            double res = (Math.Sin(x) + Math.Cos(y)) / (Math.Cos(x) - Math.Sin(y)) * (Math.Tan(x * y));
            res = (Math.Round(res, 3));
            return res;
        }

    }
}
