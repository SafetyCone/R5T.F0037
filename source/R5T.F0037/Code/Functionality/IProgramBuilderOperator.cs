using System;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0132;


namespace R5T.F0037
{
	[FunctionalityMarker]
	public partial interface IProgramBuilderOperator : IFunctionalityMarker
	{
		public void Run_Synchronous<TProgram>(ProgramBuilder programBuilder)
			where TProgram : class, ISynchronousProgram
        {
			using var serviceProvider = F0036.Instances.ServiceProvider.New(programBuilder.Services)
				.ConfigureServices(services => services.AddTransient<TProgram>())
				.Build();

			var program = serviceProvider.GetRequiredService<TProgram>();

			program.Run();
        }

		public async Task Run<TProgram>(ProgramBuilder programBuilder)
			where TProgram : class, IAsynchronousProgram
		{
			await using var serviceProvider = F0036.Instances.ServiceProvider.New(programBuilder.Services)
				.ConfigureServices(services => services.AddTransient<TProgram>())
				.Build();

			var program = serviceProvider.GetRequiredService<TProgram>();

			await program.Run();
		}

		public ProgramBuilder New()
        {
			var programBuilder = new ProgramBuilder(F0028.ServiceCollectionOperator.Instance.New());
			return programBuilder;
        }
	}
}