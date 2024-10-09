using System;
using System.Collections.Generic;

namespace MVCBasics.Model;

public partial class Student
{
    public int Rno { get; set; }

    public string? Name { get; set; }

    public int? Mark1 { get; set; }

    public int? Mark2 { get; set; }

    public int? Average { get; set; }

    public int? Rank { get; set; }
}
