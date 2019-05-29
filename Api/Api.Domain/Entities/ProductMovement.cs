using Api.Domain.Enums;
using System;

namespace Api.Domain.Entities
{
    public class ProductMovement
    {
        public string Id { get; set; }

        public ProductMovementType MovementType { get; set; }

        public int Quantity { get; set; }

        public string Comment { get; set; }

        public string ProductId { get; set; }

        public Product Product { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
