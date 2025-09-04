using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CargaFamiliares_WebApi.Domain.DTO
{
    [Table("PERSONA")]
    public class PersonaDTO
    {
        [Column("TIP_TIPDOC")]
        public string TipoDocumento { get; set; } = string.Empty;
        
        [Key]
        [Column("PER_NRODOC")]
        public string NumeroDocumento { get; set; } = string.Empty;
    }
}
