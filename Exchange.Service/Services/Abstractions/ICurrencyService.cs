
using Exchange.Entity.ApiModels.Currencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Service.Services.Abstractions
{
    public interface ICurrencyService
    {
        Task<GoldCurrencyAndDateModel> GetCurrenciesWithDate();
        Task<List<GoldCurrencyModel>> GetCurrencies();

    }
}
