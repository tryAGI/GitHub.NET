
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// What to do with alerts associated with the deleted patterns.<br/>
    /// `delete_alerts` permanently removes the alerts.<br/>
    /// `resolve_alerts` resolves the alerts as "pattern deleted".<br/>
    /// Defaults to `delete_alerts` when not specified.<br/>
    /// Default Value: delete_alerts
    /// </summary>
    public enum SecretScanningBulkDeleteRepoCustomPatternsRequestPostDeleteAction
    {
        /// <summary>
        ///
        /// </summary>
        DeleteAlerts,
        /// <summary>
        ///
        /// </summary>
        ResolveAlerts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningBulkDeleteRepoCustomPatternsRequestPostDeleteActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningBulkDeleteRepoCustomPatternsRequestPostDeleteAction value)
        {
            return value switch
            {
                SecretScanningBulkDeleteRepoCustomPatternsRequestPostDeleteAction.DeleteAlerts => "delete_alerts",
                SecretScanningBulkDeleteRepoCustomPatternsRequestPostDeleteAction.ResolveAlerts => "resolve_alerts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningBulkDeleteRepoCustomPatternsRequestPostDeleteAction? ToEnum(string value)
        {
            return value switch
            {
                "delete_alerts" => SecretScanningBulkDeleteRepoCustomPatternsRequestPostDeleteAction.DeleteAlerts,
                "resolve_alerts" => SecretScanningBulkDeleteRepoCustomPatternsRequestPostDeleteAction.ResolveAlerts,
                _ => null,
            };
        }
    }
}