
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The registry type.
    /// </summary>
    public enum PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType
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
    public static class PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType value)
        {
            return value switch
            {
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.CargoRegistry => "cargo_registry",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.ComposerRepository => "composer_repository",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.DockerRegistry => "docker_registry",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.GitSource => "git_source",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.GoproxyServer => "goproxy_server",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.HelmRegistry => "helm_registry",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.HexOrganization => "hex_organization",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.HexRepository => "hex_repository",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.MavenRepository => "maven_repository",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.NpmRegistry => "npm_registry",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.NugetFeed => "nuget_feed",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.PubRepository => "pub_repository",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.PythonIndex => "python_index",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.RubygemsServer => "rubygems_server",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.TerraformRegistry => "terraform_registry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType? ToEnum(string value)
        {
            return value switch
            {
                "cargo_registry" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.CargoRegistry,
                "composer_repository" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.ComposerRepository,
                "docker_registry" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.DockerRegistry,
                "git_source" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.GitSource,
                "goproxy_server" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.GoproxyServer,
                "helm_registry" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.HelmRegistry,
                "hex_organization" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.HexOrganization,
                "hex_repository" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.HexRepository,
                "maven_repository" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.MavenRepository,
                "npm_registry" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.NpmRegistry,
                "nuget_feed" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.NugetFeed,
                "pub_repository" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.PubRepository,
                "python_index" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.PythonIndex,
                "rubygems_server" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.RubygemsServer,
                "terraform_registry" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.TerraformRegistry,
                _ => null,
            };
        }
    }
}