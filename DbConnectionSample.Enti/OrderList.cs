using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RentalManagement
{
    public class OrderList
    {
        public int OrderID { get; set; }
        public int Username { get; set; }
        public int GameID { get; set; }
        public int TransectionID { get; set; }
        public int Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string Status { get; set; }

            
    }
}
