using Application.Features.Languages.Dtos;
using Application.Features.Languages.Rules;
using Application.Services.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.Languages.Commands
{
    public class DeleteLanguageCommand : IRequest
    {
        public int Id { get; set; }

        public class DeleteLanguageCommandHandler : IRequestHandler<DeleteLanguageCommand>
        {
            private readonly ILanguageEntityRepository _languageRepository;
            private readonly LanguageBusinessRules _languageBusinessRules;

            public DeleteLanguageCommandHandler(ILanguageEntityRepository languageRepository, LanguageBusinessRules languageBusinessRules)
            {
                _languageRepository = languageRepository;
                _languageBusinessRules = languageBusinessRules;
            }

            public async Task<Unit> Handle(DeleteLanguageCommand request, CancellationToken cancellationToken)
            {
                LanguageEntitiy? language = await _languageRepository.GetAsync(x => x.Id == request.Id);

                _languageBusinessRules.LanguageShouldExistWhenRequested(language);

                await _languageRepository.DeleteAsync(language);
                return Unit.Value;
            }
        }
    }
}