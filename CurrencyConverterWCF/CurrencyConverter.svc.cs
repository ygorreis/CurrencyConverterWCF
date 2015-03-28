using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CurrencyConverterWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CurrencyConverter" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CurrencyConverter.svc or CurrencyConverter.svc.cs at the Solution Explorer and start debugging.
    public class CurrencyConverter : ICurrencyConverter
    {

        public string getValueOfConvertedCurrency(string valCurrencyOne, string valCurrencyTwo, string amountToConvert)
        {
            Double valCurrencyOneDouble = 0, valCurrencyTwoDouble = 0, amountToConvertDouble = 0, showValue = 0;
            String valueConverted = "Value Not Available";

            if (!String.IsNullOrEmpty(valCurrencyOne) && !String.IsNullOrEmpty(valCurrencyTwo) && !String.IsNullOrEmpty(amountToConvert))
            {

                try
                {
                    valCurrencyOneDouble = Convert.ToDouble(valCurrencyOne);
                    valCurrencyTwoDouble = Convert.ToDouble(valCurrencyTwo);
                    amountToConvertDouble = Convert.ToDouble(amountToConvert);
                }
                catch (Exception e)
                {
                    valueConverted = "Some value is alphabetic characters. Please, use only numbers.";
                }
                showValue = Math.Round(((amountToConvertDouble * valCurrencyOneDouble) / valCurrencyTwoDouble),2);
                valueConverted = Convert.ToString(showValue);
            }
            else
            {
                valueConverted = "Some value is empty. Please, fix it!";
            }
            return valueConverted;
        }
    }
}
