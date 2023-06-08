using Exchange.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Entity.Entities
{
    public class DailyClosed:IEntityBase
    {
        public Guid ID { get; set; } = new Guid();
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public double CurrentUSD { get; set; }
        public double CurrentEuro { get; set; }
        public double CuurentPaund { get; set; }
        
    }
}
