using System;
using System.Collections.Generic;

namespace NorthwindCustomersToAdventureWorks.AdventureModels;

public partial class VEmployeePersonTemporalInfo
{
    public int BusinessEntityId { get; set; }

    public string? Title { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string JobTitle { get; set; } = null!;

    public string MaritalStatus { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public short VacationHours { get; set; }

    public short SickLeaveHours { get; set; }
}
