

namespace DevIO.BusinessOrDomain.EntitiesOrModels
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        protected Entity()
        {
            Guid Id = Guid.NewGuid();
        }
    }
}
