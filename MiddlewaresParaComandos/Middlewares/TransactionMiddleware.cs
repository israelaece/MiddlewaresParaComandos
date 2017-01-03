using MiddlewaresParaComandos.Commands;
using System;
using System.Transactions;

namespace MiddlewaresParaComandos.Middlewares
{
    public class TransactionMiddleware : IMiddleware
    {
        public void Execute(Command command, Action<Command> next)
        {
            using (var ts = new TransactionScope())
                next(command);
        }
    }
}