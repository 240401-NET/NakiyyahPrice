using System;
using System.Collections.Generic;

namespace P1;

public partial class Model
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Grade { get; set; }

    public string? Type { get; set; }

    public string? Status { get; set; }

    public string? Description { get; set; }
}
