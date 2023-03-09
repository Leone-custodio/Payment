using PaymentContext.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Domain.Commads
{
    public class CommandResult : ICommandResult
    {
        public CommandResult()
        {

        }
        public CommandResult(bool sucesses, string mensage)
        {
            Sucesses = sucesses;
            Mensage = mensage;
        }

        public bool Sucesses { get; set; }
        public string Mensage { get; set; }
    }
}
