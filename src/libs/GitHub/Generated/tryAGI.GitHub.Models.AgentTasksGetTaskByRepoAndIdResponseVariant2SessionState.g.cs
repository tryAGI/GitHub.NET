
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Current state of a session
    /// </summary>
    public enum AgentTasksGetTaskByRepoAndIdResponseVariant2SessionState
    {
        /// <summary>
        ///
        /// </summary>
        Cancelled,
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Idle,
        /// <summary>
        ///
        /// </summary>
        InProgress,
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        ///
        /// </summary>
        TimedOut,
        /// <summary>
        ///
        /// </summary>
        WaitingForUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTasksGetTaskByRepoAndIdResponseVariant2SessionStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksGetTaskByRepoAndIdResponseVariant2SessionState value)
        {
            return value switch
            {
                AgentTasksGetTaskByRepoAndIdResponseVariant2SessionState.Cancelled => "cancelled",
                AgentTasksGetTaskByRepoAndIdResponseVariant2SessionState.Completed => "completed",
                AgentTasksGetTaskByRepoAndIdResponseVariant2SessionState.Failed => "failed",
                AgentTasksGetTaskByRepoAndIdResponseVariant2SessionState.Idle => "idle",
                AgentTasksGetTaskByRepoAndIdResponseVariant2SessionState.InProgress => "in_progress",
                AgentTasksGetTaskByRepoAndIdResponseVariant2SessionState.Queued => "queued",
                AgentTasksGetTaskByRepoAndIdResponseVariant2SessionState.TimedOut => "timed_out",
                AgentTasksGetTaskByRepoAndIdResponseVariant2SessionState.WaitingForUser => "waiting_for_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksGetTaskByRepoAndIdResponseVariant2SessionState? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => AgentTasksGetTaskByRepoAndIdResponseVariant2SessionState.Cancelled,
                "completed" => AgentTasksGetTaskByRepoAndIdResponseVariant2SessionState.Completed,
                "failed" => AgentTasksGetTaskByRepoAndIdResponseVariant2SessionState.Failed,
                "idle" => AgentTasksGetTaskByRepoAndIdResponseVariant2SessionState.Idle,
                "in_progress" => AgentTasksGetTaskByRepoAndIdResponseVariant2SessionState.InProgress,
                "queued" => AgentTasksGetTaskByRepoAndIdResponseVariant2SessionState.Queued,
                "timed_out" => AgentTasksGetTaskByRepoAndIdResponseVariant2SessionState.TimedOut,
                "waiting_for_user" => AgentTasksGetTaskByRepoAndIdResponseVariant2SessionState.WaitingForUser,
                _ => null,
            };
        }
    }
}