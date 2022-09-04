using Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class LanguageEntitiy:Entity
    {
        public string Name { get; set; }

        public LanguageEntitiy()
        {
        }
        public LanguageEntitiy(int id, string name) : this()
        {
            Id = id;
            Name = name;
        }
    }
}
