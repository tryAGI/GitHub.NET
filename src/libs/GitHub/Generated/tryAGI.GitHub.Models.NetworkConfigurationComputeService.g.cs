
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The hosted compute service the network configuration supports.
    /// </summary>
    public enum NetworkConfigurationComputeService
    {
        /// <summary>
        ///
        /// </summary>
        Actions,
        /// <summary>
        ///
        /// </summary>
        Codespaces,
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NetworkConfigurationComputeServiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NetworkConfigurationComputeService value)
        {
            return value switch
            {
                NetworkConfigurationComputeService.Actions => "actions",
                NetworkConfigurationComputeService.Codespaces => "codespaces",
                NetworkConfigurationComputeService.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NetworkConfigurationComputeService? ToEnum(string value)
        {
            return value switch
            {
                "actions" => NetworkConfigurationComputeService.Actions,
                "codespaces" => NetworkConfigurationComputeService.Codespaces,
                "none" => NetworkConfigurationComputeService.None,
                _ => null,
            };
        }
    }
}