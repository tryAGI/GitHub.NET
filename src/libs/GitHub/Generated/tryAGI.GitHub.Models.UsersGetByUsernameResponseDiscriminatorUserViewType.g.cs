
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum UsersGetByUsernameResponseDiscriminatorUserViewType
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
    public static class UsersGetByUsernameResponseDiscriminatorUserViewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsersGetByUsernameResponseDiscriminatorUserViewType value)
        {
            return value switch
            {
                UsersGetByUsernameResponseDiscriminatorUserViewType.Private => "private",
                UsersGetByUsernameResponseDiscriminatorUserViewType.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsersGetByUsernameResponseDiscriminatorUserViewType? ToEnum(string value)
        {
            return value switch
            {
                "private" => UsersGetByUsernameResponseDiscriminatorUserViewType.Private,
                "public" => UsersGetByUsernameResponseDiscriminatorUserViewType.Public,
                _ => null,
            };
        }
    }
}