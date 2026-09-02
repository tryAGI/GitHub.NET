
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Current state of the task, derived from its most recent session
    /// </summary>
    public enum AgentTasksListTasksResponseTaskState
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
    public static class AgentTasksListTasksResponseTaskStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksListTasksResponseTaskState value)
        {
            return value switch
            {
                AgentTasksListTasksResponseTaskState.Cancelled => "cancelled",
                AgentTasksListTasksResponseTaskState.Completed => "completed",
                AgentTasksListTasksResponseTaskState.Failed => "failed",
                AgentTasksListTasksResponseTaskState.Idle => "idle",
                AgentTasksListTasksResponseTaskState.InProgress => "in_progress",
                AgentTasksListTasksResponseTaskState.Queued => "queued",
                AgentTasksListTasksResponseTaskState.TimedOut => "timed_out",
                AgentTasksListTasksResponseTaskState.WaitingForUser => "waiting_for_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksListTasksResponseTaskState? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => AgentTasksListTasksResponseTaskState.Cancelled,
                "completed" => AgentTasksListTasksResponseTaskState.Completed,
                "failed" => AgentTasksListTasksResponseTaskState.Failed,
                "idle" => AgentTasksListTasksResponseTaskState.Idle,
                "in_progress" => AgentTasksListTasksResponseTaskState.InProgress,
                "queued" => AgentTasksListTasksResponseTaskState.Queued,
                "timed_out" => AgentTasksListTasksResponseTaskState.TimedOut,
                "waiting_for_user" => AgentTasksListTasksResponseTaskState.WaitingForUser,
                _ => null,
            };
        }
    }
}