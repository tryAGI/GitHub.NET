
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The authentication type for the private registry. Defaults to `token` if not specified. Use `oidc_azure`, `oidc_aws`, `oidc_jfrog`, `oidc_cloudsmith`, or `oidc_gcp` for OIDC authentication.
    /// </summary>
    public enum PrivateRegistriesCreateOrgPrivateRegistryRequestAuthType
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
    public static class PrivateRegistriesCreateOrgPrivateRegistryRequestAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateRegistriesCreateOrgPrivateRegistryRequestAuthType value)
        {
            return value switch
            {
                PrivateRegistriesCreateOrgPrivateRegistryRequestAuthType.OidcAws => "oidc_aws",
                PrivateRegistriesCreateOrgPrivateRegistryRequestAuthType.OidcAzure => "oidc_azure",
                PrivateRegistriesCreateOrgPrivateRegistryRequestAuthType.OidcCloudsmith => "oidc_cloudsmith",
                PrivateRegistriesCreateOrgPrivateRegistryRequestAuthType.OidcGcp => "oidc_gcp",
                PrivateRegistriesCreateOrgPrivateRegistryRequestAuthType.OidcJfrog => "oidc_jfrog",
                PrivateRegistriesCreateOrgPrivateRegistryRequestAuthType.Token => "token",
                PrivateRegistriesCreateOrgPrivateRegistryRequestAuthType.UsernamePassword => "username_password",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateRegistriesCreateOrgPrivateRegistryRequestAuthType? ToEnum(string value)
        {
            return value switch
            {
                "oidc_aws" => PrivateRegistriesCreateOrgPrivateRegistryRequestAuthType.OidcAws,
                "oidc_azure" => PrivateRegistriesCreateOrgPrivateRegistryRequestAuthType.OidcAzure,
                "oidc_cloudsmith" => PrivateRegistriesCreateOrgPrivateRegistryRequestAuthType.OidcCloudsmith,
                "oidc_gcp" => PrivateRegistriesCreateOrgPrivateRegistryRequestAuthType.OidcGcp,
                "oidc_jfrog" => PrivateRegistriesCreateOrgPrivateRegistryRequestAuthType.OidcJfrog,
                "token" => PrivateRegistriesCreateOrgPrivateRegistryRequestAuthType.Token,
                "username_password" => PrivateRegistriesCreateOrgPrivateRegistryRequestAuthType.UsernamePassword,
                _ => null,
            };
        }
    }
}