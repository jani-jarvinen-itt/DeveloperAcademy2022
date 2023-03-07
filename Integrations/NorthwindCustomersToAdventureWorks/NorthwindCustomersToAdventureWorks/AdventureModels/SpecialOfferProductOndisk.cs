using System;
using System.Collections.Generic;

namespace NorthwindCustomersToAdventureWorks.AdventureModels;

public partial class SpecialOfferProductOndisk
{
    public int SpecialOfferId { get; set; }

    public int ProductId { get; set; }

    public DateTime ModifiedDate { get; set; }

    public virtual ProductOndisk Product { get; set; } = null!;

    public virtual ICollection<SalesOrderDetailOndisk> SalesOrderDetailOndisks { get; } = new List<SalesOrderDetailOndisk>();

    public virtual SpecialOfferOndisk SpecialOffer { get; set; } = null!;
}
