using Exchange.Service.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Service.Services.Abstractions
{
    public interface ICurrencyService
    {
        Task<CurrencyAndDateModel> GetCurrenciesWithDate();
        Task<List<CurrencyModel>> GetCurrencies();

    }
}
