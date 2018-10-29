using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();

                int convertedNum;
                bool isConvertedSuccessfully = int.TryParse(input, out convertedNum);

                if (!isConvertedSuccessfully)
                {
                    throw new Exception("Conversion not successful.");
                }
            }
            catch (Exception ex) {
                Console.WriteLine("There was an error: {0}", ex.Message);
            }
            Console.WriteLine("The rest of my application is still running.");
        }
    }
}
