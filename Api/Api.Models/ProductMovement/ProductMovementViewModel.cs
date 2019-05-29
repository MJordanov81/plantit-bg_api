namespace Api.Models.ProductMovement
{
    using Api.Common.Mapping;
    using System;
    using Api.Domain.Entities;
    using AutoMapper;

    public class ProductMovementViewModel : IMapFrom<ProductMovement>, IHaveCustomMapping
    {
        public string Id { get; set; }

        public int MovementType { get; set; }

        public int Quantity { get; set; }

        public string Comment { get; set; }

        public string ProductId { get; set; }

        public DateTime TimeStamp { get; set; }

        public void ConfigureMapping(Profile mapper)
        {
            mapper.CreateMap<ProductMovement, ProductMovementViewModel>()
                .ForMember(m => m.MovementType, cfg => cfg.MapFrom(pm => (int)pm.MovementType));
        }
    }
}
