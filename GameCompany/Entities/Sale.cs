using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany.Entities
{
    public class Sale
    {
        public int  Id { get; set; }
        public int GamerId { get; set; }
        public string GamerLastName { get; set; }
        public string SoldGameName { get; set; }
        public double SoldGamePrice { get; set; }
    }
}
