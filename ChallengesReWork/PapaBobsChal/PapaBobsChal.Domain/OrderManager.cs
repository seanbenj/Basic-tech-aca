using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobsChal.Domain
{
    public class OrderManager
    {
        public static void CreateOrder(DTO.OrderDTO orderDTO)
        {
            Persistence.OrderRepository.CreateOrder(orderDTO);
        }

        public static List<DTO.OrderDTO> GetOrders()
        {
            return Persistence.OrderRepository.GetOrders();             
        }

        public static void CompleteOrder(Guid guid)
        {
            var orders = GetOrders();
            DTO.OrderDTO order = orders.Single(p => p.OrderId == guid);
            order.Completed = true;
            Persistence.OrderRepository.CompleteOrder(order);
        }

        public static string textEmptyError(DTO.OrderDTO orderDTO)
        {
            string result = "";
            if (orderDTO.Address.Trim().Length == 0) result = "Please Enter a address.";
            if (orderDTO.Zip.Trim().Length == 0) result = "Please Enter a zip.";
            if (orderDTO.Phone.Trim().Length == 0) result = "Please Enter a phone number.";
            if (orderDTO.Name.Trim().Length == 0) result = "Please Enter a name.";         
            return result;
        }
    }
}
