using System;
using System.Threading.Tasks;
using R5T.T0132;
using R5T.T0159;
using R5T.T0181;


namespace R5T.L0055
{
    [FunctionalityMarker]
    public partial interface ITextOutputOperator : IFunctionalityMarker
    {
        public static T0159.F000.ITextOutputOperator Base => T0159.F000.TextOutputOperator.Instance;


        public (
            ITextFilePath humanOutputTextFilePath,
            ILogFilePath logFilePath)
        In_TextOutputContext_Synchronous(
            string logCategoryName,
            Action<ITextOutput> textOutputAction)
        {
            var humanOutputTextFilePath = Instances.FilePaths.HumanOutputTextFilePath;

            var logFilePath = Instances.FilePaths.LogFilePath;

            Base.InTextOutputContext_Synchronous(
                humanOutputTextFilePath.Value,
                logCategoryName,
                logFilePath.Value,
                textOutputAction);

            return (humanOutputTextFilePath, logFilePath);
        }

        public async Task<(
            ITextFilePath humanOutputTextFilePath,
            ILogFilePath logFilePath)>
        In_TextOutputContext(
            string logCategoryName,
            Func<ITextOutput, Task> textOutputAction)
        {
            var humanOutputTextFilePath = Instances.FilePaths.HumanOutputTextFilePath;

            var logFilePath = Instances.FilePaths.LogFilePath;

            await Base.InTextOutputContext(
                humanOutputTextFilePath.Value,
                logCategoryName,
                logFilePath.Value,
                textOutputAction);

            return (humanOutputTextFilePath, logFilePath);
        }

        public async Task<(
            ITextFilePath humanOutputTextFilePath,
            ILogFilePath logFilePath)>
        In_TextOutputContext(
            ITextFilePath humanOutputTextFilePath,
            string logCategoryName,
            ILogFilePath logFilePath,
            Func<ITextOutput, Task> textOutputAction)
        {
            await Base.InTextOutputContext(
                humanOutputTextFilePath.Value,
                logCategoryName,
                logFilePath.Value,
                textOutputAction);

            return (humanOutputTextFilePath, logFilePath);
        }
    }
}
