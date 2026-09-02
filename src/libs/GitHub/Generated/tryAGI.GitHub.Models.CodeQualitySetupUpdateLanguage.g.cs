
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum CodeQualitySetupUpdateLanguage
    {
        /// <summary>
        ///
        /// </summary>
        Csharp,
        /// <summary>
        ///
        /// </summary>
        Go,
        /// <summary>
        ///
        /// </summary>
        JavaKotlin,
        /// <summary>
        ///
        /// </summary>
        JavascriptTypescript,
        /// <summary>
        ///
        /// </summary>
        Python,
        /// <summary>
        ///
        /// </summary>
        Ruby,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeQualitySetupUpdateLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeQualitySetupUpdateLanguage value)
        {
            return value switch
            {
                CodeQualitySetupUpdateLanguage.Csharp => "csharp",
                CodeQualitySetupUpdateLanguage.Go => "go",
                CodeQualitySetupUpdateLanguage.JavaKotlin => "java-kotlin",
                CodeQualitySetupUpdateLanguage.JavascriptTypescript => "javascript-typescript",
                CodeQualitySetupUpdateLanguage.Python => "python",
                CodeQualitySetupUpdateLanguage.Ruby => "ruby",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeQualitySetupUpdateLanguage? ToEnum(string value)
        {
            return value switch
            {
                "csharp" => CodeQualitySetupUpdateLanguage.Csharp,
                "go" => CodeQualitySetupUpdateLanguage.Go,
                "java-kotlin" => CodeQualitySetupUpdateLanguage.JavaKotlin,
                "javascript-typescript" => CodeQualitySetupUpdateLanguage.JavascriptTypescript,
                "python" => CodeQualitySetupUpdateLanguage.Python,
                "ruby" => CodeQualitySetupUpdateLanguage.Ruby,
                _ => null,
            };
        }
    }
}