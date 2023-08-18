using System;
using System.Collections.Generic;

namespace UserJWT.Models;

public partial class Student
{
    public int Rollno { get; set; }

    public string StudentName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public long PhoneNumber { get; set; }
}
