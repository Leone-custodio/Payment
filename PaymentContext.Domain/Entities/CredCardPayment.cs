using PaymentContext.Domain.ValueObjects;

public class CredCardPayment : Payment
{
    public CredCardPayment(
        string cardHolderName, 
        string cardNumber,
        string lastTransactionNumber,
        DateTime paidDate,
        DateTime expireDate,
        decimal total,
        decimal totalPaid,
        string ower, 
        Document document,
        Address address,
        Email email) :  
            base(
            paidDate,
            expireDate,
            total, 
            totalPaid,
            ower,
            document, 
            address,
            email)
    {
        CardHolderName = cardHolderName;
        CardNumber = cardNumber;
        LastTransactionNumber = lastTransactionNumber;
    }

    public string CardHolderName { get; private set; }
    public string CardNumber { get; private set; }
    public string LastTransactionNumber { get; private set; }

}
