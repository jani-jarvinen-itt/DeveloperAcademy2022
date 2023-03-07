using System;
using System.Collections.Generic;

namespace NorthwindCustomersToAdventureWorks.AdventureModels;

public partial class SpecialOfferProductInmem
{
    public int SpecialOfferId { get; set; }

    public int ProductId { get; set; }

    public DateTime ModifiedDate { get; set; }

    public virtual ProductInmem Product { get; set; } = null!;

    public virtual ICollection<SalesOrderDetailInmem> SalesOrderDetailInmems { get; } = new List<SalesOrderDetailInmem>();

    public virtual SpecialOfferInmem SpecialOffer { get; set; } = null!;
}
