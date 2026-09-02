#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.GitHub.JsonConverters
{
    /// <inheritdoc />
    public class UsersGetByUsernameResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.GitHub.UsersGetByUsernameResponse>
    {
        /// <inheritdoc />
        public override global::tryAGI.GitHub.UsersGetByUsernameResponse Read(
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
            if (__jsonProps.Contains("avatar_url")) __score0++;
            if (__jsonProps.Contains("bio")) __score0++;
            if (__jsonProps.Contains("blog")) __score0++;
            if (__jsonProps.Contains("business_plus")) __score0++;
            if (__jsonProps.Contains("collaborators")) __score0++;
            if (__jsonProps.Contains("company")) __score0++;
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("disk_usage")) __score0++;
            if (__jsonProps.Contains("email")) __score0++;
            if (__jsonProps.Contains("events_url")) __score0++;
            if (__jsonProps.Contains("followers")) __score0++;
            if (__jsonProps.Contains("followers_url")) __score0++;
            if (__jsonProps.Contains("following")) __score0++;
            if (__jsonProps.Contains("following_url")) __score0++;
            if (__jsonProps.Contains("gists_url")) __score0++;
            if (__jsonProps.Contains("gravatar_id")) __score0++;
            if (__jsonProps.Contains("hireable")) __score0++;
            if (__jsonProps.Contains("html_url")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("ldap_dn")) __score0++;
            if (__jsonProps.Contains("location")) __score0++;
            if (__jsonProps.Contains("login")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("node_id")) __score0++;
            if (__jsonProps.Contains("notification_email")) __score0++;
            if (__jsonProps.Contains("organizations_url")) __score0++;
            if (__jsonProps.Contains("owned_private_repos")) __score0++;
            if (__jsonProps.Contains("plan")) __score0++;
            if (__jsonProps.Contains("plan.collaborators")) __score0++;
            if (__jsonProps.Contains("plan.name")) __score0++;
            if (__jsonProps.Contains("plan.private_repos")) __score0++;
            if (__jsonProps.Contains("plan.space")) __score0++;
            if (__jsonProps.Contains("private_gists")) __score0++;
            if (__jsonProps.Contains("public_gists")) __score0++;
            if (__jsonProps.Contains("public_repos")) __score0++;
            if (__jsonProps.Contains("received_events_url")) __score0++;
            if (__jsonProps.Contains("repos_url")) __score0++;
            if (__jsonProps.Contains("site_admin")) __score0++;
            if (__jsonProps.Contains("starred_url")) __score0++;
            if (__jsonProps.Contains("subscriptions_url")) __score0++;
            if (__jsonProps.Contains("total_private_repos")) __score0++;
            if (__jsonProps.Contains("twitter_username")) __score0++;
            if (__jsonProps.Contains("two_factor_authentication")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("updated_at")) __score0++;
            if (__jsonProps.Contains("url")) __score0++;
            if (__jsonProps.Contains("user_view_type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("avatar_url")) __score1++;
            if (__jsonProps.Contains("bio")) __score1++;
            if (__jsonProps.Contains("blog")) __score1++;
            if (__jsonProps.Contains("collaborators")) __score1++;
            if (__jsonProps.Contains("company")) __score1++;
            if (__jsonProps.Contains("created_at")) __score1++;
            if (__jsonProps.Contains("disk_usage")) __score1++;
            if (__jsonProps.Contains("email")) __score1++;
            if (__jsonProps.Contains("events_url")) __score1++;
            if (__jsonProps.Contains("followers")) __score1++;
            if (__jsonProps.Contains("followers_url")) __score1++;
            if (__jsonProps.Contains("following")) __score1++;
            if (__jsonProps.Contains("following_url")) __score1++;
            if (__jsonProps.Contains("gists_url")) __score1++;
            if (__jsonProps.Contains("gravatar_id")) __score1++;
            if (__jsonProps.Contains("hireable")) __score1++;
            if (__jsonProps.Contains("html_url")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("location")) __score1++;
            if (__jsonProps.Contains("login")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("node_id")) __score1++;
            if (__jsonProps.Contains("notification_email")) __score1++;
            if (__jsonProps.Contains("organizations_url")) __score1++;
            if (__jsonProps.Contains("owned_private_repos")) __score1++;
            if (__jsonProps.Contains("plan")) __score1++;
            if (__jsonProps.Contains("plan.collaborators")) __score1++;
            if (__jsonProps.Contains("plan.name")) __score1++;
            if (__jsonProps.Contains("plan.private_repos")) __score1++;
            if (__jsonProps.Contains("plan.space")) __score1++;
            if (__jsonProps.Contains("private_gists")) __score1++;
            if (__jsonProps.Contains("public_gists")) __score1++;
            if (__jsonProps.Contains("public_repos")) __score1++;
            if (__jsonProps.Contains("received_events_url")) __score1++;
            if (__jsonProps.Contains("repos_url")) __score1++;
            if (__jsonProps.Contains("site_admin")) __score1++;
            if (__jsonProps.Contains("starred_url")) __score1++;
            if (__jsonProps.Contains("subscriptions_url")) __score1++;
            if (__jsonProps.Contains("total_private_repos")) __score1++;
            if (__jsonProps.Contains("twitter_username")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("updated_at")) __score1++;
            if (__jsonProps.Contains("url")) __score1++;
            if (__jsonProps.Contains("user_view_type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::tryAGI.GitHub.PrivateUser? privateUser = default;
            global::tryAGI.GitHub.PublicUser? publicUser = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.PrivateUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.PrivateUser> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.PrivateUser).Name}");
                        privateUser = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.PublicUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.PublicUser> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.PublicUser).Name}");
                        publicUser = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (privateUser == null && publicUser == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.PrivateUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.PrivateUser> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.PrivateUser).Name}");
                    privateUser = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (privateUser == null && publicUser == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.PublicUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.PublicUser> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.PublicUser).Name}");
                    publicUser = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.GitHub.UsersGetByUsernameResponse(
                privateUser,

                publicUser
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.GitHub.UsersGetByUsernameResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPrivateUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.PrivateUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.PrivateUser?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.PrivateUser).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PrivateUser!, typeInfo);
            }
            else if (value.IsPublicUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.PublicUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.PublicUser?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.PublicUser).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PublicUser!, typeInfo);
            }
        }
    }
}