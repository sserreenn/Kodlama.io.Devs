using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Exceptions;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Languages.Rules
{
    public class LanguageBusinessRules
    {
        private readonly ILanguageEntityRepository _languageRepository;

        public LanguageBusinessRules(ILanguageEntityRepository languageRepository)
        {
            _languageRepository = languageRepository;
        }

        public async Task LanguageNameCanNotBeDuplicatedInserted(string name)
        {
            IPaginate<LanguageEntitiy> result = await _languageRepository.GetListAsync(x=>x.Name == name);
            if (result.Items.Any()) throw new BusinessException("Language name exists.");
        }

        public async Task LanguageShouldExistWhenRequested(LanguageEntitiy language)
        {
            if(language == null) throw new BusinessException("Requested language does not exists.");
        }
    }
}
