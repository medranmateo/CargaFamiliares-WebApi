using CargaFamiliares_WebApi.Domain.DTO;
using CargaFamiliares_WebApi.Domain.Entities;

namespace CargaFamiliares_WebApi.Application.Interfaces.IRepositories
{
    public interface IFamiliaresRepository
    {
        public Task<IEnumerable<BuscoFamiliar>> BuscarFamiliares(string tipoDoc, string nroDoc);

        //public Task<IEnumerable<BuscoFamiliar>> BuscarFamiliaresPorId(int id);

        public Task<int> CrearFamiliar(InsertFamiliar familiarCrearDTO);

        public Task<int> CrearPersona(InsertPersona personaCrearDTO);

        public Task<int> ActualizarPersona(ActualizarPersona personaActualizarDTO);

        public Task<int> ObtenerIdPersona();

        public Task<PersonaDTO> ObtenerPersonaByDoc(string tipoDocumento, string numeroDocumento);
        
        public Task<FamiliarDTO>  ObtenerFamiliarByDoc(string tipoDocumento, string numeroDocumento);

    }
}
