namespace Api.Services.Infrastructure.Constants
{
    using Api.Domain.Enums;
    using System.Collections.Generic;

    public class ProductMovementsConstants
    {
        public static ICollection<ProductMovementType> NegativeMovements = new List<ProductMovementType>()
        {
            ProductMovementType.Sale,
            
            ProductMovementType.PurchaseCorrection,

            ProductMovementType.CorrectionNegative

        };
    }
}
