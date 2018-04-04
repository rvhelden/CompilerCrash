using System;
using System.Threading.Tasks;

namespace CompilerCrash
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public async Task OnCrash()
        {
            var switchObject = new object();
            switch (switchObject)
            {
                case InvalidCastException _:
                    switch (switchObject)
                    {
                        case NullReferenceException exception:

                            await Task.CompletedTask;

                            var myexception = exception;
                            break;
                    }

                    break;
                case InvalidOperationException _:
                    switch (switchObject)
                    {
                        case NullReferenceException exception:

                            await Task.CompletedTask;

                            var myexception = exception;
                            break;
                    }

                    break;

            }
        }
    }
}