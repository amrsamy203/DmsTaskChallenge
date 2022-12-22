using DmsTaskChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DmsTaskChallenge.Domain.DTOs
{
    public class ItemRequestDTO
    {
        public string Description { get; set; }
        [Required]
        public int Qty { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int UomId { get; set; }
    }
}
