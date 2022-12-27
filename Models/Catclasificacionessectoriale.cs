using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Catclasificacionessectoriale
    {
        public Catclasificacionessectoriale()
        {
            Emisores = new HashSet<Emisore>();
        }

        public int Idclasificacionsectorial { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Emisore> Emisores { get; set; }
    }
}
