using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Models
{
    public class Slider : BaseEntity
    {
        public string SaleTitle { get; set; }
        public string Sale { get; set; }
        public string MainTitle { get; set; }
        public string Description { get; set; }
        public string PriceTitle { get; set; }
        public string Price { get; set; }
        public string BtnTitle { get; set; }
        public string Image { get; set; }


    }
}
