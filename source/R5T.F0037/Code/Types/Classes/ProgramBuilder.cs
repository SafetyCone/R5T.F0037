using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.F0036.T000;
using R5T.T0142;


namespace R5T.F0037
{
    [DraftUtilityTypeMarker]
    public class ProgramBuilder : IHasServices
    {
        public IServiceCollection Services { get; }


        public ProgramBuilder(
            IServiceCollection services)
        {
            this.Services = services;
        }
    }
}
