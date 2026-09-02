
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The status of the runner.<br/>
    /// Example: Ready
    /// </summary>
    public enum ActionsHostedRunnerStatus
    {
        /// <summary>
        ///
        /// </summary>
        Deleting,
        /// <summary>
        ///
        /// </summary>
        Provisioning,
        /// <summary>
        ///
        /// </summary>
        Ready,
        /// <summary>
        ///
        /// </summary>
        Shutdown,
        /// <summary>
        ///
        /// </summary>
        Stuck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsHostedRunnerStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsHostedRunnerStatus value)
        {
            return value switch
            {
                ActionsHostedRunnerStatus.Deleting => "Deleting",
                ActionsHostedRunnerStatus.Provisioning => "Provisioning",
                ActionsHostedRunnerStatus.Ready => "Ready",
                ActionsHostedRunnerStatus.Shutdown => "Shutdown",
                ActionsHostedRunnerStatus.Stuck => "Stuck",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsHostedRunnerStatus? ToEnum(string value)
        {
            return value switch
            {
                "Deleting" => ActionsHostedRunnerStatus.Deleting,
                "Provisioning" => ActionsHostedRunnerStatus.Provisioning,
                "Ready" => ActionsHostedRunnerStatus.Ready,
                "Shutdown" => ActionsHostedRunnerStatus.Shutdown,
                "Stuck" => ActionsHostedRunnerStatus.Stuck,
                _ => null,
            };
        }
    }
}