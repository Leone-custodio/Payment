using Flunt.Validations;
using PaymentContext.Domain.Commads;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.Commands;
using PaymentContext.Shared.ValueOjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueOject
    {
        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }

        public Document(string number, EDocumentType type)
        {
            Number = number;
            type = type;

            AddNotifications(new Contract()
                .Requires()
                .IsTrue(Validade(type), number, "O documento é inválido")
                );
        }      

        

        private bool Validade(EDocumentType type)
        {
            if (Number.Length == 14 && type == EDocumentType.CNPJ)
                return true;

            if(Number.Length == 11 && type == EDocumentType.CPF)
                return true;

            return false;
           
        }
    }
}
