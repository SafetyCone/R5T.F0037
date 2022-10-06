using System;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.F0037.Construction
{
	[FunctionalityMarker]
	public partial interface IExamples : IFunctionalityMarker
	{
		public Task RunProgram_Asynchronous()
		{
			return F0037.Instances.Program
				.ConfigureServices(F0036.Instances.ServicesBuilderOperator.GetUseServicesConfigurer_Synchronous<ServicesConfigurer01>())
				.Run<Program02>();
		}

		public void RunProgram_Synchronous()
		{
			F0037.Instances.Program
				.ConfigureServices(F0036.Instances.ServicesBuilderOperator.GetUseServicesConfigurer_Synchronous<ServicesConfigurer01>())
				.Run_Synchronous<Program01>();
		}
	}
}