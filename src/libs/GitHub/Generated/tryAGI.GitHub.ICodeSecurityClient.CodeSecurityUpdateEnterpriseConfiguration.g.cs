#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICodeSecurityClient
    {
        /// <summary>
        /// Update a custom code security configuration for an enterprise<br/>
        /// Updates a code security configuration in an enterprise.<br/>
        /// The authenticated user must be an administrator of the enterprise in order to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="configurationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CodeSecurityConfiguration> CodeSecurityUpdateEnterpriseConfigurationAsync(
            string enterprise,
            int configurationId,

            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a custom code security configuration for an enterprise<br/>
        /// Updates a code security configuration in an enterprise.<br/>
        /// The authenticated user must be an administrator of the enterprise in order to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="configurationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CodeSecurityConfiguration>> CodeSecurityUpdateEnterpriseConfigurationAsResponseAsync(
            string enterprise,
            int configurationId,

            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a custom code security configuration for an enterprise<br/>
        /// Updates a code security configuration in an enterprise.<br/>
        /// The authenticated user must be an administrator of the enterprise in order to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="configurationId"></param>
        /// <param name="name">
        /// The name of the code security configuration. Must be unique across the enterprise.
        /// </param>
        /// <param name="description">
        /// A description of the code security configuration
        /// </param>
        /// <param name="advancedSecurity">
        /// The enablement status of GitHub Advanced Security features. `enabled` will enable both Code Security and Secret Protection features.<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; `code_security` and `secret_protection` are deprecated values for this field. Prefer the individual `code_security` and `secret_protection` fields to set the status of these features.
        /// </param>
        /// <param name="codeSecurity">
        /// The enablement status of GitHub Code Security features.
        /// </param>
        /// <param name="dependencyGraph">
        /// The enablement status of Dependency Graph
        /// </param>
        /// <param name="dependencyGraphAutosubmitAction">
        /// The enablement status of Automatic dependency submission
        /// </param>
        /// <param name="dependencyGraphAutosubmitActionOptions">
        /// Feature options for Automatic dependency submission
        /// </param>
        /// <param name="dependabotAlerts">
        /// The enablement status of Dependabot alerts
        /// </param>
        /// <param name="dependabotSecurityUpdates">
        /// The enablement status of Dependabot security updates
        /// </param>
        /// <param name="codeScanningDefaultSetup">
        /// The enablement status of code scanning default setup
        /// </param>
        /// <param name="codeScanningDefaultSetupOptions">
        /// Feature options for code scanning default setup
        /// </param>
        /// <param name="codeScanningOptions">
        /// Security Configuration feature options for code scanning
        /// </param>
        /// <param name="codeScanningDelegatedAlertDismissal">
        /// The enablement status of code scanning delegated alert dismissal<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretProtection">
        /// The enablement status of GitHub Secret Protection features.
        /// </param>
        /// <param name="secretScanning">
        /// The enablement status of secret scanning
        /// </param>
        /// <param name="secretScanningPushProtection">
        /// The enablement status of secret scanning push protection
        /// </param>
        /// <param name="secretScanningValidityChecks">
        /// The enablement status of secret scanning validity checks
        /// </param>
        /// <param name="secretScanningNonProviderPatterns">
        /// The enablement status of secret scanning non-provider patterns
        /// </param>
        /// <param name="secretScanningGenericSecrets">
        /// The enablement status of Copilot secret scanning<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningDelegatedAlertDismissal">
        /// The enablement status of secret scanning delegated alert dismissal<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningExtendedMetadata">
        /// The enablement status of secret scanning extended metadata<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="privateVulnerabilityReporting">
        /// The enablement status of private vulnerability reporting
        /// </param>
        /// <param name="enforcement">
        /// The enforcement status for a security configuration
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CodeSecurityConfiguration> CodeSecurityUpdateEnterpriseConfigurationAsync(
            string enterprise,
            int configurationId,
            string? name = default,
            string? description = default,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity? advancedSecurity = default,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestCodeSecurity? codeSecurity = default,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraph? dependencyGraph = default,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphAutosubmitAction? dependencyGraphAutosubmitAction = default,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphAutosubmitActionOptions? dependencyGraphAutosubmitActionOptions = default,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlerts? dependabotAlerts = default,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdates? dependabotSecurityUpdates = default,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDefaultSetup? codeScanningDefaultSetup = default,
            global::tryAGI.GitHub.CodeScanningDefaultSetupOptions? codeScanningDefaultSetupOptions = default,
            global::tryAGI.GitHub.CodeScanningOptions? codeScanningOptions = default,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDelegatedAlertDismissal? codeScanningDelegatedAlertDismissal = default,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretProtection? secretProtection = default,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanning? secretScanning = default,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningPushProtection? secretScanningPushProtection = default,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningValidityChecks? secretScanningValidityChecks = default,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns? secretScanningNonProviderPatterns = default,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningGenericSecrets? secretScanningGenericSecrets = default,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningDelegatedAlertDismissal? secretScanningDelegatedAlertDismissal = default,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningExtendedMetadata? secretScanningExtendedMetadata = default,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestPrivateVulnerabilityReporting? privateVulnerabilityReporting = default,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestEnforcement? enforcement = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}