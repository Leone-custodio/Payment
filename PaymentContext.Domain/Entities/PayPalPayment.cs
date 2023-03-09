using PaymentContext.Domain.ValueObjects;

public class PayPalPayment : Payment
{
    public PayPalPayment(
        string transactionCode,
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
        TransactionCode = transactionCode;
    }

    public string TransactionCode { get; private set; }
}
