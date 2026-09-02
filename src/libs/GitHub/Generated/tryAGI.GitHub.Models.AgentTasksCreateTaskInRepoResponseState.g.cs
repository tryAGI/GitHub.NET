
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Current state of the task, derived from its most recent session
    /// </summary>
    public enum AgentTasksCreateTaskInRepoResponseState
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
    public static class AgentTasksCreateTaskInRepoResponseStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksCreateTaskInRepoResponseState value)
        {
            return value switch
            {
                AgentTasksCreateTaskInRepoResponseState.Cancelled => "cancelled",
                AgentTasksCreateTaskInRepoResponseState.Completed => "completed",
                AgentTasksCreateTaskInRepoResponseState.Failed => "failed",
                AgentTasksCreateTaskInRepoResponseState.Idle => "idle",
                AgentTasksCreateTaskInRepoResponseState.InProgress => "in_progress",
                AgentTasksCreateTaskInRepoResponseState.Queued => "queued",
                AgentTasksCreateTaskInRepoResponseState.TimedOut => "timed_out",
                AgentTasksCreateTaskInRepoResponseState.WaitingForUser => "waiting_for_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksCreateTaskInRepoResponseState? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => AgentTasksCreateTaskInRepoResponseState.Cancelled,
                "completed" => AgentTasksCreateTaskInRepoResponseState.Completed,
                "failed" => AgentTasksCreateTaskInRepoResponseState.Failed,
                "idle" => AgentTasksCreateTaskInRepoResponseState.Idle,
                "in_progress" => AgentTasksCreateTaskInRepoResponseState.InProgress,
                "queued" => AgentTasksCreateTaskInRepoResponseState.Queued,
                "timed_out" => AgentTasksCreateTaskInRepoResponseState.TimedOut,
                "waiting_for_user" => AgentTasksCreateTaskInRepoResponseState.WaitingForUser,
                _ => null,
            };
        }
    }
}