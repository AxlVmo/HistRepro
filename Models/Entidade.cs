using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Entidade
    {
        public long Claveentidad { get; set; }
        public string Descripcion { get; set; } = null!;
    }
}
