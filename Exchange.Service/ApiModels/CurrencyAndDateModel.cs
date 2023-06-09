using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Service.ApiModels
{
    public class CurrencyAndDateModel
    {
        public List<CurrencyModel> _currencies { get; set; } = new List<CurrencyModel>();

        public string Update_Date { get; set; }

    }
}
