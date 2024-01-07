using System;


namespace R5T.L0055
{
    /// <summary>
    /// Windows scripting foundation library.
    /// </summary>
    public class Instances
    {
        public static IConsoleOperator ConsoleOperator => L0055.ConsoleOperator.Instance;
        public static Z0063.IDirectoryPaths DirectoryPaths => Z0063.DirectoryPaths.Instance;
        public static IDotnetPackPathOperator DotnetPackPathOperator => L0055.DotnetPackPathOperator.Instance;
        public static L0053.IEnumerableOperator EnumerableOperator => L0053.EnumerableOperator.Instance;
        public static L0057.IExecutablePathOperator ExecutablePathOperator => L0057.ExecutablePathOperator.Instance;
        public static L0074.IFileEqualityVerifier FileEqualityVerifier => L0074.FileEqualityVerifier.Instance;
        public static L0056.IFileOperator FileOperator => L0056.FileOperator.Instance;
        public static L0057.IFileSystemOperator FileSystemOperator => L0057.FileSystemOperator.Instance;
        public static IFilePaths FilePaths => L0055.FilePaths.Instance;
        public static F0033.INotepadPlusPlusOperator NotepadPlusPlusOperator => F0033.NotepadPlusPlusOperator.Instance;
        public static L0057.IPathOperator PathOperator => L0057.PathOperator.Instance;
        public static IRuntimeEnvironmentOperator RuntimeEnvironmentOperator => L0055.RuntimeEnvironmentOperator.Instance;
        public static Z0046.IStrings Strings => Z0046.Strings.Instance;
        public static ITextOutputOperator TextOutputOperator => L0055.TextOutputOperator.Instance;
        public static F0034.IWindowsExplorerOperator WindowsExplorerOperator => F0034.WindowsExplorerOperator.Instance;
    }
}