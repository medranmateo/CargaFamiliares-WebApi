using System.ComponentModel.DataAnnotations.Schema;

namespace CargaFamiliares_WebApi.Domain.Entities.Tipos
{
    [Table("TIPO_DOCUMENTO")]
    public class Documento
    {
        [Column("TIP_TIPDOC")]
        public string Tipo { get; set; } = string.Empty;

        [Column("TIP_DESCRI")]
        public string Descripcion { get; set; } = string.Empty;
    }
}
