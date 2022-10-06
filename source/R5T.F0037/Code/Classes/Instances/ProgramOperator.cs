using System;


namespace R5T.F0037
{
	public class ProgramOperator : IProgramOperator
	{
		#region Infrastructure

	    public static IProgramOperator Instance { get; } = new ProgramOperator();

	    private ProgramOperator()
	    {
        }

	    #endregion
	}
}