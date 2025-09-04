using System.ComponentModel.DataAnnotations.Schema;

namespace CargaFamiliares_WebApi.Domain.Entities.Tipos
{
    [Table("Escolaridad")]
    public class Escolaridad
    {
        [Column("ESC_CODIGO")]
        public int Codigo { get; set; }
        [Column("ESC_DESCRI")]
        public string Descripcion { get; set; } = string.Empty;
    }
}
