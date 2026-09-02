#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICodeSecurityClient
    {
        /// <summary>
        /// Create a code security configuration for an enterprise<br/>
        /// Creates a code security configuration in an enterprise.<br/>
        /// The authenticated user must be an administrator of the enterprise in order to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CodeSecurityConfiguration> CodeSecurityCreateConfigurationForEnterpriseAsync(
            string enterprise,

            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a code security configuration for an enterprise<br/>
        /// Creates a code security configuration in an enterprise.<br/>
        /// The authenticated user must be an administrator of the enterprise in order to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CodeSecurityConfiguration>> CodeSecurityCreateConfigurationForEnterpriseAsResponseAsync(
            string enterprise,

            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a code security configuration for an enterprise<br/>
        /// Creates a code security configuration in an enterprise.<br/>
        /// The authenticated user must be an administrator of the enterprise in order to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="name">
        /// The name of the code security configuration. Must be unique within the enterprise.
        /// </param>
        /// <param name="description">
        /// A description of the code security configuration
        /// </param>
        /// <param name="advancedSecurity">
        /// The enablement status of GitHub Advanced Security features. `enabled` will enable both Code Security and Secret Protection features.<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; `code_security` and `secret_protection` are deprecated values for this field. Prefer the individual `code_security` and `secret_protection` fields to set the status of these features.<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="codeSecurity">
        /// The enablement status of GitHub Code Security features.
        /// </param>
        /// <param name="dependencyGraph">
        /// The enablement status of Dependency Graph<br/>
        /// Default Value: enabled
        /// </param>
        /// <param name="dependencyGraphAutosubmitAction">
        /// The enablement status of Automatic dependency submission<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="dependencyGraphAutosubmitActionOptions">
        /// Feature options for Automatic dependency submission
        /// </param>
        /// <param name="dependabotAlerts">
        /// The enablement status of Dependabot alerts<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="dependabotSecurityUpdates">
        /// The enablement status of Dependabot security updates<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="codeScanningOptions">
        /// Security Configuration feature options for code scanning
        /// </param>
        /// <param name="codeScanningDefaultSetup">
        /// The enablement status of code scanning default setup<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="codeScanningDefaultSetupOptions">
        /// Feature options for code scanning default setup
        /// </param>
        /// <param name="codeScanningDelegatedAlertDismissal">
        /// The enablement status of code scanning delegated alert dismissal<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretProtection">
        /// The enablement status of GitHub Secret Protection features.
        /// </param>
        /// <param name="secretScanning">
        /// The enablement status of secret scanning<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningPushProtection">
        /// The enablement status of secret scanning push protection<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningValidityChecks">
        /// The enablement status of secret scanning validity checks<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningNonProviderPatterns">
        /// The enablement status of secret scanning non provider patterns<br/>
        /// Default Value: disabled
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
        /// The enablement status of private vulnerability reporting<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="enforcement">
        /// The enforcement status for a security configuration<br/>
        /// Default Value: enforced
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CodeSecurityConfiguration> CodeSecurityCreateConfigurationForEnterpriseAsync(
            string enterprise,
            string name,
            string? description = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity? advancedSecurity = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurity? codeSecurity = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraph? dependencyGraph = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphAutosubmitAction? dependencyGraphAutosubmitAction = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphAutosubmitActionOptions? dependencyGraphAutosubmitActionOptions = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestDependabotAlerts? dependabotAlerts = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestDependabotSecurityUpdates? dependabotSecurityUpdates = default,
            global::tryAGI.GitHub.CodeScanningOptions? codeScanningOptions = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDefaultSetup? codeScanningDefaultSetup = default,
            global::tryAGI.GitHub.CodeScanningDefaultSetupOptions? codeScanningDefaultSetupOptions = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDelegatedAlertDismissal? codeScanningDelegatedAlertDismissal = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretProtection? secretProtection = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanning? secretScanning = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningPushProtection? secretScanningPushProtection = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningValidityChecks? secretScanningValidityChecks = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningNonProviderPatterns? secretScanningNonProviderPatterns = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningGenericSecrets? secretScanningGenericSecrets = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningDelegatedAlertDismissal? secretScanningDelegatedAlertDismissal = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningExtendedMetadata? secretScanningExtendedMetadata = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestPrivateVulnerabilityReporting? privateVulnerabilityReporting = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestEnforcement? enforcement = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}