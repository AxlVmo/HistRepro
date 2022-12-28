using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HistRepro.Models
{
    public partial class Afore
    {
        public Afore()
        {
            Siefores = new HashSet<Siefore>();
        }
        [Key]
        public long Idafore { get; set; }
        [Display(Name = "Clave Consar")]
        [DataType(DataType.Text)]
        [Required]
        public string? Claveconsar { get; set; }
        [Display(Name = "Clave Corta")]
        [DataType(DataType.Text)]
        [Required]
        public string? Clavecorta { get; set; }
        public string? Estatusparticipacion { get; set; }
        public DateTime? Fechaaltaparticipacion { get; set; }
        [Display(Name = "Fecha Autorizacion Oficio")]
        [DataType(DataType.Text)]
        [Required]
        public DateTime? Fechaautorizacionoficio { get; set; }
        public DateTime? Fechacambioparticipacion { get; set; }
        public DateTime? Fechaestatusparticipacion { get; set; }
        [Display(Name = "Nombre Corto")]
        [DataType(DataType.Text)]
        [Required]
        public string? Nombrecorto { get; set; }
        [Display(Name = "Numero Oficio Autorizacion")]
        [DataType(DataType.Text)]
        [Required]
        public string? Numerooficioautorizacion { get; set; }
        public string? Responsableinformacion { get; set; }
        public long? Claveentidad { get; set; }
        public string? Descripcionentidad { get; set; }

        public virtual Participante IdaforeNavigation { get; set; } = null!;
        public virtual ICollection<Siefore> Siefores { get; set; }
    }
}
