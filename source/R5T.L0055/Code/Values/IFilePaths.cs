using System;

using R5T.T0131;


namespace R5T.L0055
{
    /// <summary>
    /// Useful file paths for outputs, examples, and samples.
    /// </summary>
    [ValuesMarker]
    public partial interface IFilePaths : IValuesMarker,
        Z0063.IFilePaths,
        Z0046.IFilePaths
    {
#pragma warning disable IDE1006 // Naming Styles
        public Z0063.Platform.IFilePaths _Platform_Z0063 => Z0063.Platform.FilePaths.Instance;
        public Z0046.Platform.IFilePaths _Platform_Z0046 => Z0046.Platform.FilePaths.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
