using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Prestadore
    {
        public int Idprestador { get; set; }
        public long Idparticipante { get; set; }
        public long Idcattipoparticipante { get; set; }
        public long Idcatprestadorservicio { get; set; }
        public string Idregulatorio { get; set; } = null!;
        public string Nombreregulatorio { get; set; } = null!;
        public string Nombrecorto { get; set; } = null!;
        public string Nombrelargo { get; set; } = null!;
        public long Orden { get; set; }
        public bool Status { get; set; }
        public string? Idsubtipoentidad { get; set; }
        public string? Descsubtipoentidad { get; set; }

        public virtual Cattipoprestadorservicio IdcatprestadorservicioNavigation { get; set; } = null!;
        public virtual Cattipoparticipante IdcattipoparticipanteNavigation { get; set; } = null!;
        public virtual Participante IdparticipanteNavigation { get; set; } = null!;
    }
}
