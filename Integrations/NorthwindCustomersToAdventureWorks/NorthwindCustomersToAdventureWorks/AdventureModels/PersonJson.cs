using System;
using System.Collections.Generic;

namespace NorthwindCustomersToAdventureWorks.AdventureModels;

public partial class PersonJson
{
    public int PersonId { get; set; }

    public string PersonType { get; set; } = null!;

    public bool NameStyle { get; set; }

    public string? Title { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string? Suffix { get; set; }

    public int EmailPromotion { get; set; }

    public string? AdditionalContactInfo { get; set; }

    public string? Demographics { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
