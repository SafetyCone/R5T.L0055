using System;

using R5T.T0132;
using R5T.T0227;


namespace R5T.L0055
{
    [FunctionalityMarker]
    public partial interface IRuntimeEnvironmentOperator : IFunctionalityMarker,
        L0057.IRuntimeEnvironmentOperator
    {
        /// <summary>
        /// Opens the runtime directory path.
        /// <para>Example: <inheritdoc cref="Y0000.Documentation.Example_RuntimeDirectoryPath" path="/summary"/></para>
        /// </summary>
        /// <returns>The runtime directory path.</returns>
        public IRuntimeDirectoryPath Open_RuntimeDirectory()
        {
            var runtimeDirectoryPath = this.Get_RuntimeDirectoryPath();

            Instances.WindowsExplorerOperator.Open(runtimeDirectoryPath);

            return runtimeDirectoryPath;
        }
    }
}
