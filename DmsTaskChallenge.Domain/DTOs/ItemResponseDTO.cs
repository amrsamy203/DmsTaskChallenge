using DmsTaskChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DmsTaskChallenge.Domain.DTOs
{
    public class ItemResponseDTO
    {
        public string Description { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }
        public Uom Uom { get; set; }
    }
}
