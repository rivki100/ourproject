using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectR_B.Repositories.Entities
{
    internal class Payment
    {
        public int PaymentId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public int Sum { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
