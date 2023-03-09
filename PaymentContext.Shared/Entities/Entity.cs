using PaymentContext.Shared.ValueOjects;

namespace PaymentContext.Shared.Entities
{
    public abstract class Entity : ValueOject
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}
