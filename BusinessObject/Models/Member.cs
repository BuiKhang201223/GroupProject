﻿using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class Member
{
    public int MemberId { get; set; }

    public string? MemberName { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }
}