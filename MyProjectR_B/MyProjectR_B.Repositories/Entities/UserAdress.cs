using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectR_B.Repositories.Entities
{
    internal class UserAdress
    {
        public int UserAdressId { get; set; }
        public int UserId { get; set; }
        public string UserCity { get; set; }
        public string UserStreet { get; set; }
        public int UserBuildingNumber { get; set; }
        public int UserBuildingEntrance { get; set; }
        public int UserZipCode { get; set; }

    }
}
