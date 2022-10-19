using System;
using System.Threading.Tasks;

using R5T.F0036.T000;
using R5T.T0132;


namespace R5T.F0037
{
	[FunctionalityMarker]
	public partial interface IProgramOperator : IFunctionalityMarker
	{
		/// <summary>
		/// Use an asynchronous action to configure services, but run the 
		/// Note: it is possible to run an asynchronous action to configure services in a synchronous way, see: <see cref="ConfigureServices_Synchronous(Func{IServicesBuilder, Task})"/>.
		/// </summary>
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

		/// <summary>
		/// Use an asynchronous action to configure services, but run the asynchronous action synchronously.
		/// This is useful for WinForms program where due to the STAThread requirement, the Main() method must be synchronous. If you want to use asynchronous methods to configure services, then use this sync-over-async method.
		/// </summary>
		public ProgramBuilder ConfigureServices_Synchronous(
			Func<IServicesBuilder, Task> servicesBuilderAction)
		{
			var programBuilder = this.New();

			Instances.SyncOverAsyncOperator.ExecuteSynchronously(async () =>
			{
				await programBuilder.ConfigureServices(servicesBuilderAction);
			});

			return programBuilder;
		}

		public ProgramBuilder New()
		{
			var programBuilder = Instances.ProgramBuilderOperator.New();
			return programBuilder;
		}
	}
}