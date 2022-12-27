using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Prospecto
    {
        public Prospecto()
        {
            Fondos = new HashSet<Fondo>();
        }

        public long Idprospecto { get; set; }
        public string? Activobasevar { get; set; }
        public DateTime? Fechaautorizacion { get; set; }
        public bool? Ismercadocapital { get; set; }
        public bool? Ismercadodeuda { get; set; }
        public decimal? Porcentajecomisionservicios { get; set; }
        public string? Tiposociedad { get; set; }
        public decimal? Varestablecidopromedio { get; set; }
        public long? Idproveedorprecios { get; set; }
        public string? IndiceReferencia { get; set; }

        public virtual ICollection<Fondo> Fondos { get; set; }
    }
}
