
using Application.Features.Languages.Dtos;
using Application.Features.Languages.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Languages.Commands
{
    public class UpdateLanguageCommand : IRequest<UpdatedLanguageDto>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public class UpdateLanguageCommandHandler : IRequestHandler<UpdateLanguageCommand, UpdatedLanguageDto>
        {
            private readonly ILanguageEntityRepository _languageRespository;
            private readonly IMapper _mapper;
            private readonly LanguageBusinessRules _languageBusinessRules;

            public UpdateLanguageCommandHandler(ILanguageEntityRepository languageRespository, IMapper mapper, LanguageBusinessRules languageBusinessRules)
            {
                _languageRespository = languageRespository;
                _mapper = mapper;
                _languageBusinessRules = languageBusinessRules;
            }

            public async Task<UpdatedLanguageDto> Handle(UpdateLanguageCommand request, CancellationToken cancellationToken)
            {
                LanguageEntitiy? language = await _languageRespository.GetAsync(x => x.Id == request.Id);

                _languageBusinessRules.LanguageShouldExistWhenRequested(language);
                await _languageBusinessRules.LanguageNameCanNotBeDuplicatedInserted(request.Name);

                _mapper.Map(request, language);
                LanguageEntitiy  updataedLanguage = await _languageRespository.UpdateAsync(language);
                UpdatedLanguageDto updatedLanguageDto = _mapper.Map<UpdatedLanguageDto>(updataedLanguage);

                return updatedLanguageDto;
            }
        }
    }
}