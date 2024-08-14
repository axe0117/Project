using System;
using System.Collections.Generic;

namespace Project.Models;

public partial class Patient
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public string? Gender { get; set; }

    public string? Phone { get; set; }

    public string? EmergencyContact { get; set; }

    public int HospitalId { get; set; }

    public virtual Hospital Hospital { get; set; } = null!;
}
