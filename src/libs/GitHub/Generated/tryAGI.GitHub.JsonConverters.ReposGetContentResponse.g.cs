#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.GitHub.JsonConverters
{
    /// <inheritdoc />
    public class ReposGetContentResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.GitHub.ReposGetContentResponse>
    {
        /// <inheritdoc />
        public override global::tryAGI.GitHub.ReposGetContentResponse Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            var __score1 = 0;
            if (__jsonProps.Contains("_links")) __score1++;
            if (__jsonProps.Contains("_links.git")) __score1++;
            if (__jsonProps.Contains("_links.html")) __score1++;
            if (__jsonProps.Contains("_links.self")) __score1++;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("download_url")) __score1++;
            if (__jsonProps.Contains("encoding")) __score1++;
            if (__jsonProps.Contains("git_url")) __score1++;
            if (__jsonProps.Contains("html_url")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("path")) __score1++;
            if (__jsonProps.Contains("sha")) __score1++;
            if (__jsonProps.Contains("size")) __score1++;
            if (__jsonProps.Contains("submodule_git_url")) __score1++;
            if (__jsonProps.Contains("target")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("url")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("_links")) __score2++;
            if (__jsonProps.Contains("_links.git")) __score2++;
            if (__jsonProps.Contains("_links.html")) __score2++;
            if (__jsonProps.Contains("_links.self")) __score2++;
            if (__jsonProps.Contains("download_url")) __score2++;
            if (__jsonProps.Contains("git_url")) __score2++;
            if (__jsonProps.Contains("html_url")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("path")) __score2++;
            if (__jsonProps.Contains("sha")) __score2++;
            if (__jsonProps.Contains("size")) __score2++;
            if (__jsonProps.Contains("target")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("url")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("_links")) __score3++;
            if (__jsonProps.Contains("_links.git")) __score3++;
            if (__jsonProps.Contains("_links.html")) __score3++;
            if (__jsonProps.Contains("_links.self")) __score3++;
            if (__jsonProps.Contains("download_url")) __score3++;
            if (__jsonProps.Contains("git_url")) __score3++;
            if (__jsonProps.Contains("html_url")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("path")) __score3++;
            if (__jsonProps.Contains("sha")) __score3++;
            if (__jsonProps.Contains("size")) __score3++;
            if (__jsonProps.Contains("submodule_git_url")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("url")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::System.Collections.Generic.IList<global::tryAGI.GitHub.ContentDirectoryItem>? contentDirectory = default;
            global::tryAGI.GitHub.ContentFile? file = default;
            global::tryAGI.GitHub.ContentSymlink? symlink = default;
            global::tryAGI.GitHub.ContentSubmodule? submodule = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::tryAGI.GitHub.ContentDirectoryItem>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::tryAGI.GitHub.ContentDirectoryItem>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::tryAGI.GitHub.ContentDirectoryItem>).Name}");
                        contentDirectory = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ContentFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ContentFile> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ContentFile).Name}");
                        file = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ContentSymlink), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ContentSymlink> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ContentSymlink).Name}");
                        symlink = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ContentSubmodule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ContentSubmodule> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ContentSubmodule).Name}");
                        submodule = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (contentDirectory == null && file == null && symlink == null && submodule == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::tryAGI.GitHub.ContentDirectoryItem>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::tryAGI.GitHub.ContentDirectoryItem>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::tryAGI.GitHub.ContentDirectoryItem>).Name}");
                    contentDirectory = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (contentDirectory == null && file == null && symlink == null && submodule == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ContentFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ContentFile> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ContentFile).Name}");
                    file = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (contentDirectory == null && file == null && symlink == null && submodule == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ContentSymlink), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ContentSymlink> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ContentSymlink).Name}");
                    symlink = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (contentDirectory == null && file == null && symlink == null && submodule == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ContentSubmodule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ContentSubmodule> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ContentSubmodule).Name}");
                    submodule = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.GitHub.ReposGetContentResponse(
                contentDirectory,

                file,

                symlink,

                submodule
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.GitHub.ReposGetContentResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsContentDirectory)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::tryAGI.GitHub.ContentDirectoryItem>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::tryAGI.GitHub.ContentDirectoryItem>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::tryAGI.GitHub.ContentDirectoryItem>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentDirectory!, typeInfo);
            }
            else if (value.IsFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ContentFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ContentFile?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ContentFile).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.File!, typeInfo);
            }
            else if (value.IsSymlink)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ContentSymlink), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ContentSymlink?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ContentSymlink).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Symlink!, typeInfo);
            }
            else if (value.IsSubmodule)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ContentSubmodule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ContentSubmodule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ContentSubmodule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Submodule!, typeInfo);
            }
        }
    }
}