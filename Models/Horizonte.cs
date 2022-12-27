using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Horizonte
    {
        public Horizonte()
        {
            Fondos = new HashSet<Fondo>();
        }

        public long Idhorizonte { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Fondo> Fondos { get; set; }
    }
}
