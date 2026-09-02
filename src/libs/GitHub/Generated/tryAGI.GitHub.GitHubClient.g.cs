
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// GitHub's v3 REST API.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class GitHubClient : global::tryAGI.GitHub.IGitHubClient, global::System.IDisposable
    {
        /// <summary>
        ///
        /// </summary>
        public const string DefaultBaseUrl = "https://api.github.com/";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => ResolveDisplayedBaseUri();

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::tryAGI.GitHub.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::tryAGI.GitHub.AutoSDKClientOptions Options { get; }


        internal global::tryAGI.GitHub.AutoSDKServerConfiguration AutoSDKServerConfiguration { get; set; } = new global::tryAGI.GitHub.AutoSDKServerConfiguration();

        internal global::System.Lazy<global::System.Text.Json.Serialization.JsonSerializerContext> JsonSerializerContextProvider { get; set; } = new(() => global::tryAGI.GitHub.SourceGenerationContext.Default);

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext
        {
            get => JsonSerializerContextProvider.Value;
            set => JsonSerializerContextProvider = new(() => value);
        }


        /// <summary>
        /// Endpoints to manage GitHub Actions using the REST API.
        /// </summary>
        public ActionsClient Actions => new ActionsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Activity APIs provide access to notifications, subscriptions, and timelines.
        /// </summary>
        public ActivityClient Activity => new ActivityClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Endpoints to manage and interact with agent tasks.
        /// </summary>
        public AgentTasksClient AgentTasks => new AgentTasksClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Endpoints for Agents secrets and variables.
        /// </summary>
        public AgentsClient Agents => new AgentsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Information for integrations and installations.
        /// </summary>
        public AppsClient Apps => new AppsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Monitor charges and usage from Actions and Packages.
        /// </summary>
        public BillingClient Billing => new BillingClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Endpoints to manage campaigns via the REST API.
        /// </summary>
        public CampaignsClient Campaigns => new CampaignsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Rich interactions with checks run by your integrations.
        /// </summary>
        public ChecksClient Checks => new ChecksClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Insights into reliability, maintainability, and efficiency of your codebase.
        /// </summary>
        public CodeQualityClient CodeQuality => new CodeQualityClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Retrieve code scanning alerts from a repository.
        /// </summary>
        public CodeScanningClient CodeScanning => new CodeScanningClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Endpoints to manage Code security using the REST API.
        /// </summary>
        public CodeSecurityClient CodeSecurity => new CodeSecurityClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Insight into codes of conduct for your communities.
        /// </summary>
        public CodesOfConductClient CodesOfConduct => new CodesOfConductClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Endpoints to manage Codespaces using the REST API.
        /// </summary>
        public CodespacesClient Codespaces => new CodespacesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Endpoints to manage Copilot using the REST API.
        /// </summary>
        public CopilotClient Copilot => new CopilotClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Endpoints to manage Copilot Spaces using the REST API.
        /// </summary>
        public CopilotSpacesClient CopilotSpaces => new CopilotSpacesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Revoke compromised or leaked GitHub credentials.
        /// </summary>
        public CredentialsClient Credentials => new CredentialsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Endpoints to manage Dependabot.
        /// </summary>
        public DependabotClient Dependabot => new DependabotClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Endpoints to access Dependency Graph features.
        /// </summary>
        public DependencyGraphClient DependencyGraph => new DependencyGraphClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// List emojis available to use on GitHub.
        /// </summary>
        public EmojisClient Emojis => new EmojisClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Endpoints to manage GitHub Enterprise Team memberships.
        /// </summary>
        public EnterpriseTeamMembershipsClient EnterpriseTeamMemberships => new EnterpriseTeamMembershipsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Endpoints to manage GitHub Enterprise Team organization assignments.
        /// </summary>
        public EnterpriseTeamOrganizationsClient EnterpriseTeamOrganizations => new EnterpriseTeamOrganizationsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Endpoints to manage GitHub Enterprise Teams.
        /// </summary>
        public EnterpriseTeamsClient EnterpriseTeams => new EnterpriseTeamsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// View, modify your gists.
        /// </summary>
        public GistsClient Gists => new GistsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Raw Git functionality.
        /// </summary>
        public GitClient Git => new GitClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// View gitignore templates.
        /// </summary>
        public GitignoreClient Gitignore => new GitignoreClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Manage hosted compute networking resources.
        /// </summary>
        public HostedComputeClient HostedCompute => new HostedComputeClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Owner or admin management of users interactions.
        /// </summary>
        public InteractionsClient Interactions => new InteractionsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Interact with GitHub Issues.
        /// </summary>
        public IssuesClient Issues => new IssuesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// View various OSS licenses.
        /// </summary>
        public LicensesClient Licenses => new LicensesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Render GitHub flavored Markdown.
        /// </summary>
        public MarkdownClient Markdown => new MarkdownClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Endpoints that give information about the API.
        /// </summary>
        public MetaClient Meta => new MetaClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Move projects to or from GitHub.
        /// </summary>
        public MigrationsClient Migrations => new MigrationsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Endpoints to manage GitHub OIDC configuration using the REST API.
        /// </summary>
        public OidcClient Oidc => new OidcClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Interact with organizations.
        /// </summary>
        public OrgsClient Orgs => new OrgsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Manage packages for authenticated users and organizations.
        /// </summary>
        public PackagesClient Packages => new PackagesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Manage private registry configurations.
        /// </summary>
        public PrivateRegistriesClient PrivateRegistries => new PrivateRegistriesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Endpoints to manage Projects using the REST API.
        /// </summary>
        public ProjectsClient Projects => new ProjectsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Interact with GitHub Pull Requests.
        /// </summary>
        public PullsClient Pulls => new PullsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Check your current rate limit status.
        /// </summary>
        public RateLimitClient RateLimit => new RateLimitClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Interact with reactions to various GitHub entities.
        /// </summary>
        public ReactionsClient Reactions => new ReactionsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Interact with GitHub Repos.
        /// </summary>
        public ReposClient Repos => new ReposClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Search for specific items on GitHub.
        /// </summary>
        public SearchClient Search => new SearchClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Retrieve secret scanning alerts from a repository.
        /// </summary>
        public SecretScanningClient SecretScanning => new SecretScanningClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Manage security advisories.
        /// </summary>
        public SecurityAdvisoriesClient SecurityAdvisories => new SecurityAdvisoriesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Interact with GitHub Teams.
        /// </summary>
        public TeamsClient Teams => new TeamsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Interact with and view information about users and also current user.
        /// </summary>
        public UsersClient Users => new UsersClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };


        private static readonly global::tryAGI.GitHub.AutoSDKServer[] s_availableServers = new global::tryAGI.GitHub.AutoSDKServer[]
        {            new global::tryAGI.GitHub.AutoSDKServer(
                id: "https-api-github-com",
                name: "api.github.com",
                url: "https://api.github.com/",
                description: ""),
            new global::tryAGI.GitHub.AutoSDKServer(
                id: "https-uploads-github-com",
                name: "The URL origin (protocol + host name + port) is included in `upload_url` returned in the response of the \"Create a release\" endpoint",
                url: "https://uploads.github.com/",
                description: "The URL origin (protocol + host name + port) is included in `upload_url` returned in the response of the \"Create a release\" endpoint"),
        };

        /// <summary>
        /// The server options available for this client.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::tryAGI.GitHub.AutoSDKServer> AvailableServers => s_availableServers;

        /// <summary>
        /// The currently selected server for this client, if any.
        /// </summary>
        public global::tryAGI.GitHub.AutoSDKServer? SelectedServer
        {
            get => ResolveSelectedServer();
            set => SelectServer(value);
        }

        /// <summary>
        /// Creates a new instance of the GitHubClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public GitHubClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::tryAGI.GitHub.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the GitHubClient with explicit options but no base URL override.
        /// Skips passing <c>baseUri</c> so the default base URL from the OpenAPI spec applies.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public GitHubClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Collections.Generic.List<global::tryAGI.GitHub.EndPointAuthorization>? authorizations,
            global::tryAGI.GitHub.AutoSDKClientOptions? options,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri: null,
                authorizations,
                options,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the GitHubClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public GitHubClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Uri? baseUri,
            global::System.Collections.Generic.List<global::tryAGI.GitHub.EndPointAuthorization>? authorizations,
            global::tryAGI.GitHub.AutoSDKClientOptions? options,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            if (baseUri is not null)
            {
                HttpClient.BaseAddress ??= baseUri;
            }
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::tryAGI.GitHub.EndPointAuthorization>();
            Options = options ?? new global::tryAGI.GitHub.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            AutoSDKServerConfiguration.ExplicitBaseUri = baseUri ?? httpClient?.BaseAddress;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);


        /// <summary>
        /// Selects one of the generated server options by id.
        /// </summary>
        public bool TrySelectServer(string serverId)
        {
            if (string.IsNullOrWhiteSpace(serverId))
            {
                return false;
            }

            foreach (var server in s_availableServers)
            {
                if (string.Equals(server.Id, serverId, global::System.StringComparison.OrdinalIgnoreCase))
                {
                    AutoSDKServerConfiguration.SelectedServer = server;
                    AutoSDKServerConfiguration.ExplicitBaseUri = null;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Clears the currently selected server.
        /// </summary>
        public void ClearSelectedServer()
        {
            AutoSDKServerConfiguration.SelectedServer = null;
        }

        private global::tryAGI.GitHub.AutoSDKServer? ResolveSelectedServer()
        {
            var selectedServer = AutoSDKServerConfiguration.SelectedServer;
            if (selectedServer is null)
            {
                return null;
            }

            foreach (var server in s_availableServers)
            {
                if (string.Equals(server.Id, selectedServer.Id, global::System.StringComparison.Ordinal))
                {
                    return server;
                }
            }

            return null;
        }

        private void SelectServer(global::tryAGI.GitHub.AutoSDKServer? server)
        {
            if (server is null)
            {
                AutoSDKServerConfiguration.SelectedServer = null;
                return;
            }

            foreach (var candidate in s_availableServers)
            {
                if (string.Equals(candidate.Id, server.Id, global::System.StringComparison.Ordinal))
                {
                    AutoSDKServerConfiguration.SelectedServer = candidate;
                    AutoSDKServerConfiguration.ExplicitBaseUri = null;
                    return;
                }
            }

            throw new global::System.ArgumentException("The provided server is not available for this client.", nameof(server));
        }

        private global::System.Uri? ResolveDisplayedBaseUri()
        {
            if (AutoSDKServerConfiguration.ExplicitBaseUri is global::System.Uri explicitBaseUri)
            {
                return explicitBaseUri;
            }

            return ResolveSelectedServer()?.Uri ?? (s_availableServers.Length > 0 ? s_availableServers[0].Uri : HttpClient.BaseAddress);
        }

        private global::System.Uri? ResolveBaseUri(
            global::tryAGI.GitHub.AutoSDKServer[] servers,
            string defaultBaseUrl)
        {
            if (AutoSDKServerConfiguration.ExplicitBaseUri is global::System.Uri explicitBaseUri)
            {
                return explicitBaseUri;
            }

            if (AutoSDKServerConfiguration.SelectedServer is global::tryAGI.GitHub.AutoSDKServer selectedServer)
            {
                foreach (var server in servers)
                {
                    if (string.Equals(server.Id, selectedServer.Id, global::System.StringComparison.Ordinal))
                    {
                        return server.Uri;
                    }
                }
            }

            if (servers.Length > 0)
            {
                return servers[0].Uri;
            }

            return string.IsNullOrWhiteSpace(defaultBaseUrl)
                ? HttpClient.BaseAddress
                : new global::System.Uri(defaultBaseUrl, global::System.UriKind.RelativeOrAbsolute);
        }
    }
}