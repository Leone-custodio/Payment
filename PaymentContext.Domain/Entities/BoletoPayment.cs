
using PaymentContext.Domain.ValueObjects;

public class BoletoPayment : Payment
{
    public BoletoPayment(
        string barCode,
        string boletoNumber,
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
        BarCode = barCode;
        BoletoNumber = boletoNumber;
    }

    public string BarCode { get; private set; }
    public string BoletoNumber { get; private set; }
}

