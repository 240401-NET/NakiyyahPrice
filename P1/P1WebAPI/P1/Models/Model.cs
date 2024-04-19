using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace P1;
[Table("Models")]
public class Model
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? Grade { get; set; }

    public string? Type { get; set; }

    public int? Status { get; set; }

    public string? Description { get; set; }

}

public partial class Gunpla
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Grade { get; set; } = null!;

    public string? Type { get; set; }

    public string Status { get; set; } = null!;

    public string? Description { get; set; }


}