using System;
using System.Collections.Generic;

namespace NorthwindCustomersToAdventureWorks.AdventureModels;

public partial class SpecialOfferOndisk
{
    public int SpecialOfferId { get; set; }

    public string Description { get; set; } = null!;

    public decimal DiscountPct { get; set; }

    public string Type { get; set; } = null!;

    public string Category { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int MinQty { get; set; }

    public int? MaxQty { get; set; }

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<SpecialOfferProductOndisk> SpecialOfferProductOndisks { get; } = new List<SpecialOfferProductOndisk>();
}
