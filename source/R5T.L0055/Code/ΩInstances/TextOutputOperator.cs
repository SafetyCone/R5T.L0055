using System;


namespace R5T.L0055
{
    public class TextOutputOperator : ITextOutputOperator
    {
        #region Infrastructure

        public static ITextOutputOperator Instance { get; } = new TextOutputOperator();


        private TextOutputOperator()
        {
        }

        #endregion
    }
}
