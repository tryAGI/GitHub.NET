
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The registry type.
    /// </summary>
    public enum OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType
    {
        /// <summary>
        ///
        /// </summary>
        CargoRegistry,
        /// <summary>
        ///
        /// </summary>
        ComposerRepository,
        /// <summary>
        ///
        /// </summary>
        DockerRegistry,
        /// <summary>
        ///
        /// </summary>
        GitSource,
        /// <summary>
        ///
        /// </summary>
        GoproxyServer,
        /// <summary>
        ///
        /// </summary>
        HelmRegistry,
        /// <summary>
        ///
        /// </summary>
        HexOrganization,
        /// <summary>
        ///
        /// </summary>
        HexRepository,
        /// <summary>
        ///
        /// </summary>
        MavenRepository,
        /// <summary>
        ///
        /// </summary>
        NpmRegistry,
        /// <summary>
        ///
        /// </summary>
        NugetFeed,
        /// <summary>
        ///
        /// </summary>
        PubRepository,
        /// <summary>
        ///
        /// </summary>
        PythonIndex,
        /// <summary>
        ///
        /// </summary>
        RubygemsServer,
        /// <summary>
        ///
        /// </summary>
        TerraformRegistry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType value)
        {
            return value switch
            {
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.CargoRegistry => "cargo_registry",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.ComposerRepository => "composer_repository",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.DockerRegistry => "docker_registry",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.GitSource => "git_source",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.GoproxyServer => "goproxy_server",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.HelmRegistry => "helm_registry",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.HexOrganization => "hex_organization",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.HexRepository => "hex_repository",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.MavenRepository => "maven_repository",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.NpmRegistry => "npm_registry",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.NugetFeed => "nuget_feed",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.PubRepository => "pub_repository",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.PythonIndex => "python_index",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.RubygemsServer => "rubygems_server",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.TerraformRegistry => "terraform_registry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType? ToEnum(string value)
        {
            return value switch
            {
                "cargo_registry" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.CargoRegistry,
                "composer_repository" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.ComposerRepository,
                "docker_registry" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.DockerRegistry,
                "git_source" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.GitSource,
                "goproxy_server" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.GoproxyServer,
                "helm_registry" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.HelmRegistry,
                "hex_organization" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.HexOrganization,
                "hex_repository" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.HexRepository,
                "maven_repository" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.MavenRepository,
                "npm_registry" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.NpmRegistry,
                "nuget_feed" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.NugetFeed,
                "pub_repository" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.PubRepository,
                "python_index" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.PythonIndex,
                "rubygems_server" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.RubygemsServer,
                "terraform_registry" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.TerraformRegistry,
                _ => null,
            };
        }
    }
}