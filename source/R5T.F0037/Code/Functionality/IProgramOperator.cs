using System;
using System.Threading.Tasks;

using R5T.F0036.T000;
using R5T.T0132;


namespace R5T.F0037
{
	[FunctionalityMarker]
	public partial interface IProgramOperator : IFunctionalityMarker
	{
		public ProgramBuilder ConfigureServices(
			Action<IServicesBuilder> servicesBuilderAction)
		{
			var programBuilder = this.New();

			programBuilder.ConfigureServices(servicesBuilderAction);

			return programBuilder;
		}

		public async Task<ProgramBuilder> ConfigureServices(
			Func<IServicesBuilder, Task> servicesBuilderAction)
		{
			var programBuilder = this.New();

			await programBuilder.ConfigureServices(servicesBuilderAction);

			return programBuilder;
		}

		public ProgramBuilder New()
		{
			var programBuilder = Instances.ProgramBuilderOperator.New();
			return programBuilder;
		}
	}
}