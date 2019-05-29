namespace Api.Models.ProductMovement
{
    using Api.Domain.Enums;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class ProductMovementCreateModel
    {
        [Required]
        [Range(minimum: 0, maximum: int.MaxValue)]
        public int MovementType { get; set; }

        [Required]
        [Range(minimum: 0, maximum: int.MaxValue)]
        public int Quantity { get; set; }

        public string Comment { get; set; }

        [Required]
        public string ProductId { get; set; }

        public DateTime? TimeStamp { get; set; }
    }
}
