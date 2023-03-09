using Flunt.Validations;
using PaymentContext.Shared.Entities;

public class Subscription : Entity
{
    private IList<Payment> _payments;
   
    public Subscription(DateTime? expireDate)
    {
        CreateDate = DateTime.Now;
        LastUpdateDate = DateTime.Now;
        ExpireDate = expireDate;
        Active = true;
        _payments = new List<Payment>();
    }

    public DateTime CreateDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
    public DateTime? ExpireDate { get; set; }
    public bool Active { get; set; }
    public IReadOnlyCollection<Payment> Payments { get { return _payments.ToArray(); } }

    public void AddPayment(Payment payment)
    {
        AddNotifications(new Contract()
            .Requires()
            .IsGreaterThan(DateTime.Now, payment.PaidDate,
            "Sbscription.Payments", "A data do pagamento deve ser futura"));

        _payments.Add(payment);
    }

    public void Activate()
    {
        Active = true;
        LastUpdateDate= DateTime.Now;
    }

    public void Inactivate()
    {
        Active = false;
        LastUpdateDate = DateTime.Now;
    }
}
    