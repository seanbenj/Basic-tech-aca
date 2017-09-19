using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PappaBobs.DTO;

namespace PappaBobs.Domain
{
    public class OrderManager
    {
        public static void CreateOrder(DTO.OrderDTO orderDTO)
        {

            orderDTO.orderId = Guid.NewGuid();
            orderDTO.TotalCost = PizzaPriceManager.CalculatePizzaCost(orderDTO);

            Persistence.OrderRepository.CreateOrder(orderDTO);
        }

        public static object GetOrders()
        {
            return Persistence.OrderRepository.GetOrders();
        }

        public static void CompleteOrder(Guid orderId)
        {
            Persistence.OrderRepository.CompleteOrder(orderId);
        }
    }
}
