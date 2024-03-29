﻿using System;
using System.Collections.Generic;

namespace NorthwindCustomersToAdventureWorks.AdventureModels;

/// <summary>
/// Individual tracking events associated with a specific sales order.
/// </summary>
public partial class OrderTracking
{
    /// <summary>
    /// Primary key.
    /// </summary>
    public int OrderTrackingId { get; set; }

    /// <summary>
    /// Sales order identification number.  Foreign key to SalesOrderHeader.SalesOrderID.
    /// </summary>
    public int SalesOrderId { get; set; }

    /// <summary>
    /// Shipment tracking number supplied by the shipper.
    /// </summary>
    public string? CarrierTrackingNumber { get; set; }

    /// <summary>
    /// Tracking delivery event for Order shipped to customer. Foreign key to TrackingEvent.TrackingEventID.
    /// </summary>
    public int TrackingEventId { get; set; }

    /// <summary>
    /// Details for a delivery tracking event.
    /// </summary>
    public string EventDetails { get; set; } = null!;

    /// <summary>
    /// The date and time that a tracking event has occurred.
    /// </summary>
    public DateTime EventDateTime { get; set; }
}
