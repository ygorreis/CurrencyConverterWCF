using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CurrencyConverterWCF
{
    [ServiceContract]
    interface ICurrencyConverter
    {
        [OperationContract]
        //[WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "getValueOfConvertedCurrency/?valCurrencyOne={valCurrencyOne}&valCurrencyTwo={valCurrencyTwo}&amountToConvert={amountToConvert}")]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "getValueOfConvertedCurrency/{valCurrencyOne}/{valCurrencyTwo}/{amountToConvert}")]
        //[WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "convert/valCurrencyOne/valCurrencyTwo/amountToConvert")]
        string getValueOfConvertedCurrency(string valCurrencyOne, string valCurrencyTwo, string amountToConvert);
    }
}
