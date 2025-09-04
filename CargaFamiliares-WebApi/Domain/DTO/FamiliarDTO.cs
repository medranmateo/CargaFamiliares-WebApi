using System.ComponentModel.DataAnnotations.Schema;

namespace CargaFamiliares_WebApi.Domain.DTO
{
    [Table("FAMILIAR")]
    public class FamiliarDTO
    {
        [Column("TIP_TIPDOC")]
        public string TipoDocumento { get; set; } = string.Empty;
        [Column("PER_NRODOC")]
        public string NumeroDocumento { get; set; } = string.Empty;
    }
}
