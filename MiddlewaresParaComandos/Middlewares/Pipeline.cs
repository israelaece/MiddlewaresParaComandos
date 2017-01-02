using MiddlewaresParaComandos.Commands;
using System;
using System.Linq;

namespace MiddlewaresParaComandos.Middlewares
{
    public class Pipeline
    {
        private Lazy<Action<Command>> middlewareChain;

        public Pipeline(params IMiddleware[] middlewares)
        {
            this.middlewareChain = new Lazy<Action<Command>>(() => BuildChain(middlewares.Reverse().ToArray()));
        }

        private static Action<Command> BuildChain(IMiddleware[] middlewares)
        {
            Action<Command> chain = command => { };

            foreach (var middleware in middlewares)
            {
                var temp = chain;

                chain = command => middleware.Execute(command, temp);
            }

            return chain;
        }

        public virtual void Handle<T>(T command) where T : Command
        {
            this.middlewareChain.Value(command);
        }
    }
}