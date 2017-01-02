using MiddlewaresParaComandos.Commands;
using System;

namespace MiddlewaresParaComandos.Middlewares
{
    public interface IMiddleware
    {
        void Execute(Command command, Action<Command> next);
    }
}