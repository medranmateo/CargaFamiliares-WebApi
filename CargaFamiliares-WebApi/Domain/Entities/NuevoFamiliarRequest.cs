namespace CargaFamiliares_WebApi.Domain.Entities
{
    public class NuevoFamiliarRequest
    {
        public InsertFamiliar Familiar { get; set; }
        public InsertPersona Persona { get; set; }
    }
}
