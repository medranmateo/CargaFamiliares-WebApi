namespace CargaFamiliares_WebApi.Domain.Entities.Tipos
{
    public class Agrupados
    {
        public IEnumerable<Documento> Documentos { get; set; } = Enumerable.Empty<Documento>();
        public IEnumerable<Parentesco> Parentescos { get; set; } = Enumerable.Empty<Parentesco>();
        public IEnumerable<Escolaridad> Escolaridades { get; set; } = Enumerable.Empty<Escolaridad>();
        public IEnumerable<Ocupacion> Ocupaciones { get; set; } = Enumerable.Empty<Ocupacion>();
        public IEnumerable<EstadoCivil> EstadosCiviles { get; set; } = Enumerable.Empty<EstadoCivil>();
    }
}
