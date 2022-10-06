using System;


namespace R5T.F0037
{
	public class ProgramBuilderOperator : IProgramBuilderOperator
	{
		#region Infrastructure

	    public static IProgramBuilderOperator Instance { get; } = new ProgramBuilderOperator();

	    private ProgramBuilderOperator()
	    {
        }

	    #endregion
	}
}