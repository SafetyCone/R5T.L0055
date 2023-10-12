using System;

using R5T.T0132;
using R5T.T0214;
using R5T.T0215;
using R5T.T0218;


namespace R5T.L0055
{
    [FunctionalityMarker]
    public partial interface IDotnetPackPathOperator : IFunctionalityMarker,
        L0064.F001.IDotnetPackPathOperator
    {
        /// <summary>
        /// Opens the runtime directory path.
        /// <para>Example: <inheritdoc cref="Y0000.Documentation.Example_RuntimeDirectoryPath" path="/summary"/></para>
        /// </summary>
        /// <returns>The runtime directory path.</returns>
        public IDotnetPackDirectoryPath Open_DotnetPackDirectory(
            IDotnetPackName dotnetPackName,
            ITargetFrameworkMoniker targetFrameworkMoniker)
        {
            var runtimeDirectoryPath = this.Get_DotnetPackDirectoryPath(
                dotnetPackName,
                targetFrameworkMoniker);

            Instances.WindowsExplorerOperator.Open(runtimeDirectoryPath);

            return runtimeDirectoryPath;
        }
    }
}
