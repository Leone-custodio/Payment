using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;
using System.Linq.Expressions;

namespace PaymentContext.Domain.Queries
{
    public static class StudentQueries
    {
        public static Expression<Func<Student, bool>>GetStudentInfo(String document) 
        {
            return x => x.Document.Number == document; 
        }
    }
}
