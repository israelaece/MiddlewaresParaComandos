using MiddlewaresParaComandos.Commands;
using System;

namespace MiddlewaresParaComandos.Middlewares
{
    public class CommandHandlerMiddleware : IMiddleware
    {
        public void Execute(Command command, Action<Command> next)
        {
            new CadastrarUsuarioHandler().Handle((CadastrarUsuario)command);
        }
    }
}