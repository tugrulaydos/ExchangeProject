using Exchange.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Entity.Entities
{
    public class UserSetting:EntityBase
    {
        public string Color { get; set; }

        public string Font { get; set; }

        public AppUser User { get; set; }


        
    }
}
