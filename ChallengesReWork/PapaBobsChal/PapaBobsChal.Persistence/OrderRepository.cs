using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PapaBobsChal.DTO;

namespace PapaBobsChal.Persistence
{
    public class OrderRepository
    {
        public static void CreateOrder (DTO.OrderDTO orderDTO)
        {
            PapaBobsChalDbEntities Db = new PapaBobsChalDbEntities();

            var order = convertToEntity(orderDTO);
            Db.Orders.Add(order);
            Db.SaveChanges();
        }

        public static List<DTO.OrderDTO> GetOrders ()
        {
            PapaBobsChalDbEntities Db = new PapaBobsChalDbEntities();
            var orders = Db.Orders.Where(p => p.Completed == false).ToList();
            var ordersDTO = convertToDTO(orders);
            return ordersDTO;
        }

        public static void CompleteOrder(OrderDTO order)
        {
            PapaBobsChalDbEntities Db = new PapaBobsChalDbEntities();
            var completedOrder = convertToEntity(order);
            var incompleteOrder = Db.Orders.Single(p => p.OrderId == completedOrder.OrderId);
            Db.Orders.Remove(incompleteOrder);
            Db.Orders.Add(completedOrder);
            Db.SaveChanges();
        }

        private static List<DTO.OrderDTO> convertToDTO (List<Order> orders)
        {
            var ordersDTO = new List<OrderDTO>();
            var orderDTO = new DTO.OrderDTO();
            foreach (var order in orders)
            {
                orderDTO.OrderId = order.OrderId;
                orderDTO.Pepperoni = order.Pepperoni;
                orderDTO.Sausage = order.Sausage;
                orderDTO.Onions = order.Onions;
                orderDTO.GreenPeppers = order.GreenPeppers;
                orderDTO.Crust = order.Crust;
                orderDTO.Size = order.Size;
                orderDTO.Name = order.Name;
                orderDTO.Address = order.Address;
                orderDTO.Zip = order.Zip;
                orderDTO.Phone = order.Phone;
                orderDTO.TotalCost = order.TotalCost;
                orderDTO.Payment = order.Payment;
                orderDTO.Completed = order.Completed;
                ordersDTO.Add(orderDTO);
            }
            return ordersDTO;
        }

        private static Order convertToEntity(OrderDTO orderDTO)
        {
            Order order = new Order();
            order.OrderId = orderDTO.OrderId;
            order.Size = orderDTO.Size;
            order.Crust = orderDTO.Crust;
            order.Pepperoni = orderDTO.Pepperoni;
            order.Sausage = orderDTO.Sausage;
            order.Onions = orderDTO.Onions;
            order.GreenPeppers = orderDTO.GreenPeppers;
            order.Name = orderDTO.Name;
            order.Address = orderDTO.Address;
            order.Zip = orderDTO.Zip;
            order.Phone = orderDTO.Phone;
            order.TotalCost = orderDTO.TotalCost;
            order.Completed = orderDTO.Completed;
            return order;
        }


    }
}
