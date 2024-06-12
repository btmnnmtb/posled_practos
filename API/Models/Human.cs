using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Human
    {
        public int Id { get; set; }
        public string NameMan { get; set; } = null!;
        public int? ColorId { get; set; }

       
    }
}
