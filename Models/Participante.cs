using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Participante
    {
        public Participante()
        {
            Contactos = new HashSet<Contacto>();
            Prestadores = new HashSet<Prestadore>();
            Idtipoparticipacions = new HashSet<Cattipoparticipante>();
        }

        public long Idparticipante { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? Fechaalta { get; set; }
        public DateTime? Fechacambio { get; set; }
        public DateTime? Fechaestatus { get; set; }
        public string? Paginainternet { get; set; }
        public string? Razonsocial { get; set; }
        public string? Rfc { get; set; }

        public virtual Afore? Afore { get; set; }
        public virtual Aseguradora? Aseguradora { get; set; }
        public virtual Calificadorasalt2? Calificadorasalt2 { get; set; }
        public virtual Depositario? Depositario { get; set; }
        public virtual Distribuidore? Distribuidore { get; set; }
        public virtual Domicilio? Domicilio { get; set; }
        public virtual Entidadesregulatoria? Entidadesregulatoria { get; set; }
        public virtual Operadora? Operadora { get; set; }
        public virtual Promotoresindependiente? Promotoresindependiente { get; set; }
        public virtual Proveedore? Proveedore { get; set; }
        public virtual Proveedoresprecio? Proveedoresprecio { get; set; }
        public virtual Sociosliquidadore? Sociosliquidadore { get; set; }
        public virtual Valuadora? Valuadora { get; set; }
        public virtual Valuadorasempleado? Valuadorasempleado { get; set; }
        public virtual ICollection<Contacto> Contactos { get; set; }
        public virtual ICollection<Prestadore> Prestadores { get; set; }

        public virtual ICollection<Cattipoparticipante> Idtipoparticipacions { get; set; }
    }
}
