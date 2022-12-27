using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Comisionessobresaldoafore
    {
        public long Idcomisionsaldoafore { get; set; }
        public decimal Porcentajecomision { get; set; }
        public long Sieforeid { get; set; }
        public DateTime? Anio { get; set; }
        public DateOnly? FechaInicio { get; set; }
        public DateOnly? FechaFin { get; set; }

        public virtual Siefore Siefore { get; set; } = null!;
    }
}
