using Exchange.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Entity.Entities
{
    public class AppUser:IdentityUser<Guid>,IEntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }        
        public string IdentityNumber { get; set; }
        public List<Image> images { get; set; }
        public UserSetting userSetting { get; set; }
        public Guid UserSettingID { get; set; }
        

    }
}
