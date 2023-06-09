using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Entity.ApiModels.Currencies
{
    public class GoldCurrencyAndDateModel
    {
        public List<GoldCurrencyModel> _currencies { get; set; } = new List<GoldCurrencyModel>();

        public string Update_Date { get; set; }

    }
}
