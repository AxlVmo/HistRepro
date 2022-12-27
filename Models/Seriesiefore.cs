using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Seriesiefore
    {
        public long Idseriesiefore { get; set; }
        public string Idtipovalor { get; set; } = null!;
        public long Idsiefore { get; set; }
        public string Seriesiefore1 { get; set; } = null!;
        public decimal? Valornominal { get; set; }
        public decimal? Comision { get; set; }
        public long? Idtiposerie { get; set; }
        public decimal? Capitalfijosinderec { get; set; }
        public decimal Reservaespecial { get; set; }
        public decimal Accionestrabajo { get; set; }
        public bool? Borradologico { get; set; }

        public virtual Siefore IdsieforeNavigation { get; set; } = null!;
    }
}
