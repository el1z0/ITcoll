using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string? Login { get; set; }
        public Guid? Password { get; set; }
        public string? Fio { get; set; }
        public byte[]? Photo { get; set; }
    }
}
