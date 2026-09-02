
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum CodeQualitySetupLanguage
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
        /// <summary>
        ///
        /// </summary>
        Rust,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeQualitySetupLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeQualitySetupLanguage value)
        {
            return value switch
            {
                CodeQualitySetupLanguage.Csharp => "csharp",
                CodeQualitySetupLanguage.Go => "go",
                CodeQualitySetupLanguage.JavaKotlin => "java-kotlin",
                CodeQualitySetupLanguage.JavascriptTypescript => "javascript-typescript",
                CodeQualitySetupLanguage.Python => "python",
                CodeQualitySetupLanguage.Ruby => "ruby",
                CodeQualitySetupLanguage.Rust => "rust",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeQualitySetupLanguage? ToEnum(string value)
        {
            return value switch
            {
                "csharp" => CodeQualitySetupLanguage.Csharp,
                "go" => CodeQualitySetupLanguage.Go,
                "java-kotlin" => CodeQualitySetupLanguage.JavaKotlin,
                "javascript-typescript" => CodeQualitySetupLanguage.JavascriptTypescript,
                "python" => CodeQualitySetupLanguage.Python,
                "ruby" => CodeQualitySetupLanguage.Ruby,
                "rust" => CodeQualitySetupLanguage.Rust,
                _ => null,
            };
        }
    }
}