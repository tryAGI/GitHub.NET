
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum UsersGetByIdResponseDiscriminatorUserViewType
    {
        /// <summary>
        ///
        /// </summary>
        Private,
        /// <summary>
        ///
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsersGetByIdResponseDiscriminatorUserViewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsersGetByIdResponseDiscriminatorUserViewType value)
        {
            return value switch
            {
                UsersGetByIdResponseDiscriminatorUserViewType.Private => "private",
                UsersGetByIdResponseDiscriminatorUserViewType.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsersGetByIdResponseDiscriminatorUserViewType? ToEnum(string value)
        {
            return value switch
            {
                "private" => UsersGetByIdResponseDiscriminatorUserViewType.Private,
                "public" => UsersGetByIdResponseDiscriminatorUserViewType.Public,
                _ => null,
            };
        }
    }
}