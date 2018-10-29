using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {
            double convertedNumber;
            if (!double.TryParse(argTextInput, out convertedNumber)) throw new ArgumentException("Expected a numeric value.");
            return convertedNumber;

            //try
            //{
            //    int convertedNum;
            //    bool isConvertedSuccessfully = int.TryParse(input, out convertedNum);

            //    if (!isConvertedSuccessfully)
            //    {
            //        throw new Exception("Conversion not successful.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw;
            //}
        }
    }
}
