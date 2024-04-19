using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P1;
[Table("Grade")]
public class Grade
{
    public int Id { get; set; }

    public string? Grade1 { get; set; }

}
