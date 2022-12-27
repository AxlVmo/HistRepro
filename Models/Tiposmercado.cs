using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Tiposmercado
    {
        public Tiposmercado()
        {
            Emisores = new HashSet<Emisore>();
            Fondos = new HashSet<Fondo>();
            Siefores = new HashSet<Siefore>();
        }

        public int Idtipomercado { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Emisore> Emisores { get; set; }
        public virtual ICollection<Fondo> Fondos { get; set; }
        public virtual ICollection<Siefore> Siefores { get; set; }
    }
}
