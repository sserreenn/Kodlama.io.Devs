using Application.Features.Languages.Commands;
using Application.Features.Languages.Dtos;
using Application.Features.Languages.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Languages.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<LanguageEntitiy, CreatedLanguageDto>().ReverseMap();
            CreateMap<LanguageEntitiy, CreateLanguageCommand>().ReverseMap();
            CreateMap<LanguageEntitiy, UpdatedLanguageDto>().ReverseMap();
            CreateMap<LanguageEntitiy, UpdateLanguageCommand>().ReverseMap();
            CreateMap<IPaginate<LanguageEntitiy>, LanguageListModel>().ReverseMap();
            CreateMap<LanguageEntitiy, GetListLanguageDto>().ReverseMap();
            CreateMap<LanguageEntitiy, GetByIdLanguageDto>().ReverseMap();
        }
    }
}