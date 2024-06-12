using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Colour
    {
        

        public int? Id { get; set; }
        public string? Kod { get; set; }
        public string NameColor { get; set; } = null!;

    }
}
