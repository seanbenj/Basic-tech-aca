using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PappaBobs.DTO
{
    public class OrderDTO
    {
        public System.Guid orderId { get; set; }
        public PappaBobs.DTO.Enums.SizeType Size { get; set; }
        public PappaBobs.DTO.Enums.CrustType Crust { get; set; }
        public bool Pepperoni { get; set; }
        public bool GreenPeppers { get; set; }
        public bool Sausage { get; set; }
        public bool Onions { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public PappaBobs.DTO.Enums.PaymentType PaymentType { get; set; }
        public decimal TotalCost { get; set; }
        public bool Completed { get; set; }
    }
}
