
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The level of authentication required before a pull request can be merged.
    /// </summary>
    public enum RepositoryRuleParamsProofOfPresenceRequiredAuthenticationLevel
    {
        /// <summary>
        ///
        /// </summary>
        Mfa,
        /// <summary>
        ///
        /// </summary>
        Reauth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleParamsProofOfPresenceRequiredAuthenticationLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleParamsProofOfPresenceRequiredAuthenticationLevel value)
        {
            return value switch
            {
                RepositoryRuleParamsProofOfPresenceRequiredAuthenticationLevel.Mfa => "mfa",
                RepositoryRuleParamsProofOfPresenceRequiredAuthenticationLevel.Reauth => "reauth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleParamsProofOfPresenceRequiredAuthenticationLevel? ToEnum(string value)
        {
            return value switch
            {
                "mfa" => RepositoryRuleParamsProofOfPresenceRequiredAuthenticationLevel.Mfa,
                "reauth" => RepositoryRuleParamsProofOfPresenceRequiredAuthenticationLevel.Reauth,
                _ => null,
            };
        }
    }
}