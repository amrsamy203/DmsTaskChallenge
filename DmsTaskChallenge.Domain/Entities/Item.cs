using System;
using System.Collections.Generic;
using System.Text;

namespace DmsTaskChallenge.Domain.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }
        public Uom Uom { get; set; }
    }
}
