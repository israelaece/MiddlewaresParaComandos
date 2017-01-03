using MiddlewaresParaComandos.Commands;
using System;

namespace MiddlewaresParaComandos.Middlewares
{
    public class LoggingMiddleware : IMiddleware
    {
        public void Execute(Command command, Action<Command> next)
        {
            Console.WriteLine("[LOG] - Início - " + command.GetType());
            next(command);
            Console.WriteLine("[LOG] - Fim - " + command.GetType());
        }
    }
}