﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.DTO
{
    public class MemberDTO
    {
        public int MemberId { get; set; }

        public string? MemberName { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? City { get; set; }
        public string? Country { get; set; }
    }
}
