using System;
using System.Collections.Generic;

using R5T.T0132;


namespace R5T.L0055
{
    [FunctionalityMarker]
    public partial interface IConsoleOperator : IFunctionalityMarker
    {
        public void Output(IEnumerable<object> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
