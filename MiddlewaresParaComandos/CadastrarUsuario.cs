using MiddlewaresParaComandos.Commands;
using System;

namespace MiddlewaresParaComandos
{
    public class CadastrarUsuario : Command
    {
        public string Nome { get; set; }
    }

    public class CadastrarUsuarioHandler : IHandler<CadastrarUsuario>
    {
        public void Handle(CadastrarUsuario message)
        {
            Console.WriteLine("Cadastrando o usuário " + message.Nome);
        }
    }
}