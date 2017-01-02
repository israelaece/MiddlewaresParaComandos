using MiddlewaresParaComandos.Middlewares;

namespace MiddlewaresParaComandos
{
    class Program
    {
        static void Main(string[] args)
        {
            var pipeline =
                new Pipeline(
                    new TimerMiddleware(),
                    new LoggingMiddleware(),
                    new TransactionMiddleware(),
                    new CommandHandlerMiddleware());

            pipeline.Handle(new CadastrarUsuario() { Nome = "Israel" });
        }
    }
}