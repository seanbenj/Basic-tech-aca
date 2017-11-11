using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobsChal.Persistence
{
    public class PizzaPriceRepository
    {
        public static DTO.PizzaPriceDTO GetPizzaPrices()
        {
            PapaBobsChalDbEntities Db = new PapaBobsChalDbEntities();
            var prices = Db.PizzaPrices.First();
            var DTOprices = convertToDTOPrices(prices);
            return DTOprices;
        }

        private static DTO.PizzaPriceDTO convertToDTOPrices(PizzaPrice prices)
        {
            var pizzaPriceDTO = new DTO.PizzaPriceDTO();
            pizzaPriceDTO.SmallSizeCost = prices.SmallSizeCost;
            pizzaPriceDTO.MediumSizeCost = prices.MediumSizeCost;
            pizzaPriceDTO.LargeSizeCost = prices.LargeSizeCost;
            pizzaPriceDTO.RegularCrustCost = prices.RegularCrustCost;
            pizzaPriceDTO.ThinCrustCost = prices.ThinCrustCost;
            pizzaPriceDTO.ThickCrustCost = prices.ThickCrustCost;
            pizzaPriceDTO.PepperoniCost = prices.PepperoniCost;
            pizzaPriceDTO.SausageCost = prices.SausageCost;
            pizzaPriceDTO.OnionsCost = prices.OnionsCost;
            pizzaPriceDTO.GreenPeppersCost = prices.GreenPeppersCost;
            return pizzaPriceDTO;
        }
    }
}
