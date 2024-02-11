using AutoMapper;
using TiendaServicios.Modelo;

namespace TiendaServicios.Aplicacion
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<AutorLibro, AutorDto>();
        }


    }
}
