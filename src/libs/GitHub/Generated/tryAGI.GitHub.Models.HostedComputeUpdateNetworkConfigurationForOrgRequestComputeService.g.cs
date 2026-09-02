
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The hosted compute service to use for the network configuration.
    /// </summary>
    public enum HostedComputeUpdateNetworkConfigurationForOrgRequestComputeService
    {
        /// <summary>
        ///
        /// </summary>
        Actions,
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedComputeUpdateNetworkConfigurationForOrgRequestComputeServiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedComputeUpdateNetworkConfigurationForOrgRequestComputeService value)
        {
            return value switch
            {
                HostedComputeUpdateNetworkConfigurationForOrgRequestComputeService.Actions => "actions",
                HostedComputeUpdateNetworkConfigurationForOrgRequestComputeService.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedComputeUpdateNetworkConfigurationForOrgRequestComputeService? ToEnum(string value)
        {
            return value switch
            {
                "actions" => HostedComputeUpdateNetworkConfigurationForOrgRequestComputeService.Actions,
                "none" => HostedComputeUpdateNetworkConfigurationForOrgRequestComputeService.None,
                _ => null,
            };
        }
    }
}