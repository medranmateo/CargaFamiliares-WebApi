using CargaFamiliares_WebApi.Application.Interfaces.IRepositories;
using CargaFamiliares_WebApi.Application.Interfaces.IServices;
using CargaFamiliares_WebApi.Domain.DTO;
using CargaFamiliares_WebApi.Domain.Entities;

namespace CargaFamiliares_WebApi.Application.Services
{
    public class FamiliaresService : IFamiliaresServices
    {
        private readonly IFamiliaresRepository _familiaresRepository;
        public FamiliaresService(IFamiliaresRepository familiaresRepository)
        {
            _familiaresRepository = familiaresRepository;
        }

        public async Task<int> ActualizarPersona(ActualizarPersona personaActualizarDTO)
        {
            var result = await this._familiaresRepository.ActualizarPersona(personaActualizarDTO);
            return result;
        }

        public async Task<IEnumerable<BuscoFamiliar>> BuscarFamiliares(string tipoDoc, string nroDoc)
        {
            return await _familiaresRepository.BuscarFamiliares(tipoDoc, nroDoc);
        }

        public async Task<int> CrearFamiliar(InsertFamiliar familiarCrearDTO)
        {
            var familiar = await this.ObtenerFamiliarByDoc(familiarCrearDTO.TipoDocumento, familiarCrearDTO.NumeroDocumento);
            if (familiar != null || !string.IsNullOrEmpty(familiar?.NumeroDocumento)) 
            {
                throw new InvalidOperationException($"Ya existe un familiar con {familiar.TipoDocumento} {familiar.NumeroDocumento}");
            }

            var result = await this._familiaresRepository.CrearFamiliar(familiarCrearDTO);
            return result;
        }

        public async Task<int> CrearPersona(InsertPersona personaCrear)
        {
            var persona = await this.ObtenerPersonaByDoc(personaCrear.TipoDocumento, personaCrear.NumeroDocumento);
            if (persona != null || !string.IsNullOrEmpty(persona?.NumeroDocumento))
            {
                throw new InvalidOperationException($"Ya existe una Persona con {persona.TipoDocumento} {persona.NumeroDocumento}");
            }

            var idPersona = await this._familiaresRepository.ObtenerIdPersona();
            personaCrear.idPersona = idPersona;
            var result = await this._familiaresRepository.CrearPersona(personaCrear);
            return result;
        }

        private async Task<PersonaDTO> ObtenerPersonaByDoc(string tipoDocumento, string numeroDocumento) 
        {
            var result = await _familiaresRepository.ObtenerPersonaByDoc(tipoDocumento, numeroDocumento);
            return result ?? new PersonaDTO();
        }

        private async Task<FamiliarDTO> ObtenerFamiliarByDoc(string tipoDocumento, string numeroDocumento) 
        {
            var result = await _familiaresRepository.ObtenerFamiliarByDoc(tipoDocumento, numeroDocumento);
            return result ?? new FamiliarDTO();
        }

        //public async Task<int> Nuevofamiliar(InsertFamiliar familiar, InsertPersona persona)
        //{

        //}
    }
}
