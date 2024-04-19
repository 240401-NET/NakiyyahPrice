using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P1;
[Table("Status")]
public class Status
{
    public int Id { get; set; }

    public string? Status1 { get; set; }

}
