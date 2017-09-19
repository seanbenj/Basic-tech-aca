using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PappaBobs.Persistence
{
    public class OrderRepository
    {
        public static void CreateOrder(DTO.OrderDTO orderDTO)
        {
            var db = new PappaBobsDbEntities();


            var order = convertToEntity(orderDTO);
            db.Orders.Add(order);
            db.SaveChanges();
        }

        private static Order convertToEntity(DTO.OrderDTO orderDTO)
        {
            var order = new Order();

            order.orderId = orderDTO.orderId;
            order.Size = orderDTO.Size;
            order.Crust = orderDTO.Crust;
            order.Pepperoni = orderDTO.Pepperoni;
            order.Sausage = orderDTO.GreenPeppers;
            order.Onions = orderDTO.Onions;
            order.GreenPeppers = orderDTO.GreenPeppers;
            order.Name = orderDTO.Name;
            order.Address = orderDTO.Address;
            order.Phone = orderDTO.Phone;
            order.ZipCode = orderDTO.ZipCode;
            order.TotalCost = orderDTO.TotalCost;
            order.PaymentType = orderDTO.PaymentType;
            order.Completed = orderDTO.Completed;

            return order;
        }

        public static List<DTO.OrderDTO> GetOrders()
        {
            var db = new PappaBobsDbEntities();
            var orders = db.Orders.Where(p => p.Completed == false).ToList();
            var ordersDTO = convertToDTO(orders);
            return ordersDTO;
        }

        public static List<DTO.OrderDTO> convertToDTO(List<Order> orders)
        {
            var ordersDTO = new List<DTO.OrderDTO>();
            foreach (var order in orders)
            {
                var orderDTO = new DTO.OrderDTO();
                orderDTO.orderId = order.orderId;
                orderDTO.Name = order.Name;
                orderDTO.Address = order.Address;
                orderDTO.ZipCode = order.ZipCode;
                orderDTO.Phone = order.Phone;
                orderDTO.Crust = order.Crust;
                orderDTO.Size = order.Size;
                orderDTO.Pepperoni = order.Pepperoni;
                orderDTO.Sausage = order.Sausage;
                orderDTO.Onions = order.Onions;
                orderDTO.GreenPeppers = order.GreenPeppers;
                orderDTO.PaymentType = order.PaymentType;
                orderDTO.TotalCost = order.TotalCost;
                orderDTO.Completed = order.Completed;
                ordersDTO.Add(orderDTO);
            }
            return ordersDTO;
        }

        public static void CompleteOrder(Guid orderId)
        {
            var db = new PappaBobsDbEntities();

            var order = db.Orders.FirstOrDefault(p => p.orderId == orderId);
            order.Completed = true;
            db.SaveChanges();
        }
    }
}
