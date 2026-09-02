
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The registry type.
    /// </summary>
    public enum PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType
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
    public static class PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType value)
        {
            return value switch
            {
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.CargoRegistry => "cargo_registry",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.ComposerRepository => "composer_repository",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.DockerRegistry => "docker_registry",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.GitSource => "git_source",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.GoproxyServer => "goproxy_server",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.HelmRegistry => "helm_registry",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.HexOrganization => "hex_organization",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.HexRepository => "hex_repository",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.MavenRepository => "maven_repository",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.NpmRegistry => "npm_registry",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.NugetFeed => "nuget_feed",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.PubRepository => "pub_repository",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.PythonIndex => "python_index",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.RubygemsServer => "rubygems_server",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.TerraformRegistry => "terraform_registry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType? ToEnum(string value)
        {
            return value switch
            {
                "cargo_registry" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.CargoRegistry,
                "composer_repository" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.ComposerRepository,
                "docker_registry" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.DockerRegistry,
                "git_source" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.GitSource,
                "goproxy_server" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.GoproxyServer,
                "helm_registry" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.HelmRegistry,
                "hex_organization" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.HexOrganization,
                "hex_repository" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.HexRepository,
                "maven_repository" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.MavenRepository,
                "npm_registry" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.NpmRegistry,
                "nuget_feed" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.NugetFeed,
                "pub_repository" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.PubRepository,
                "python_index" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.PythonIndex,
                "rubygems_server" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.RubygemsServer,
                "terraform_registry" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.TerraformRegistry,
                _ => null,
            };
        }
    }
}