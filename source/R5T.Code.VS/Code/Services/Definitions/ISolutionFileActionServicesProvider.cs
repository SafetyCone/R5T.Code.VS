using System;

using R5T.Code.VisualStudio.IO;

using R5T.T0064;


namespace R5T.Code.VisualStudio
{
    /// <summary>
    /// Service for creating Visual Studio solution files.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface ISolutionFileActionServicesProvider : IServiceDefinition
    {
        /// <summary>
        /// Adds a project-file to a solution-file.
        /// </summary>
        void AddProject(SolutionFilePath solutionFilePath, ProjectFilePath projectFilePath);

        void RemoveProject(SolutionFilePath solutionFilePath, ProjectFilePath projectFilePath);

        /// <summary>
        /// Creates a solution-file at the specified path.
        /// </summary>
        void CreateSolutionFile(SolutionFilePath solutionFilePath);
    }
}
