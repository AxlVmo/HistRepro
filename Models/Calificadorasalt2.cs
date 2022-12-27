using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Calificadorasalt2
    {
        public Calificadorasalt2()
        {
            CalificadorasCalificaciones = new HashSet<CalificadorasCalificacione>();
        }

        public long IdCalificadora { get; set; }
        public string? NombrecCorto { get; set; }
        public string? NombreLargo { get; set; }
        public int? IdConsar { get; set; }
        public int? IdCnbv { get; set; }
        public string? Domicilio { get; set; }
        public int? EstatusRegistro { get; set; }
        public DateOnly? FechaRegistro { get; set; }
        public string? IdCasfim { get; set; }
        public DateOnly? FechaMidificacion { get; set; }

        public virtual Participante IdCalificadoraNavigation { get; set; } = null!;
        public virtual ICollection<CalificadorasCalificacione> CalificadorasCalificaciones { get; set; }
    }
}
