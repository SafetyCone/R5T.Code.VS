using System;

using R5T.Code.VisualStudio.IO;
using R5T.NetStandard.IO.Paths;
using R5T.Tools.Dotnet;
using R5T.Tools.NuGet;


namespace R5T.Code.VisualStudio
{
    /// <summary>
    /// Service for creating Visual Studio project files.
    /// </summary>
    public interface IProjectFileActionServicesProvider
    {
        void AddPackageReference(ProjectFilePath projectFilePath, PackageSpecification packageSpecification);

        /// <summary>
        /// Adds a project file as a project reference.
        /// </summary>
        /// <param name="projectFilePath">The file path of the project to modify.</param>
        /// <param name="referenceProjectFilePath">The file path of the project to add as a reference.</param>
        void AddProjectReference(ProjectFilePath projectFilePath, ProjectFilePath referenceProjectFilePath);

        void CreateProjectFile(DotnetNewProjectType projectType, ProjectFilePath projectFilePath);

        /// <summary>
        /// Sets the "Copy to Output Directory" property for a file to "Copy if newer".
        /// </summary>
        void SetFileCopyToOutputDirectory(ProjectFilePath projectFilePath, FilePath filePath);

        /// <summary>
        /// Sets the version property of a project file.
        /// Useful for setting the initial library package version.
        /// </summary>
        /// <remarks>
        /// Note to implementers: setting the project version should overwrite any existing project version with the supplied value.
        /// </remarks>
        void SetProjectVersion(ProjectFilePath projectFilePath, Version version);

        /// <summary>
        /// Enables XML documenation file generation (required for NuGet package intellisense summary) by setting the GenerateDocumentationFile element to true.
        /// </summary>
        void EnableDocumentationGeneration(ProjectFilePath projectFilePath);

        /// <summary>
        /// Suppresses the missing XML documentation warning.
        /// </summary>
        /// <param name="projectFilePath"></param>
        void SuppressMissingXmlDocumentationWarnings(ProjectFilePath projectFilePath);
    }
}
