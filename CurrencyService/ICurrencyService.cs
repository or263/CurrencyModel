using CurrencyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyService
{
    [ServiceContract]
    internal interface ICurrencyService
    {
        [OperationContract]
        CurrencyList GetAllCurrencies();

        [OperationContract]
        double Convert(Currency source, Currency target, double amount);
    }
}
