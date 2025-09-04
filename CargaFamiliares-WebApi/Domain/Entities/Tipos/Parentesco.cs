using System.ComponentModel.DataAnnotations.Schema;

namespace CargaFamiliares_WebApi.Domain.Entities.Tipos
{
    [Table("Parentesco")]
    public class Parentesco
    {
        [Column("PAR_CODIGO")]
        public int Codigo { get; set; }
        [Column("PAR_DESCRI")]
        public string Descripcion { get; set; } = string.Empty;
    }
}
