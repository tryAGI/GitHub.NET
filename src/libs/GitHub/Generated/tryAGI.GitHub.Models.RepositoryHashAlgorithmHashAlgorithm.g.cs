
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The Git hash algorithm used by this repository.<br/>
    /// Example: sha1
    /// </summary>
    public enum RepositoryHashAlgorithmHashAlgorithm
    {
        /// <summary>
        ///
        /// </summary>
        Sha1,
        /// <summary>
        ///
        /// </summary>
        Sha256,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryHashAlgorithmHashAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryHashAlgorithmHashAlgorithm value)
        {
            return value switch
            {
                RepositoryHashAlgorithmHashAlgorithm.Sha1 => "sha1",
                RepositoryHashAlgorithmHashAlgorithm.Sha256 => "sha256",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryHashAlgorithmHashAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "sha1" => RepositoryHashAlgorithmHashAlgorithm.Sha1,
                "sha256" => RepositoryHashAlgorithmHashAlgorithm.Sha256,
                _ => null,
            };
        }
    }
}