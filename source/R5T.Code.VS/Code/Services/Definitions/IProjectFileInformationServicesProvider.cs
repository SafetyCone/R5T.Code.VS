using System;

using R5T.Code.VisualStudio.IO;
using R5T.Tools.NuGet;

using R5T.T0064;


namespace R5T.Code.VisualStudio
{
    [ServiceDefinitionMarker]
    public interface IProjectFileInformationServicesProvider : IServiceDefinition
    {
        ProjectFilePath[] GetProjectReferenceFilePaths(ProjectFilePath projectFilePath);
        ProjectFilePath[] GetProjectReferencedFilePathsRecursive(ProjectFilePath projectFilePath);
        PackageSpecification[] GetPackageReferences(ProjectFilePath projectFilePath);

        /// <summary>
        /// Determines if a project file has a version, and if so, returns the version.
        /// If the project file does not have a version, returns <see cref="R5T.NetStandard.VersionHelper.None"/>.
        /// </summary>
        bool HasVersion(ProjectFilePath projectFilePath, out Version version);
    }
}
