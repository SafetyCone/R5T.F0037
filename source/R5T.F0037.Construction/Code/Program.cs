using System;
using System.Threading.Tasks;


namespace R5T.F0037.Construction
{
    class Program
    {
        static async Task Main()
        {
            //Instances.Examples.RunProgram_Synchronous();
            await Instances.Examples.RunProgram_Asynchronous();
        }
    }
}