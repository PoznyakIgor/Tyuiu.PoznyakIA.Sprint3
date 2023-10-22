using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PoznyakIA.Sprint3.Task3.V28.Lib
{
    public class DataService : ISprint3Task3V28
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            foreach (char chr in value)
            {
                {
                    if (chr == '3')
                    {
                        value = value.Replace(chr, item);

                    }
                    if (chr == '4')
                    {
                        value = value.Replace(chr, item);

                    }
                    if (chr == '5')
                    {
                        value = value.Replace(chr, item);

                    }
                }
            }
            return value;
        }
    }
}
