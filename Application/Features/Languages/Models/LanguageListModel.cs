using Application.Features.Languages.Dtos;
using Core.Persistence.Paging;

namespace Application.Features.Languages.Models
{
    public class LanguageListModel :BasePageableModel
    {
        public IList<GetListLanguageDto> item { get; set; }
    }
}