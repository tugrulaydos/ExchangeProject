using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Core.Entities
{
    public class EntityBase:IEntityBase
    {
        public virtual Guid Id { get; set; } = Guid.NewGuid();
        public virtual string CreateBy { get; set; }
        public virtual DateTime CreatedDate { get; set; }
    }
}
