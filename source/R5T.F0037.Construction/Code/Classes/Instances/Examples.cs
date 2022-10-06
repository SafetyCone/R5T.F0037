using System;


namespace R5T.F0037.Construction
{
	public class Examples : IExamples
	{
		#region Infrastructure

	    public static IExamples Instance { get; } = new Examples();

	    private Examples()
	    {
        }

	    #endregion
	}
}