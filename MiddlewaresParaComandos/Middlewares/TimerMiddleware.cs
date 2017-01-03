using MiddlewaresParaComandos.Commands;
using System;
using System.Diagnostics;

namespace MiddlewaresParaComandos.Middlewares
{
    public class TimerMiddleware : IMiddleware
    {
        public void Execute(Command command, Action<Command> next)
        {
            var timer = Stopwatch.StartNew();
            Console.WriteLine("[INFO] - Início - {0:HH:mm:ss}", DateTime.Now);

            try
            {
                next(command);
            }
            finally
            {
                timer.Stop();
            }

            Console.WriteLine("[INFO] - Fim - {0:HH:mm:ss} - Tempo Decorrido: {1}",
                DateTime.Now, timer.Elapsed);
        }
    }
}