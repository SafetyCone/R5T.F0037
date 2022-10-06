using System;


namespace R5T.F0037
{
    public static class Instances
    {
        public static IProgramBuilderOperator ProgramBuilderOperator { get; } = F0037.ProgramBuilderOperator.Instance;
        public static IProgramOperator ProgramOperator { get; } = F0037.ProgramOperator.Instance;

        public static IProgramOperator Program => Instances.ProgramOperator;
    }
}