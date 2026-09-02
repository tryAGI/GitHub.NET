
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The authentication type for the private registry.
    /// </summary>
    public enum OrgPrivateRegistryConfigurationAuthType
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
    public static class OrgPrivateRegistryConfigurationAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgPrivateRegistryConfigurationAuthType value)
        {
            return value switch
            {
                OrgPrivateRegistryConfigurationAuthType.OidcAws => "oidc_aws",
                OrgPrivateRegistryConfigurationAuthType.OidcAzure => "oidc_azure",
                OrgPrivateRegistryConfigurationAuthType.OidcCloudsmith => "oidc_cloudsmith",
                OrgPrivateRegistryConfigurationAuthType.OidcGcp => "oidc_gcp",
                OrgPrivateRegistryConfigurationAuthType.OidcJfrog => "oidc_jfrog",
                OrgPrivateRegistryConfigurationAuthType.Token => "token",
                OrgPrivateRegistryConfigurationAuthType.UsernamePassword => "username_password",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgPrivateRegistryConfigurationAuthType? ToEnum(string value)
        {
            return value switch
            {
                "oidc_aws" => OrgPrivateRegistryConfigurationAuthType.OidcAws,
                "oidc_azure" => OrgPrivateRegistryConfigurationAuthType.OidcAzure,
                "oidc_cloudsmith" => OrgPrivateRegistryConfigurationAuthType.OidcCloudsmith,
                "oidc_gcp" => OrgPrivateRegistryConfigurationAuthType.OidcGcp,
                "oidc_jfrog" => OrgPrivateRegistryConfigurationAuthType.OidcJfrog,
                "token" => OrgPrivateRegistryConfigurationAuthType.Token,
                "username_password" => OrgPrivateRegistryConfigurationAuthType.UsernamePassword,
                _ => null,
            };
        }
    }
}