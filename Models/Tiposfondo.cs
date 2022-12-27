using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Tiposfondo
    {
        public Tiposfondo()
        {
            Fondos = new HashSet<Fondo>();
        }

        public long Idtipofondo { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Fondo> Fondos { get; set; }
    }
}
