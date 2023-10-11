using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KomarovMI.Sprint1.Task6.V7.Lib
{
    public class DataService : ISprint1Task6V7
    {
        public string DeleteLastLetter(string value)
        {
            value = value.Remove(value.Length-1,1);
            return value;
        }
    }
}
