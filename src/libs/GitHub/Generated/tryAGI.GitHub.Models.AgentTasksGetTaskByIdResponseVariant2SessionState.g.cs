
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Current state of a session
    /// </summary>
    public enum AgentTasksGetTaskByIdResponseVariant2SessionState
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
    public static class AgentTasksGetTaskByIdResponseVariant2SessionStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksGetTaskByIdResponseVariant2SessionState value)
        {
            return value switch
            {
                AgentTasksGetTaskByIdResponseVariant2SessionState.Cancelled => "cancelled",
                AgentTasksGetTaskByIdResponseVariant2SessionState.Completed => "completed",
                AgentTasksGetTaskByIdResponseVariant2SessionState.Failed => "failed",
                AgentTasksGetTaskByIdResponseVariant2SessionState.Idle => "idle",
                AgentTasksGetTaskByIdResponseVariant2SessionState.InProgress => "in_progress",
                AgentTasksGetTaskByIdResponseVariant2SessionState.Queued => "queued",
                AgentTasksGetTaskByIdResponseVariant2SessionState.TimedOut => "timed_out",
                AgentTasksGetTaskByIdResponseVariant2SessionState.WaitingForUser => "waiting_for_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksGetTaskByIdResponseVariant2SessionState? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => AgentTasksGetTaskByIdResponseVariant2SessionState.Cancelled,
                "completed" => AgentTasksGetTaskByIdResponseVariant2SessionState.Completed,
                "failed" => AgentTasksGetTaskByIdResponseVariant2SessionState.Failed,
                "idle" => AgentTasksGetTaskByIdResponseVariant2SessionState.Idle,
                "in_progress" => AgentTasksGetTaskByIdResponseVariant2SessionState.InProgress,
                "queued" => AgentTasksGetTaskByIdResponseVariant2SessionState.Queued,
                "timed_out" => AgentTasksGetTaskByIdResponseVariant2SessionState.TimedOut,
                "waiting_for_user" => AgentTasksGetTaskByIdResponseVariant2SessionState.WaitingForUser,
                _ => null,
            };
        }
    }
}