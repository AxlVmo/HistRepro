using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Tiposoperacion
    {
        public Tiposoperacion()
        {
            Siefores = new HashSet<Siefore>();
        }

        public long Idtipooperacion { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Siefore> Siefores { get; set; }
    }
}
