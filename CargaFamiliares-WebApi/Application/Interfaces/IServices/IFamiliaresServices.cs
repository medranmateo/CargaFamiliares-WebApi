using CargaFamiliares_WebApi.Domain.Entities;

namespace CargaFamiliares_WebApi.Application.Interfaces.IServices
{
    public interface IFamiliaresServices
    {
        public Task<IEnumerable<BuscoFamiliar>> BuscarFamiliares(string tipoDoc, string nroDoc);

        public Task<int> CrearFamiliar(InsertFamiliar familiarCrearDTO);

        public Task<int> CrearPersona(InsertPersona personaCrearDTO);

        public Task<int> ActualizarPersona(ActualizarPersona personaActualizarDTO);
    }
}
