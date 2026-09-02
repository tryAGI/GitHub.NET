
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The authentication type for the private registry.
    /// </summary>
    public enum OrgPrivateRegistryConfigurationWithSelectedRepositoriesAuthType
    {
        /// <summary>
        ///
        /// </summary>
        OidcAws,
        /// <summary>
        ///
        /// </summary>
        OidcAzure,
        /// <summary>
        ///
        /// </summary>
        OidcCloudsmith,
        /// <summary>
        ///
        /// </summary>
        OidcGcp,
        /// <summary>
        ///
        /// </summary>
        OidcJfrog,
        /// <summary>
        ///
        /// </summary>
        Token,
        /// <summary>
        ///
        /// </summary>
        UsernamePassword,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgPrivateRegistryConfigurationWithSelectedRepositoriesAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgPrivateRegistryConfigurationWithSelectedRepositoriesAuthType value)
        {
            return value switch
            {
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesAuthType.OidcAws => "oidc_aws",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesAuthType.OidcAzure => "oidc_azure",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesAuthType.OidcCloudsmith => "oidc_cloudsmith",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesAuthType.OidcGcp => "oidc_gcp",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesAuthType.OidcJfrog => "oidc_jfrog",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesAuthType.Token => "token",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesAuthType.UsernamePassword => "username_password",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgPrivateRegistryConfigurationWithSelectedRepositoriesAuthType? ToEnum(string value)
        {
            return value switch
            {
                "oidc_aws" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesAuthType.OidcAws,
                "oidc_azure" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesAuthType.OidcAzure,
                "oidc_cloudsmith" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesAuthType.OidcCloudsmith,
                "oidc_gcp" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesAuthType.OidcGcp,
                "oidc_jfrog" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesAuthType.OidcJfrog,
                "token" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesAuthType.Token,
                "username_password" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesAuthType.UsernamePassword,
                _ => null,
            };
        }
    }
}