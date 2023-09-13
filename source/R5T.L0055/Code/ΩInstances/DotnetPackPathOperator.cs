using System;


namespace R5T.L0055
{
    public class DotnetPackPathOperator : IDotnetPackPathOperator
    {
        #region Infrastructure

        public static IDotnetPackPathOperator Instance { get; } = new DotnetPackPathOperator();


        private DotnetPackPathOperator()
        {
        }

        #endregion
    }
}
