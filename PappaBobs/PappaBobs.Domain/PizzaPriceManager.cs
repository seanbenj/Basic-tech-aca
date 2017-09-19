using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PappaBobs.DTO;

namespace PappaBobs.Domain
{
    public class PizzaPriceManager
    {
        public static decimal CalculatePizzaCost(DTO.OrderDTO order)
        {

            decimal Cost = 0.0M;

            var prices = getPizzaPrices();
            Cost += calculateSizeCost(order, prices);
            Cost += calculateCrustCost(order, prices);
            Cost += CalculateToppingsCost(order, prices);

            return Cost;
        }

        private static decimal CalculateToppingsCost(OrderDTO order, DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;

            cost += (order.Sausage) ? prices.SausageCost : 0M;
            cost += (order.Pepperoni) ? prices.PepperoniCost : 0M;
            cost += (order.Onions) ? prices.OnionCost : 0M;
            cost += (order.GreenPeppers) ? prices.GreenPeppersCost : 0M;

            return cost;
        }

        private static decimal calculateCrustCost(OrderDTO order, DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;

            switch (order.Crust)
            {
                case DTO.Enums.CrustType.Regular:
                    cost = prices.RegularCrustCost;
                    break;
                case DTO.Enums.CrustType.Thin:
                    cost = prices.ThinCrustCost;
                    break;
                case DTO.Enums.CrustType.Thick:
                    cost = prices.ThickCrustCost;
                    break;
                default:
                    break;
            }

            return cost;
        }

        private static decimal calculateSizeCost(OrderDTO order, DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;

            switch (order.Size)
            {
                case DTO.Enums.SizeType.Small:
                    cost = prices.SmallSizeCost;
                    break;
                case DTO.Enums.SizeType.Medium:
                    cost = prices.MediumSizeCost;
                    break;
                case DTO.Enums.SizeType.Large:
                    cost = prices.LargeSizeCost;
                    break;
                default:
                    break;
            }

            return cost;
        }

        private static DTO.PizzaPriceDTO getPizzaPrices()
        {
            var prices = Persistence.PizzaPriceRepository.GetPizzaPrices();
            return prices;
        }
    }
}