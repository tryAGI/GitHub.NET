#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.GitHub.JsonConverters
{
    /// <inheritdoc />
    public class OrgRulesetConditionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.GitHub.OrgRulesetConditions>
    {
        /// <inheritdoc />
        public override global::tryAGI.GitHub.OrgRulesetConditions Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score0++;
                    }
                }
            }
            var __score1 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __score2 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score2++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>? repositoryNameAndRefName = default;
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>? repositoryIdAndRefName = default;
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>? repositoryPropertyAndRefName = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>).Name}");
                        repositoryNameAndRefName = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 1)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>).Name}");
                        repositoryIdAndRefName = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 2)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>).Name}");
                        repositoryPropertyAndRefName = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (repositoryNameAndRefName == null && repositoryIdAndRefName == null && repositoryPropertyAndRefName == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>).Name}");
                    repositoryNameAndRefName = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (repositoryNameAndRefName == null && repositoryIdAndRefName == null && repositoryPropertyAndRefName == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>).Name}");
                    repositoryIdAndRefName = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (repositoryNameAndRefName == null && repositoryIdAndRefName == null && repositoryPropertyAndRefName == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>).Name}");
                    repositoryPropertyAndRefName = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.GitHub.OrgRulesetConditions(
                repositoryNameAndRefName,

                repositoryIdAndRefName,

                repositoryPropertyAndRefName
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.GitHub.OrgRulesetConditions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRepositoryNameAndRefName)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryNameAndRefName!.Value, typeInfo);
            }
            else if (value.IsRepositoryIdAndRefName)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryIdAndRefName!.Value, typeInfo);
            }
            else if (value.IsRepositoryPropertyAndRefName)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepositoryPropertyAndRefName!.Value, typeInfo);
            }
        }
    }
}