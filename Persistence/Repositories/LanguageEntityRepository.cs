using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class LanguageEntityRepository : EfRepositoryBase<LanguageEntitiy, BaseDbContext>, ILanguageEntityRepository
    {
        public LanguageEntityRepository(BaseDbContext context) : base(context)
        {

        }
    }
}