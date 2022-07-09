using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoMakersCode.Biblioteca.Application.Models.AdicionarUsuario;
using WoMakersCode.Biblioteca.Core.Entities;

namespace WoMakersCode.Biblioteca.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //AdicionarUsuarioRequest é a fonte, Usuario é o destino. Depois, no ForMember, vai inverter, destino e depois fonte
            //Foi usado src para dizer que é source e não repetir a palavra fonte.
            CreateMap<AdicionarUsuarioRequest, Usuario>()
                .ForMember(dest => dest.Nome, fonte => fonte.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Endereco, fonte => fonte.MapFrom(src => src.Endereco))
                .ForMember(dest => dest.Telefone, fonte => fonte.MapFrom(src => src.Telefone));

        }
    }
}
