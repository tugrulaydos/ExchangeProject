using Exchange.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Entity.Entities
{
    public class EmailTransaction:EntityBase
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public AppUser User { get; set; }
        public Guid UserID { get; set; }
    }
}
