using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PapaBobsChal.DTO;

namespace PapaBobsChal.Domain
{
    public class PizzaPriceManager
    {
        public static DTO.PizzaPriceDTO GetPizzaPrices()
        {
            return Persistence.PizzaPriceRepository.GetPizzaPrices();
        }

        public static decimal CalculatePizzaPrice(OrderDTO orderDTO)
        {
            decimal totalCost = 0M;
            totalCost += calculateSizePrice(orderDTO);
            totalCost += calculateCrustPrice(orderDTO);
            totalCost += calculateToppingsPrice(orderDTO);
            return totalCost;
        }

        private static decimal calculateToppingsPrice(OrderDTO orderDTO)
        {
            var toppingsCost = 0M;
            var prices = GetPizzaPrices();
            toppingsCost += (orderDTO.GreenPeppers) ? prices.GreenPeppersCost : 0M;
            toppingsCost += (orderDTO.Onions) ? prices.OnionsCost : 0M;
            toppingsCost += (orderDTO.Pepperoni) ? prices.PepperoniCost : 0M;
            toppingsCost += (orderDTO.Sausage) ? prices.SausageCost : 0M;
            return toppingsCost;
        }

        private static decimal calculateCrustPrice(OrderDTO orderDTO)
        {
            var crustCost = 0M;
            var prices = GetPizzaPrices();
            switch (orderDTO.Crust)
            {
                case DTO.Enums.CrustTypes.Regular:
                    crustCost += prices.RegularCrustCost;
                    break;
                case DTO.Enums.CrustTypes.Thin:
                    crustCost += prices.ThinCrustCost;
                    break;
                case DTO.Enums.CrustTypes.Thick:
                    crustCost += prices.ThickCrustCost;
                    break;
                default:
                    crustCost += 0M;
                    break;
            }
            return crustCost;
        }

        private static decimal calculateSizePrice(OrderDTO orderDTO)
        {
            var sizeCost = 0M;
            var prices = GetPizzaPrices();
            switch (orderDTO.Size)
            {
                case DTO.Enums.SizeTypes.Small:
                    sizeCost += prices.SmallSizeCost;
                    break;
                case DTO.Enums.SizeTypes.Medium:
                    sizeCost += prices.MediumSizeCost;
                    break;
                case DTO.Enums.SizeTypes.Large:
                    sizeCost += prices.LargeSizeCost;
                    break;
                default:
                    sizeCost += 0M;
                    break;
            }
            return sizeCost;
        }
    }
}
