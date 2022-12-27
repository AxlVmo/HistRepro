using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Tiposentidad
    {
        public long Idtipoentidad { get; set; }
        public string? Abreviacion { get; set; }
        public string Descripcion { get; set; } = null!;
    }
}
