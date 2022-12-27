using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Comitevaluacion
    {
        public long Id { get; set; }
        public string Firmante1 { get; set; } = null!;
        public string? Firmante2 { get; set; }
        public string? Firmante3 { get; set; }
    }
}
