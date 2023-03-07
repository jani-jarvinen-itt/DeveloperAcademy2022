using System;
using System.Collections.Generic;

namespace NorthwindCustomersToAdventureWorks.AdventureModels;

public partial class PersonTemporal
{
    public int BusinessEntityId { get; set; }

    public string PersonType { get; set; } = null!;

    public bool NameStyle { get; set; }

    public string? Title { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string? Suffix { get; set; }

    public int EmailPromotion { get; set; }
}
