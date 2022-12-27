using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Tiposociedadesinversion
    {
        public long Idtiposociedadinversion { get; set; }
        public long? Claveentidad { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Razonsocial { get; set; } = null!;
        public long? Subtipoentidad { get; set; }
        public long? Tipoentidad { get; set; }
    }
}
