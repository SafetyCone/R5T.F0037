using System;
using System.Threading.Tasks;


namespace R5T.F0037.Construction
{
    public class Program02 : IAsynchronousProgram
    {
        public async Task Run()
        {
            await Console.Out.WriteLineAsync("Test");
        }
    }
}
