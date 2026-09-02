
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Current state of the task, derived from its most recent session
    /// </summary>
    public enum AgentTasksGetTaskByRepoAndIdResponseVariant1State
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
    public static class AgentTasksGetTaskByRepoAndIdResponseVariant1StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksGetTaskByRepoAndIdResponseVariant1State value)
        {
            return value switch
            {
                AgentTasksGetTaskByRepoAndIdResponseVariant1State.Cancelled => "cancelled",
                AgentTasksGetTaskByRepoAndIdResponseVariant1State.Completed => "completed",
                AgentTasksGetTaskByRepoAndIdResponseVariant1State.Failed => "failed",
                AgentTasksGetTaskByRepoAndIdResponseVariant1State.Idle => "idle",
                AgentTasksGetTaskByRepoAndIdResponseVariant1State.InProgress => "in_progress",
                AgentTasksGetTaskByRepoAndIdResponseVariant1State.Queued => "queued",
                AgentTasksGetTaskByRepoAndIdResponseVariant1State.TimedOut => "timed_out",
                AgentTasksGetTaskByRepoAndIdResponseVariant1State.WaitingForUser => "waiting_for_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksGetTaskByRepoAndIdResponseVariant1State? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => AgentTasksGetTaskByRepoAndIdResponseVariant1State.Cancelled,
                "completed" => AgentTasksGetTaskByRepoAndIdResponseVariant1State.Completed,
                "failed" => AgentTasksGetTaskByRepoAndIdResponseVariant1State.Failed,
                "idle" => AgentTasksGetTaskByRepoAndIdResponseVariant1State.Idle,
                "in_progress" => AgentTasksGetTaskByRepoAndIdResponseVariant1State.InProgress,
                "queued" => AgentTasksGetTaskByRepoAndIdResponseVariant1State.Queued,
                "timed_out" => AgentTasksGetTaskByRepoAndIdResponseVariant1State.TimedOut,
                "waiting_for_user" => AgentTasksGetTaskByRepoAndIdResponseVariant1State.WaitingForUser,
                _ => null,
            };
        }
    }
}