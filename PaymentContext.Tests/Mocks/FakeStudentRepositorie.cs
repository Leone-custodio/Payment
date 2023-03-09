using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Tests.Mocks
{
    public class FakeStudentRepositorie : IStudentRepository
    {
        public void CreateSubscription(Student student)
        {
            
        }

        public bool DocumetExists(string document)
        {
            if(document == "99999999999")
                return true;
            return false;
        }

        public bool EmailExists(string email)
        {
            if (email == "helo@balta.io")
                return true;
            return false;
        }
    }
}
