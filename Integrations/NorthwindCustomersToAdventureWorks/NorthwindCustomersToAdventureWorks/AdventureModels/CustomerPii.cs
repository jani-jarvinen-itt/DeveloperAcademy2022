using System;
using System.Collections.Generic;

namespace NorthwindCustomersToAdventureWorks.AdventureModels;

public partial class CustomerPii
{
    public int CustomerId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Ssn { get; set; }

    public string? CreditCardNumber { get; set; }

    public string? EmailAddress { get; set; }

    public string? PhoneNumber { get; set; }

    public int? TerritoryId { get; set; }
}
