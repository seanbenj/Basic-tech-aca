using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PappaBobs.Persistence
{
    public class PizzaPriceRepository
    {
        public static DTO.PizzaPriceDTO GetPizzaPrices()
        {
            var db = new PappaBobsDbEntities();
            var prices = db.PizzaPrices.First();
            var dto = convertToDTO(prices);
            return dto;
        }

        public static DTO.PizzaPriceDTO convertToDTO(PizzaPrice pizzaPrice)
        {
            var pizzaPriceDTO = new DTO.PizzaPriceDTO();

            pizzaPriceDTO.SmallSizeCost = pizzaPrice.SmallSizeCost;
            pizzaPriceDTO.MediumSizeCost = pizzaPrice.MediumSizeCost;
            pizzaPriceDTO.LargeSizeCost = pizzaPrice.LargeSizeCost;
            pizzaPriceDTO.RegularCrustCost = pizzaPrice.RegularCrustCost;
            pizzaPriceDTO.ThinCrustCost = pizzaPrice.ThinCrustCost;
            pizzaPriceDTO.ThickCrustCost = pizzaPrice.ThickCrustCost;
            pizzaPriceDTO.PepperoniCost = pizzaPrice.PepperoniCost;
            pizzaPriceDTO.SausageCost = pizzaPrice.SausageCost;
            pizzaPriceDTO.OnionCost = pizzaPrice.OnionCost;
            pizzaPriceDTO.GreenPeppersCost = pizzaPrice.GreenPeppersCost;
            return pizzaPriceDTO;
        }
    }
}
