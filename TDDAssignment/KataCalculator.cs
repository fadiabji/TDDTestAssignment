using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDAssignment
{
    public class KataCalculator
    {
        public int add(string numbers)
        {
            if (numbers == "")
                        return 0;
            
            else if (numbers.Length == 0) 
            {
                int numericValue;
                bool IsNumber = int.TryParse(numbers, out numericValue);
                
                if (IsNumber)
                {
                    return numericValue;
                }
                return 0;
            }
            else if (numbers.Length > 0)
            {
                string[] numbersArray = numbers.Split(',');
                List<int> intsList = new List<int>();
                foreach (string n in numbersArray)
                {
                    int numericValue;
                    bool IsNumber = int.TryParse(n, out numericValue);
                    if (IsNumber)
                    {
                        intsList.Add(numericValue);
                    }
                    else
                    {
                        intsList.Add(0);
                    }
                }
                int sumResult = intsList.AsQueryable().Sum();
                return sumResult;
            }
            else
                return 0;
            
        }
    }
}
