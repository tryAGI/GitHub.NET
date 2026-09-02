
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Current state of the task, derived from its most recent session
    /// </summary>
    public enum AgentTasksGetTaskByIdResponseVariant1State
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
    public static class AgentTasksGetTaskByIdResponseVariant1StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksGetTaskByIdResponseVariant1State value)
        {
            return value switch
            {
                AgentTasksGetTaskByIdResponseVariant1State.Cancelled => "cancelled",
                AgentTasksGetTaskByIdResponseVariant1State.Completed => "completed",
                AgentTasksGetTaskByIdResponseVariant1State.Failed => "failed",
                AgentTasksGetTaskByIdResponseVariant1State.Idle => "idle",
                AgentTasksGetTaskByIdResponseVariant1State.InProgress => "in_progress",
                AgentTasksGetTaskByIdResponseVariant1State.Queued => "queued",
                AgentTasksGetTaskByIdResponseVariant1State.TimedOut => "timed_out",
                AgentTasksGetTaskByIdResponseVariant1State.WaitingForUser => "waiting_for_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksGetTaskByIdResponseVariant1State? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => AgentTasksGetTaskByIdResponseVariant1State.Cancelled,
                "completed" => AgentTasksGetTaskByIdResponseVariant1State.Completed,
                "failed" => AgentTasksGetTaskByIdResponseVariant1State.Failed,
                "idle" => AgentTasksGetTaskByIdResponseVariant1State.Idle,
                "in_progress" => AgentTasksGetTaskByIdResponseVariant1State.InProgress,
                "queued" => AgentTasksGetTaskByIdResponseVariant1State.Queued,
                "timed_out" => AgentTasksGetTaskByIdResponseVariant1State.TimedOut,
                "waiting_for_user" => AgentTasksGetTaskByIdResponseVariant1State.WaitingForUser,
                _ => null,
            };
        }
    }
}