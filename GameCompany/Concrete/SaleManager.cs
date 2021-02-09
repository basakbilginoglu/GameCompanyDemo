using GameCompany.Abstract;
using GameCompany.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany.Concrete
{
    class SaleManager : ISaleService
    {
        public void AddSale(Sale sale, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("Satış gerçekleşti");
            Console.WriteLine("Satın alan kişi:"+ gamer.FirstName+" "+gamer.LastName);
            Console.WriteLine("Satın alınan oyunun adı: "+ sale.SoldGameName);
            Console.WriteLine("Satın alınılan oyunun fiyatı:"+ sale.SoldGamePrice);
            Console.WriteLine("uygulanan kampanya:"+ campaign.CampaignName);
        }

        public void CancelSale(Sale sale, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("Satışiptal edildi");
        }

        public void UpdateSale(Sale sale, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("Satış güncellendi");
        }
    }
}
