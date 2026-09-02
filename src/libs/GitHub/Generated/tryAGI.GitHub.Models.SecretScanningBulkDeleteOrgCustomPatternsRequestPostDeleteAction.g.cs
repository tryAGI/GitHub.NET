
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
    public enum SecretScanningBulkDeleteOrgCustomPatternsRequestPostDeleteAction
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
    public static class SecretScanningBulkDeleteOrgCustomPatternsRequestPostDeleteActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningBulkDeleteOrgCustomPatternsRequestPostDeleteAction value)
        {
            return value switch
            {
                SecretScanningBulkDeleteOrgCustomPatternsRequestPostDeleteAction.DeleteAlerts => "delete_alerts",
                SecretScanningBulkDeleteOrgCustomPatternsRequestPostDeleteAction.ResolveAlerts => "resolve_alerts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningBulkDeleteOrgCustomPatternsRequestPostDeleteAction? ToEnum(string value)
        {
            return value switch
            {
                "delete_alerts" => SecretScanningBulkDeleteOrgCustomPatternsRequestPostDeleteAction.DeleteAlerts,
                "resolve_alerts" => SecretScanningBulkDeleteOrgCustomPatternsRequestPostDeleteAction.ResolveAlerts,
                _ => null,
            };
        }
    }
}