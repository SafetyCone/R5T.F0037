using System;

using R5T.F0000;


namespace R5T.F0037
{
    public static class Instances
    {
        public static IProgramBuilderOperator ProgramBuilderOperator { get; } = F0037.ProgramBuilderOperator.Instance;
        public static IProgramOperator ProgramOperator { get; } = F0037.ProgramOperator.Instance;
        public static ISyncOverAsyncOperator SyncOverAsyncOperator { get; } = F0000.SyncOverAsyncOperator.Instance;

        public static IProgramOperator Program => Instances.ProgramOperator;
    }
}