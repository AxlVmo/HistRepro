using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Cattipoprestadorservicio
    {
        public Cattipoprestadorservicio()
        {
            Prestadores = new HashSet<Prestadore>();
        }

        public long Idcatprestadorservicio { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Prestadore> Prestadores { get; set; }
    }
}
