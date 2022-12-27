using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Cattipoparticipante
    {
        public Cattipoparticipante()
        {
            Prestadores = new HashSet<Prestadore>();
            Idparticipantes = new HashSet<Participante>();
        }

        public long Idcattipoparticipante { get; set; }
        public string? Descripcion { get; set; }
        public string? Facultad { get; set; }

        public virtual ICollection<Prestadore> Prestadores { get; set; }

        public virtual ICollection<Participante> Idparticipantes { get; set; }
    }
}
