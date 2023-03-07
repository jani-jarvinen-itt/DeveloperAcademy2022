using System;
using System.Collections.Generic;

namespace NorthwindCustomersToAdventureWorks.AdventureModels;

/// <summary>
/// Tracking event lookup table.
/// </summary>
public partial class TrackingEvent
{
    /// <summary>
    /// Primary key.
    /// </summary>
    public int TrackingEventId { get; set; }

    /// <summary>
    /// Tracking event name.
    /// </summary>
    public string EventName { get; set; } = null!;
}
