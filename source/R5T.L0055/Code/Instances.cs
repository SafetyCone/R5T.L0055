using System;


namespace R5T.L0055
{
    /// <summary>
    /// Windows scripting foundation library.
    /// </summary>
    public class Instances
    {
        public static Z0063.IDirectoryPaths DirectoryPaths => Z0063.DirectoryPaths.Instance;
        public static IFilePaths FilePaths => L0055.FilePaths.Instance;
        public static F0033.INotepadPlusPlusOperator NotepadPlusPlusOperator => F0033.NotepadPlusPlusOperator.Instance;
        public static L0057.IPathOperator PathOperator => L0057.PathOperator.Instance;
        public static Z0046.IStrings Strings => Z0046.Strings.Instance;
        public static ITextOutputOperator TextOutputOperator => L0055.TextOutputOperator.Instance;
        public static F0034.IWindowsExplorerOperator WindowsExplorerOperator => F0034.WindowsExplorerOperator.Instance;
    }
}