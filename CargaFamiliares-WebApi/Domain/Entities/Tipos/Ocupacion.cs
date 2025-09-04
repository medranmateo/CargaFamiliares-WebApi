using System.ComponentModel.DataAnnotations.Schema;

namespace CargaFamiliares_WebApi.Domain.Entities.Tipos
{
    [Table("OCUPACION")]
    public class Ocupacion
    {
        [Column("OCU_CODIGO")]
        public int Codigo { get; set; } = 0;

        [Column("OCU_DESCRI")]
        public string Descripcion { get; set; } = string.Empty;
    }
}
