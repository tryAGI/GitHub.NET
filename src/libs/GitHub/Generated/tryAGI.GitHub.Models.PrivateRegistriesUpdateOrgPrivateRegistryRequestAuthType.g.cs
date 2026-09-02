
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The authentication type for the private registry. This field cannot be changed after creation. If provided, it must match the existing `auth_type` of the configuration. To change the authentication type, delete and recreate the configuration.
    /// </summary>
    public enum PrivateRegistriesUpdateOrgPrivateRegistryRequestAuthType
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
    public static class PrivateRegistriesUpdateOrgPrivateRegistryRequestAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateRegistriesUpdateOrgPrivateRegistryRequestAuthType value)
        {
            return value switch
            {
                PrivateRegistriesUpdateOrgPrivateRegistryRequestAuthType.OidcAws => "oidc_aws",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestAuthType.OidcAzure => "oidc_azure",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestAuthType.OidcCloudsmith => "oidc_cloudsmith",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestAuthType.OidcGcp => "oidc_gcp",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestAuthType.OidcJfrog => "oidc_jfrog",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestAuthType.Token => "token",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestAuthType.UsernamePassword => "username_password",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateRegistriesUpdateOrgPrivateRegistryRequestAuthType? ToEnum(string value)
        {
            return value switch
            {
                "oidc_aws" => PrivateRegistriesUpdateOrgPrivateRegistryRequestAuthType.OidcAws,
                "oidc_azure" => PrivateRegistriesUpdateOrgPrivateRegistryRequestAuthType.OidcAzure,
                "oidc_cloudsmith" => PrivateRegistriesUpdateOrgPrivateRegistryRequestAuthType.OidcCloudsmith,
                "oidc_gcp" => PrivateRegistriesUpdateOrgPrivateRegistryRequestAuthType.OidcGcp,
                "oidc_jfrog" => PrivateRegistriesUpdateOrgPrivateRegistryRequestAuthType.OidcJfrog,
                "token" => PrivateRegistriesUpdateOrgPrivateRegistryRequestAuthType.Token,
                "username_password" => PrivateRegistriesUpdateOrgPrivateRegistryRequestAuthType.UsernamePassword,
                _ => null,
            };
        }
    }
}