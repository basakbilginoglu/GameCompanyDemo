using GameCompany.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany.Abstract
{
    public interface ISaleService
    {
        void AddSale(Sale sale, Gamer gamer, Campaign campaign);
        void CancelSale(Sale sale, Gamer gamer, Campaign campaign);
        void UpdateSale(Sale sale, Gamer gamer, Campaign campaign);

    }
}
