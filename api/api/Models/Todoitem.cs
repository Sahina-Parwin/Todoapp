using System;
using System.Collections.Generic;

namespace api.Models;

public partial class Todoitem
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime? Createdate { get; set; }

    public DateTime? Modifieddate { get; set; }

    public bool? Status { get; set; }
}
