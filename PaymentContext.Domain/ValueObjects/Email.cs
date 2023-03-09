using Flunt.Validations;
using PaymentContext.Shared.ValueOjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueOject
    {
        public Email(string address)
        {
            Address = address;

            AddNotifications(new Contract()
                 .Requires()
                 .IsEmail(Address, "Email.Address", "Email inválido"));
        }

        public string Address { get; private set; }
    }
}
