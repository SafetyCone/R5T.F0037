using System;
using System.Threading.Tasks;

using R5T.F0037;

using Instances = R5T.F0037.Instances;


namespace System
{
    public static class ProgramBuilderExtensions
    {
		public static void Run_Synchronous<TProgram>(this ProgramBuilder programBuilder)
			where TProgram : class, ISynchronousProgram
		{
			Instances.ProgramBuilderOperator.Run_Synchronous<TProgram>(programBuilder);
		}

		public static async Task Run_Synchronous<TProgram>(this Task<ProgramBuilder> gettingProgramBuilder)
			where TProgram : class, ISynchronousProgram
		{
			var programBuilder = await gettingProgramBuilder;

			Instances.ProgramBuilderOperator.Run_Synchronous<TProgram>(programBuilder);
		}

		public static Task Run<TProgram>(this ProgramBuilder programBuilder)
			where TProgram : class, IAsynchronousProgram
		{
			return Instances.ProgramBuilderOperator.Run<TProgram>(programBuilder);
		}

		public static Task Run<TProgram>(this Task<ProgramBuilder> gettingProgramBuilder)
			where TProgram : class, IAsynchronousProgram
		{
			return Instances.ProgramBuilderOperator.Run<TProgram>(gettingProgramBuilder);
		}
	}
}
