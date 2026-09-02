
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Current state of the task, derived from its most recent session
    /// </summary>
    public enum AgentTasksListTasksForRepoResponseTaskState
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
    public static class AgentTasksListTasksForRepoResponseTaskStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksListTasksForRepoResponseTaskState value)
        {
            return value switch
            {
                AgentTasksListTasksForRepoResponseTaskState.Cancelled => "cancelled",
                AgentTasksListTasksForRepoResponseTaskState.Completed => "completed",
                AgentTasksListTasksForRepoResponseTaskState.Failed => "failed",
                AgentTasksListTasksForRepoResponseTaskState.Idle => "idle",
                AgentTasksListTasksForRepoResponseTaskState.InProgress => "in_progress",
                AgentTasksListTasksForRepoResponseTaskState.Queued => "queued",
                AgentTasksListTasksForRepoResponseTaskState.TimedOut => "timed_out",
                AgentTasksListTasksForRepoResponseTaskState.WaitingForUser => "waiting_for_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksListTasksForRepoResponseTaskState? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => AgentTasksListTasksForRepoResponseTaskState.Cancelled,
                "completed" => AgentTasksListTasksForRepoResponseTaskState.Completed,
                "failed" => AgentTasksListTasksForRepoResponseTaskState.Failed,
                "idle" => AgentTasksListTasksForRepoResponseTaskState.Idle,
                "in_progress" => AgentTasksListTasksForRepoResponseTaskState.InProgress,
                "queued" => AgentTasksListTasksForRepoResponseTaskState.Queued,
                "timed_out" => AgentTasksListTasksForRepoResponseTaskState.TimedOut,
                "waiting_for_user" => AgentTasksListTasksForRepoResponseTaskState.WaitingForUser,
                _ => null,
            };
        }
    }
}