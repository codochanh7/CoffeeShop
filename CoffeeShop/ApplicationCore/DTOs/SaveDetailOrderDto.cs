using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.DTOs
{
    public class SaveDetailOrderDto
    {
        public int DetailOrderId { get; set; }
        public OrderDto OrderDto { get; set; }
        public int OrderId { get; set; }
        public MenuDto MenuDto { get; set; }
        public int MenuId { get; set; }
        [Column(TypeName = "numeric")]
        public int Quantity { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [DataType(DataType.Currency)]
        public decimal Total { get; set; }
    }
}