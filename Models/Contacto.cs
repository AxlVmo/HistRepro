using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Contacto
    {
        public long Idcontacto { get; set; }
        public string Correo { get; set; } = null!;
        public long? Idtipoparticipacion { get; set; }
        public string Nombre { get; set; } = null!;
        public string Puesto { get; set; } = null!;
        public string? Telefono { get; set; }
        public long Idparticipante { get; set; }

        public virtual Participante IdparticipanteNavigation { get; set; } = null!;
    }
}
